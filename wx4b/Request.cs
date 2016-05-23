using System;
using System.IO;
using System.Net;

namespace QTCSharpTool
{
    /// <summary>
    /// 简单的获取远程数据的类
    /// </summary>
    public static class Request
    {
        /// <summary>
        ///  GET方法获取远程数据，默认UTF-8编码       
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <returns>string</returns>
        public static string get(string url)
        {
            return wr("GET", url, "", "utf-8", "");
        }

        /// <summary>
        /// GET方法获取远程数据，手动指定编码
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <param name="EncodingBodyName">目标网页编码</param>
        /// <returns>string</returns>
        public static string get(string url, string EncodingBodyName)
        {
            return wr("GET", url, "", EncodingBodyName, "");
        }

        /// <summary>
        /// GET方法获取远程数据，手动指定编码和cookies
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="EncodingBodyName">目标网页编码</param>
        /// <param name="Cookies">cookies</param>
        /// <returns>string</returns>
        public static string get(string url, string EncodingBodyName, string Cookies)
        {
            return wr("GET", url, "", EncodingBodyName, Cookies);
        }

        /// <summary>
        /// POST方法获取远程数据，默认UTF-8编码
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <param name="data">需要提交的数据</param>
        /// <returns>string</returns>
        public static string post(string url, string data)
        {
            return wr("POST", url, data, "utf-8", "");
        }

        /// <summary>
        /// POST方法获取远程数据，手动指定编码
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <param name="data">需要提交的数据</param>
        /// <param name="EncodingBodyName">目标网页编码</param>
        /// <returns>string</returns>
        public static string post(string url, string data, string EncodingBodyName)
        {
            return wr("POST", url, data, EncodingBodyName, "");
        }
        /// <summary>
        /// POST方法获取远程数据，手动指定编码和cookies
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="data">需要提交的数据</param>
        /// <param name="EncodingBodyName">目标网页编码</param>
        /// <param name="Cookies">cookies</param>
        /// <returns>string</returns>
        public static string post(string url, string data, string EncodingBodyName, string Cookies)
        {
            return wr("POST", url, data, EncodingBodyName, Cookies);
        }

        private static string wr(string method, string url, string postData, string EncodingBodyName, string Cookies)
        {
            HttpWebRequest webRequest = null;
            StreamWriter requestWriter = null;
            string responseData = "";
            webRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            webRequest.Method = method;
            //webRequest.ServicePoint.Expect100Continue = false;
            webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; Trident/7.0; rv:11.0) like Gecko";
            webRequest.Timeout = 20000;
            webRequest.UseDefaultCredentials = true;
            if (!string.IsNullOrEmpty(Cookies)) webRequest.Headers.Add("Cookie", Cookies);
            if (method == "POST" || method == "PUT")
            {
                if (method == "PUT")
                {
                    webRequest.ContentType = "text/xml";
                    webRequest.Method = "PUT";
                }
                else
                {
                    webRequest.ContentType = "application/x-www-form-urlencoded";
                    //webRequest.ContentType = "multipart/form-data";
                }
                //POST the data.
                using (requestWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    requestWriter.Write(postData);
                }
            }

            responseData = WebResponseGet(webRequest, EncodingBodyName);
            webRequest = null;

            return responseData;
        }

        private static string WebResponseGet(HttpWebRequest webRequest, string EncodingBodyName)
        {
            string responseData = "";
            using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream(), System.Text.Encoding.GetEncoding(EncodingBodyName)))
            {
                responseData = responseReader.ReadToEnd();
                webRequest.GetResponse().GetResponseStream().Close();
                responseReader.Close();
            }
            return responseData;
        }

        /// <summary>
        /// 获取cookies，但在某些情况下并不能获得完整的cookies
        /// </summary>
        /// <param name="url">需要获取cookie的url</param>
        /// <returns>string</returns>
        public static string GetCookie(string url)
        {
            CookieContainer cookies = new CookieContainer();
            HttpWebRequest Http = (HttpWebRequest)WebRequest.Create(url);
            Http.Timeout = 2000;
            Http.Accept = "*/*";
            Http.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0;)";
            Http.CookieContainer = new CookieContainer(); //暂存到新实例
            Http.GetResponse().Close();
            cookies = Http.CookieContainer; //保存cookies
            return Http.CookieContainer.GetCookieHeader(Http.RequestUri); //把cookies转换成字符串
        }

    }
}
