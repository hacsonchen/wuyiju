namespace Dapper
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    public static class DapperHelper
    {
        private static Cache<string, Func<IDataReader, object>> deserializers = new Cache<string, Func<IDataReader, object>>();
        private static MethodInfo methodGetDeserializer = typeof(SqlMapper).GetMethod("GetDeserializer", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { typeof(Type), typeof(IDataReader), typeof(int), typeof(int), typeof(bool) }, null);
        private static MethodInfo methodGetParameterReader = typeof(SqlMapper).GetMethod("GetParameterReader", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { typeof(IDbConnection), typeof(CommandDefinition).MakeByRefType() }, null);
        private static MethodInfo methodSetupCommand = typeof(CommandDefinition).GetMethod("SetupCommand", BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(IDbConnection), typeof(Action<IDbCommand, object>) }, null);
        private static Cache<string, Action<IDbCommand, object>> parameterreaders = new Cache<string, Action<IDbCommand, object>>();

        private static int GetColumnHash(IDataReader reader)
        {
            int fieldCount = reader.FieldCount;
            int num2 = fieldCount;
            for (int i = 0; i < fieldCount; i++)
            {
                object name = reader.GetName(i);
                num2 = (num2 * 0x1f) + ((name == null) ? 0 : name.GetHashCode());
            }
            return num2;
        }

        private static Func<IDataReader, object> GetDeserializer<T>(string identity, IDataReader reader)
        {
            return deserializers.Get(identity, () => methodGetDeserializer.Invoke(null, new object[] { typeof(T), reader, 0, -1, false }) as Func<IDataReader, object>);
        }

        private static string GetIdentity(string sql, CommandType? commandType, IDbConnection connection, Type type, Type parametersType, Type[] otherTypes)
        {
            return string.Format("auto_cnn:{0}_type:{1}_sql:{2}_paramType:{3}_othersType:{4}_cmdType:{5}", new object[] { connection.ConnectionString, type, sql, parametersType, otherTypes, commandType });
        }

        private static Action<IDbCommand, object> GetParameterReader(string identity, IDbConnection cnn, CommandDefinition command)
        {
            return parameterreaders.Get(identity, () => methodGetParameterReader.Invoke(null, new object[] { cnn, command }) as Action<IDbCommand, object>);
        }

        public static T ReadObject<T>(this IDbCommand cmd, IDataReader reader, object paramObj = null)
        {
            CommandDefinition definition = new CommandDefinition(cmd.CommandText, paramObj, cmd.Transaction, new int?(cmd.CommandTimeout), new CommandType?(cmd.CommandType), CommandFlags.Buffered, new CancellationToken());

            Type type = typeof(T);
            object parameters = definition.Parameters;
            int columnHash = GetColumnHash(reader);
            string sql = definition.CommandText + columnHash;
            Func<IDataReader, object> deserializer = GetDeserializer<T>(GetIdentity(sql, definition.CommandType, cmd.Connection, type, (parameters == null) ? null : parameters.GetType(), null), reader);
            Type conversionType = Nullable.GetUnderlyingType(type) ?? type;
            object obj3 = deserializer(reader);
            if ((obj3 != null) && !(obj3 is T))
            {
                return (T)Convert.ChangeType(obj3, conversionType, CultureInfo.InvariantCulture);
            }
            return (T)obj3;
        }

        public static IDbCommand SetupCommand(this IDbConnection cnn, string sql, object paramObj = null, IDbTransaction transaction = null, int? commandTimeout = new int?(), CommandType? commandType = new CommandType?())
        {
            Action<IDbCommand, object> action = null;
            CommandDefinition command = new CommandDefinition(sql, paramObj, transaction, commandTimeout, commandType, CommandFlags.Buffered, new CancellationToken());
            object parameters = command.Parameters;
            if (parameters != null)
            {
                action = GetParameterReader(GetIdentity(command.CommandText, command.CommandType, cnn, null, parameters.GetType(), null), cnn, command);
            }
            return (methodSetupCommand.Invoke(command, new object[] { cnn, action }) as IDbCommand);
        }

        private class Cache<TKey, TValue>
        {
            private ReaderWriterLockSlim _lock;
            private Dictionary<TKey, TValue> _map;

            public Cache()
            {
                this._lock = new ReaderWriterLockSlim();
                this._map = new Dictionary<TKey, TValue>();
            }

            public void Flush()
            {
                this._lock.EnterWriteLock();
                try
                {
                    this._map.Clear();
                }
                finally
                {
                    this._lock.ExitWriteLock();
                }
            }

            public TValue Get(TKey key, Func<TValue> factory)
            {
                TValue local;
                TValue local2;
                this._lock.EnterReadLock();
                try
                {
                    if (this._map.TryGetValue(key, out local))
                    {
                        return local;
                    }
                }
                finally
                {
                    this._lock.ExitReadLock();
                }
                this._lock.EnterWriteLock();
                try
                {
                    if (this._map.TryGetValue(key, out local))
                    {
                        return local;
                    }
                    local = factory();
                    this._map.Add(key, local);
                    local2 = local;
                }
                finally
                {
                    this._lock.ExitWriteLock();
                }
                return local2;
            }

            public int Count
            {
                get
                {
                    return this._map.Count;
                }
            }
        }
    }
}

