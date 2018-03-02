using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuyiju.Core
{
    public class Logger
    {
        private ILog log;

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        private Logger()
        {
        }

        public static Logger GetLogger()
        {
            return GetLogger("Wuyiju");
        }

        public static Logger GetLogger(Type type)
        {
            return GetLogger(type.FullName);
        }

        public static Logger GetLogger(string name)
        {
            var log = new Logger();
            log.log = LogManager.GetLogger(name);

            return log;
        }

        public void Debug(object msg)
        {
            if (log.IsDebugEnabled)
            {

                string method = string.Empty;
                try
                {
                    var st = new StackTrace();
                    method = st.GetFrame(1).GetMethod().Name;
                }
                catch { }

                if (string.IsNullOrEmpty(method))
                    log.Debug(msg);
                else
                    log.DebugFormat("{0} => {1}", method, msg);
            }
        }

        //public void Debug(object msg, Exception ex)
        //{
        //    if (log.IsDebugEnabled)
        //        log.Debug(msg, ex);
        //}

        public void Debug(string msg, params object[] args)
        {
            if (log.IsDebugEnabled)
            {
                string method = string.Empty;
                try
                {
                    var st = new StackTrace();
                    method = st.GetFrame(1).GetMethod().Name;
                }
                catch { }

                if (string.IsNullOrEmpty(method))
                    log.DebugFormat(msg, args);
                else
                    log.DebugFormat("{0} => {1}", method, string.Format(msg, args));
            }
        }

        public void Info(object msg)
        {
            if (log.IsInfoEnabled)
                log.Info(msg);
        }

        //public void Info(object msg, Exception ex)
        //{
        //    if (log.IsInfoEnabled)
        //        log.Info(msg, ex);
        //}

        public void Info(string msg, params object[] args)
        {
            if (log.IsInfoEnabled)
                log.InfoFormat(msg, args);
        }

        public void Warn(object msg)
        {
            if (log.IsWarnEnabled)
                log.Warn(msg);
        }

        //public void Warn(object msg, Exception ex)
        //{
        //    if (log.IsWarnEnabled)
        //        log.Warn(msg, ex);
        //}

        public void Warn(string msg, params object[] args)
        {
            if (log.IsWarnEnabled)
                log.WarnFormat(msg, args);
        }

        public void Error(object msg)
        {
            if (log.IsErrorEnabled)
                log.Error(msg);
        }

        //public void Error(object msg, Exception ex)
        //{
        //    if (log.IsErrorEnabled)
        //        log.Error(msg, ex);
        //}

        public void Error(string msg, params object[] args)
        {
            if (log.IsErrorEnabled)
                log.ErrorFormat(msg, args);
        }

        public void Fatal(object msg)
        {
            if (log.IsFatalEnabled)
                log.Fatal(msg);
        }

        //public void Fatal(object msg, Exception ex)
        //{
        //    if (log.IsFatalEnabled)
        //        log.Fatal(msg, ex);
        //}

        public void Fatal(string msg, params object[] args)
        {
            if (log.IsFatalEnabled)
                log.FatalFormat(msg, args);
        }
    }
}
