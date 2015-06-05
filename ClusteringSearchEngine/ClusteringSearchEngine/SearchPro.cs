using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ClusteringSearchEngine
{
    class SearchProc
    {
        // 搜索处理(唯一的public接口)
        public static string search(string url, string Chareset)
        {
            HttpState result = new HttpState();
            Uri uri = new Uri(url);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.UseDefaultCredentials = true;
            myHttpWebRequest.ContentType = "text/html";
            myHttpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.0; .NET CLR 1.1.4322; .NET CLR 2.0.50215;)";
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.CookieContainer = new CookieContainer();

            try
            {
                HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
                // 从 ResponseStream 中读取HTML源码并格式化 add by cqp
                result.Html = readResponseStream(response, Chareset);
                result.CookieContainer = myHttpWebRequest.CookieContainer;
                return result.Html;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private static string readResponseStream(HttpWebResponse response, string Chareset)
        {
            string result = "";
            using (StreamReader responseReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(Chareset)))
            {
                result = formatHTML(responseReader.ReadToEnd());
            }
            return result;
        }

        // 格式化网页源代码
        private static string formatHTML(string htmlContent)
        {
            string result = "";

            result = htmlContent.Replace("&raquo;", "").Replace("&nbsp;", "")
                    .Replace("&copy;", "").Replace("/r", "").Replace("/t", "")
                    .Replace("/n", "").Replace("&amp;", "&");

            //处理google得到的link
            result = result.Replace("/url?q=", "");
            result = result.Replace("/search?q=", "");

            return result;
        }
    }
}
