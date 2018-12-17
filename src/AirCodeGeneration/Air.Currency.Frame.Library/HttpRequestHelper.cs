using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Air.Currency.Frame.Library
{

    /// <summary>
    /// 请求的数据类型
    /// </summary>
    public enum WebRequestDataTypeEnums
    {
        JSON = 0,
        XML = 1
    }

    /// <summary>
    /// Http请求对象    
    /// </summary>
    public class HttpRequestHelper
    {

        public CookieContainer Cookie { get; set; }


        /// <summary>
        /// 是否允许重定向(默认:true)
        /// </summary>
        public bool AllowAutoRedirect { get; set; }

        /// <summary>
        /// 设置contentType(默认:application/x-www-form-urlencoded)
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 设置accept(默认:*/*)
        /// </summary>
        public string Accept { get; set; }


        public int TimeOut { get; set; } = 30000;

        private string userAgent;
        /// <summary>
        /// 
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// 接受的语言
        /// </summary>
        public string AcceptLanguage { get; set; }

        public object WebRequestDataTypes { get; private set; }



        /// <summary>
        /// 自定义的http请求Headers对象集合
        /// 如果该集合有值则在默认的Headers集合上新增
        /// </summary>
        public WebHeaderCollection Headers { get; set; }

        /// <summary>
        /// 链接的服务器
        /// </summary>
        public string Host { get; set; }

        public string Referer { get; set; }

        public bool KeepAlive { get; set; }

        /// <summary>
        /// 代理地址
        /// </summary>
        public string ProxyUrl { get; set; }
        /// <summary>
        /// 处理POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postdata"></param>
        /// <returns></returns>
        public string HttpPost(string url, string postdata, Encoding sendEncode,
            Encoding receiveEncode = null, string contentTypePost = null,
            int timeout = 30000)
        {
            try
            {
                if (!string.IsNullOrEmpty(contentTypePost))
                {
                    ContentType = contentTypePost;
                }
                this.TimeOut = timeout;
                var request = CreateWebRequest(url);
                request.Method = "POST";
                if (!string.IsNullOrWhiteSpace(postdata))
                {
                    var bytesToPost = sendEncode.GetBytes(postdata);
                    request.ContentLength = bytesToPost.Length;
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(bytesToPost, 0, bytesToPost.Length);
                        requestStream.Close();
                    }
                }
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var sr = new StreamReader(response.GetResponseStream(), receiveEncode))
                    {
                        string result = sr.ReadToEnd();
                        return result;
                    }
                }
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }




        /// <summary>
        /// 处理POST请求
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="postdata">传输的参数</param>
        /// <param name="isGZip">返回的数据是否采取gzip加密</param>
        /// <param name="sendEncode"></param>
        /// <param name="receiveEncode"></param>
        /// <param name="contentTypePost"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public string HttpPost(string url, string postdata, bool isGZip, Encoding sendEncode,
            Encoding receiveEncode = null, string contentTypePost = null,
            int timeout = 30000)
        {
            try
            {
                if (!string.IsNullOrEmpty(contentTypePost))
                {
                    ContentType = contentTypePost;
                }
                this.TimeOut = timeout;
                var request = CreateWebRequest(url);
                request.Method = "POST";
                if (!string.IsNullOrWhiteSpace(postdata))
                {
                    var bytesToPost = sendEncode.GetBytes(postdata);
                    request.ContentLength = bytesToPost.Length;
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(bytesToPost, 0, bytesToPost.Length);
                        requestStream.Close();
                    }
                }
                if (!isGZip)
                {
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        using (var sr = new StreamReader(response.GetResponseStream(), receiveEncode))
                        {
                            string result = sr.ReadToEnd();
                            return result;
                        }
                    }
                }
                else
                {
                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
                        using (var sr = new StreamReader(stm, receiveEncode))
                        {
                            var result = sr.ReadToEnd();
                            return result;
                        }
                    }
                }
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }


        public string HttpPost(string url, string postdata)
        {
            var request = CreateWebRequest(url);
            request.Method = "POST";
            if (!string.IsNullOrWhiteSpace(postdata))
            {
                var bytesToPost = Encoding.UTF8.GetBytes(postdata);
                request.ContentLength = bytesToPost.Length;
                request.ContentType = this.ContentType;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytesToPost, 0, bytesToPost.Length);
                    requestStream.Close();
                }
            }
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var sr = new StreamReader(response.GetResponseStream(), Encoding.Default))
                {
                    var result = sr.ReadToEnd();
                    return result;
                }
            }
        }

        /// <summary>
        /// 带证书的post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postdata"></param>
        /// <param name="cer"></param>
        /// <returns></returns>
        public string HttpPost(string url, string postdata, X509Certificate cer)
        {
            var request = CreateWebRequest(url);
            request.ClientCertificates.Add(cer);
            request.Method = "POST";
            if (!string.IsNullOrWhiteSpace(postdata))
            {
                var bytesToPost = Encoding.UTF8.GetBytes(postdata);
                request.ContentLength = bytesToPost.Length;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytesToPost, 0, bytesToPost.Length);
                    requestStream.Close();
                }
            }
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var result = sr.ReadToEnd();
                    return result;
                }
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="url"></param>
        ///// <param name="obj"></param>
        ///// <returns></returns>
        //public T HttpPost<T>(string url, object obj, WebRequestDataTypes inputDataType = WebRequestDataTypes.JSON, WebRequestDataTypes outDataType = WebRequestDataTypes.JSON)
        //{
        //    var resultStr = HttpPost(url, JsonConvert.SerializeObject(obj));
        //    return JsonConvert.DeserializeObject<T>(resultStr);
        //}
        public T HttpPost<T>(string url, object obj, out string result,
            Encoding sendEncode = null,
            JsonSerializerSettings inputJsonSettings = null,
            Encoding receiveEncode = null,
            Func<string, string> serializeStrFunc = null,
            WebRequestDataTypeEnums inputDataType = WebRequestDataTypeEnums.JSON,
            WebRequestDataTypeEnums outDataType = WebRequestDataTypeEnums.JSON,
            int timeout = 30000) where T : class
        {
            try
            {
                string postStr = null;
                this.TimeOut = timeout;
                switch (inputDataType)
                {
                    case WebRequestDataTypeEnums.JSON:
                        postStr = XmlHelper.SerializeObject(obj);
                        break;
                    default:
                        //request.ContentType = "text/html;charset=UTF-8";
                        this.ContentType = "application/json;charset=UTF-8 ";//
                        postStr = JsonConvert.SerializeObject(obj, inputJsonSettings);
                        break;
                }
                if (serializeStrFunc != null)
                {
                    postStr = serializeStrFunc(postStr);
                }
                if (sendEncode == null)
                    sendEncode = Encoding.Default;
                if (receiveEncode == null)
                    receiveEncode = Encoding.GetEncoding("gbk");
                result = HttpPost(url, postStr, sendEncode, receiveEncode);          
                try
                {
                    switch (outDataType)
                    {
                        case WebRequestDataTypeEnums.XML:
                            return XmlHelper.XmlDeserialize<T>(result);
                        default:
                            return JsonConvert.DeserializeObject<T>(result);
                    }
                }
                catch (Exception ea)
                {
                    throw new Exception("解析出参[" + result + "]异常!" + ea.Message);
                }
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

        /// <summary>
        /// 带证书的post
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="obj"></param>
        /// <param name="cer"></param>
        /// <param name="result"></param>
        /// <param name="serializeStrFunc"></param>
        /// <param name="inputDataType"></param>
        /// <param name="outDataType"></param>
        /// <returns></returns>
        public T HttpPost<T>(string url, object obj, X509Certificate2 cer, out string result,
            Func<string, string> serializeStrFunc = null,
            WebRequestDataTypeEnums inputDataType = WebRequestDataTypeEnums.JSON,
            WebRequestDataTypeEnums outDataType = WebRequestDataTypeEnums.JSON,
            int timeout = 30000) where T : class
        {
            string postStr = null;
            this.TimeOut = timeout;
            switch (inputDataType)
            {
                case WebRequestDataTypeEnums.XML:
                    postStr = XmlHelper.SerializeObject(obj);
                    break;
                default:
                    this.ContentType = "application/json; charset=UTF-8 ";
                    postStr = JsonConvert.SerializeObject(obj);
                    break;
            }
            if (serializeStrFunc != null)
            {
                postStr = serializeStrFunc(postStr);
            }
            result = HttpPost(url, postStr, cer);
            switch (outDataType)
            {
                case WebRequestDataTypeEnums.XML:
                    return XmlHelper.XmlDeserialize<T>(result);
                default:
                    return JsonConvert.DeserializeObject<T>(result);
            }
        }
        /// <summary>
        /// post请求返回html
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postDataStr"></param>
        /// <returns></returns>
        public string HttpPost(string url, Dictionary<string, string> postdata)
        {
            string postDataStr = null;
            if (postdata != null && postdata.Count > 0)
            {
                postDataStr = string.Join("&", postdata.Select(it => it.Key + "=" + it.Value));
            }
            return HttpPost(url, postdata);
        }

        /// <summary>
        /// get请求获取返回的html
        /// </summary>
        /// <param name="url">无参URL</param>
        /// <param name="querydata">参数</param>
        /// <returns></returns>
        public string HttpGet(string url, Dictionary<string, string> querydata)
        {
            if (querydata != null && querydata.Count > 0)
            {
                url += "?" + string.Join("&", querydata.Select(it => it.Key + "=" + it.Value));
            }
            return HttpGet(url);
        }
        /// <summary>
        /// get请求获取返回的html
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string HttpGet(string url)
        {
            HttpWebRequest request = CreateWebRequest(url);
            request.Method = "GET";
            // response.Cookies = cookie.GetCookies(response.ResponseUri);
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")))
                {
                    var result = sr.ReadToEnd();
                    return result;
                }
            }
        }


        public BaseResponse<HttpWebResponse> HttpGet(string url, Encoding receiveEncode = null)
        {
            string result = string.Empty;
            HttpWebRequest request = CreateWebRequest(url);
            request.Method = "GET";
            BaseResponse<HttpWebResponse> output = new BaseResponse<HttpWebResponse>();
            var response = (HttpWebResponse)request.GetResponse();
            Stream stm = new System.IO.Compression.GZipStream(response.GetResponseStream(), System.IO.Compression.CompressionMode.Decompress);
            using (var sr = new StreamReader(stm, receiveEncode))
            {
                result = sr.ReadToEnd();
            }

            //获取cookies
            response.Cookies = Cookie.GetCookies(response.ResponseUri);
            output.Value = result;

            return output;
        }


        /// <summary>
        /// 替换部分字符串
        /// </summary>
        /// <param name="sPassed">需要替换的字符串</param>
        /// <returns></returns>

        private static string ReplaceString(string sContent)
        {
            if (sContent == null) { return sContent; }
            if (sContent.Contains("\\"))
            {
                sContent = sContent.Replace("\\", "\\\\");
            }
            if (sContent.Contains("\'"))
            {
                sContent = sContent.Replace("\'", "\\\'");
            }
            if (sContent.Contains("\""))
            {
                sContent = sContent.Replace("\"", "\\\"");
            }
            //去掉字符串的回车换行符
            sContent = Regex.Replace(sContent, @"[\n\r]", "");
            sContent = sContent.Trim();
            return sContent;
        }

        public System.IO.Stream HttpGetStream(string url)
        {
            HttpWebRequest request = CreateWebRequest(url);
            request.Method = "GET";
            // response.Cookies = cookie.GetCookies(response.ResponseUri);
            var response = (HttpWebResponse)request.GetResponse();
            return response.GetResponseStream();
        }

        protected HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            ;
            if (Cookie != null)
                request.CookieContainer = this.Cookie;
            if (string.IsNullOrEmpty(this.AcceptLanguage))
            {
                WebHeaderCollection myWebHeaderCollection = request.Headers;
                myWebHeaderCollection.Add("Accept-Language", this.AcceptLanguage);
            }
            if (Headers != null && Headers.Count > 0)
            {
                request.Headers = this.Headers;
            }
            if (!string.IsNullOrWhiteSpace(ProxyUrl))
            {
                request.Proxy = new WebProxy(ProxyUrl);
            }

            request.Referer = this.Referer;
            request.Accept = this.Accept;
            request.UseDefaultCredentials = true;
            request.UserAgent = this.UserAgent;
            request.KeepAlive = this.KeepAlive;
            request.ContentType = this.ContentType;
            request.AllowAutoRedirect = this.AllowAutoRedirect;
            this.SetCertificatePolicy();
            return request;
        }

        /// <summary>
        /// POST文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="file">文件路径</param>
        /// <param name="postdata"></param>
        /// <returns></returns>
        public string HttpUploadFile(string url, string file, Dictionary<string, string> postdata)
        {
            return HttpUploadFile(url, file, postdata, Encoding.UTF8);
        }
        /// <summary>
        /// POST文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="file">文件路径</param>
        /// <param name="postdata">参数</param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string HttpUploadFile(string url, string file, Dictionary<string, string> postdata, Encoding encoding)
        {
            return HttpUploadFile(url, new string[] { file }, postdata, encoding);
        }
        /// <summary>
        /// POST文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="files">文件路径</param>
        /// <param name="postdata">参数</param>
        /// <returns></returns>
        public string HttpUploadFile(string url, string[] files, Dictionary<string, string> postdata)
        {
            return HttpUploadFile(url, files, postdata, Encoding.UTF8);
        }
        /// <summary>
        /// POST文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="files">文件路径</param>
        /// <param name="postdata">参数</param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string HttpUploadFile(string url, string[] files, Dictionary<string, string> postdata, Encoding encoding)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endbytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");


            HttpWebRequest request = CreateWebRequest(url);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = true; ;
            request.AllowAutoRedirect = this.AllowAutoRedirect;
            if (this.Cookie != null)
                request.CookieContainer = this.Cookie;
            request.Credentials = CredentialCache.DefaultCredentials;

            using (Stream stream = request.GetRequestStream())
            {
                //1.1 key/value
                string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                if (postdata != null)
                {
                    foreach (string key in postdata.Keys)
                    {
                        stream.Write(boundarybytes, 0, boundarybytes.Length);
                        string formitem = string.Format(formdataTemplate, key, postdata[key]);
                        byte[] formitembytes = encoding.GetBytes(formitem);
                        stream.Write(formitembytes, 0, formitembytes.Length);
                    }
                }

                //1.2 file
                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
                byte[] buffer = new byte[4096];
                int bytesRead = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    stream.Write(boundarybytes, 0, boundarybytes.Length);
                    string header = string.Format(headerTemplate, "file" + i, Path.GetFileName(files[i]));
                    byte[] headerbytes = encoding.GetBytes(header);
                    stream.Write(headerbytes, 0, headerbytes.Length);
                    using (FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    {
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            stream.Write(buffer, 0, bytesRead);
                        }
                    }
                }

                //1.3 form end
                stream.Write(endbytes, 0, endbytes.Length);
            }
            //2.WebResponse
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                return stream.ReadToEnd();
            }
        }


        /// <summary>
        /// 获得响应中的图像
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Stream GetResponseImage(string url)
        {
            Stream stream = null;
            try
            {
                HttpWebRequest request = CreateWebRequest(url);
                request.KeepAlive = true;
                request.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                stream = res.GetResponseStream();
                return stream;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 正则获取匹配的第一个值
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private string GetStringByRegex(string html, string pattern)
        {
            Regex re = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matchs = re.Matches(html);
            if (matchs.Count > 0)
            {
                return matchs[0].Groups[1].Value;
            }
            else
                return "";
        }
        /// <summary>
        /// 正则验证返回的response是否正确
        /// </summary>
        /// <param name="html">Html内容</param>
        /// <param name="pattern">正则表达式</param>
        /// <returns></returns>
        private bool VerifyResponseHtml(string html, string pattern)
        {
            Regex re = new Regex(pattern);
            return re.IsMatch(html);
        }
        //注册证书验证回调事件，在请求之前注册
        private void SetCertificatePolicy()
        {
            ServicePointManager.ServerCertificateValidationCallback
                       += RemoteCertificateValidate;
        }
        /// <summary> 
        /// 远程证书验证，固定返回true
        /// </summary> 
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert,
            X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
    }
}
