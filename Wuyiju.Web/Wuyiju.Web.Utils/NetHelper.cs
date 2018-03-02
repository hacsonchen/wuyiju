using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace Wuyiju.Web.Utils
{
	/// <summary>
	/// 此类用来接收请求的数据包，以及发送数据包
	/// </summary>
	public class NetHelper
	{

		public string GetRequestData(HttpContext context)
		{
			string postString = "";
			if (context == null)
			{
				throw new Exception("此方法只能运用在WEB上下文环境。");
			}
			using (Stream stream = HttpContext.Current.Request.InputStream)
			{
				using (StreamReader sr = new StreamReader(stream))
				{
					postString = sr.ReadToEnd();
				}
				//Byte[] postBytes = new Byte[stream.Length];
				//stream.Read(postBytes, 0, (Int32)stream.Length);
				//postString = Encoding.UTF8.GetString(postBytes);
			}

			return postString;

		}

		public string GetRequestData(Stream stream)
		{
			string postString = "";
			if (stream.CanSeek)
			{
				stream.Seek(0, SeekOrigin.Begin);
			}
			if (stream.CanRead)
			{
				using (StreamReader sr = new StreamReader(stream))
				{

					postString = sr.ReadToEnd();
				}
				//Byte[] postBytes = new Byte[stream.Length];
				//stream.Read(postBytes, 0, (Int32)stream.Length);
				//postString = Encoding.UTF8.GetString(postBytes);
			}

			return postString;

		}

		public string InvokeWebGet(string url)
		{
			Stream data = null;
			WebClient wc = new WebClient();

			try
			{
				data = wc.OpenRead(url);
				if (data == null)
				{
					//Logger.Logger.Warn("执行Get请求时无法获取请求的内容.Url地址：" + url);
					return "";
				}
				string result = GetRequestData(data);
				data.Close();

				return result;
			}
			catch (Exception ex)
			{
				//Logger.Logger.Warn("执行Get请求时失败，原因：\r\n" + ex.Message + "\r\nUrl地址：" + url);
				return "";
			}
		}

		public string InvokeWebGet(string url, out string error)
		{
			error = "";
			Stream data = null;
			WebClient wc = new WebClient();
			try
			{
				data = wc.OpenRead(url);
				if (data == null)
					return "";

				string result = GetRequestData(data);
				data.Close();

				return result;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				return "";
			}
		}

		public string InvokeWebPostByBytes(string url, byte[] sendData)
		{
			WebClient wc = new WebClient();
			string baseStr = "";
			try
			{
				baseStr = Convert.ToBase64String(sendData);
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				wc.Headers.Add("ContentLength", sendData.Length.ToString());

				byte[] recData = wc.UploadData(new Uri(url), "POST", sendData);

				string res = Encoding.UTF8.GetString(recData);
				return res;
			}
			catch (Exception ex)
			{
				//Logger.Logger.Error("执行Post请求时失败，原因：\r\n" + ex.Message + "\r\nUrl地址：" + url);
				//Logger.Logger.Error("POST内容(BASE64编码)：" + baseStr);
				//Logger.Logger.Error(ex.StackTrace);
				return "";
			}
		}

		public string InvokeWebPost(string url, string postData)
		{
			WebClient wc = new WebClient();
			StringBuilder postBuilder = new StringBuilder();
			postBuilder.Append(postData);
			byte[] sendData = Encoding.UTF8.GetBytes(postBuilder.ToString());

			string baseStr = "";

			try
			{
				baseStr = Convert.ToBase64String(sendData);
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				wc.Headers.Add("ContentLength", sendData.Length.ToString());

				byte[] recData = wc.UploadData(new Uri(url), "POST", sendData);

				string res = Encoding.UTF8.GetString(recData);

				return res;
			}
			catch (Exception ex)
			{
				//Logger.Logger.Error("执行Post请求时失败，原因：\r\n" + ex.Message + "\r\nUrl地址：" + url);
				//Logger.Logger.Error("POST内容(BASE64编码)：" + baseStr);
				//Logger.Logger.Error(ex.StackTrace);
				return "";
			}

		}

		public string InvokePostResponse(string url, string postData)
		{
			StringBuilder postBuilder = new StringBuilder();
			postBuilder.Append(postData);
			byte[] sendData = Encoding.UTF8.GetBytes(postBuilder.ToString());
			HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(url);
			wreq.Method = "POST";
			wreq.ContentType = "application/x-www-form-urlencoded";
			wreq.ContentLength = sendData.Length;
			wreq.AllowAutoRedirect = true;
			CookieContainer cookieCon = new CookieContainer();
			wreq.CookieContainer = cookieCon;

			try
			{
				HttpWebResponse wresp = (HttpWebResponse)wreq.GetResponse();
				Stream s = wresp.GetResponseStream();
				StreamReader objReader = new StreamReader(s, System.Text.Encoding.UTF8);

				string res = objReader.ReadToEnd();
				return res;
			}
			catch (Exception ex)
			{
				//Logger.Logger.Error("执行Post请求时失败，原因：\r\n" + ex.Message + "\r\nUrl地址：" + url);
				//Logger.Logger.Error(ex.StackTrace);
				return "";
			}
		}

		public void InvokeWebPostAsync(string url, string postData)
		{

			WebClient wc = new WebClient();
			StringBuilder postBuilder = new StringBuilder();
			postBuilder.Append(postData);

			try
			{
				byte[] sendData = Encoding.UTF8.GetBytes(postBuilder.ToString());
				wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
				wc.Headers.Add("ContentLength", sendData.Length.ToString());

				wc.UploadDataAsync(new Uri(url), "POST", sendData);

			}
			catch
			{

			}
		}

		public string InvokeUpload(string url, string filePath, out string error)
		{
			WebClient wc = new WebClient();
			wc.Credentials = CredentialCache.DefaultCredentials;
			error = "";
			try
			{
				byte[] responseArray = wc.UploadFile(url, "POST", filePath);
				string result = System.Text.Encoding.UTF8.GetString(responseArray, 0, responseArray.Length);
				return result;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				return "";
			}

		}

		public string InvokeDownload(string url, string filePath, out string error)
		{
			WebClient wc = new WebClient();
			error = "";

			try
			{

				HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);

				req.Method = "GET";
				using (WebResponse wr = req.GetResponse())
				{
					HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();

					string strpath = myResponse.ResponseUri.ToString();
					string disposition = myResponse.Headers["Content-disposition"];
					if (string.IsNullOrWhiteSpace(disposition))
					{
						error = "下载错误";
						return "";
					}

					if (disposition.IndexOf("attachment", StringComparison.CurrentCultureIgnoreCase) < 0)
					{
						error = "下载错误";
						return "";
					}

					WebClient mywebclient = new WebClient();
					mywebclient.DownloadFile(strpath, filePath);

				}
				if (!File.Exists(filePath))
				{
					error = "下载错误";
					return "";
				}

				return "";

			}
			catch (Exception ex)
			{
				error = ex.Message;
				return "";
			}


		}

		public byte[] InvokeDownload(string url)
		{
			WebClient wc = new WebClient();
			Stream stream = wc.OpenRead(url);
			StreamReader reader = new StreamReader(stream);
			byte[] temp = new byte[1000000];
			int tempLength = (int)temp.Length;
			int lenth = 0;

			while (tempLength > 0)
			{

				int m = stream.Read(temp, lenth, tempLength);
				if (m == 0)
					break;

				lenth += m;
				tempLength -= m;
			}

			reader.Dispose();
			stream.Dispose();

			byte[] res = new byte[lenth];
			Array.Copy(temp, res, lenth);

			return res;
		}

		public void ReplyRequest(HttpContext context, string replyData)
		{
			if (context == null)
			{
				throw new Exception("此方法只能运用在WEB上下文环境。");
			}

			if (context.Response == null)
			{
				throw new Exception("Response对象为空。");
			}

			context.Response.Write(replyData);
			context.Response.End();
		}
	}
}
