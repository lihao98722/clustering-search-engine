using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using System.Threading;

namespace ClusteringSearchEngine
{
    class GoogleSearch
    {
        //为了启动线程的方便
        private string txtSearch = null;
        private string html = null;
        List<Keyword> keywords = null;
        private Thread t = null;

        public Thread getThread()
        {
            return this.t;
        }

        public List<Keyword> run(string txtSearch, WebBrowser webBrowser1)
        {
            int num = 100;
            //string url = "http://www.google.com.hk/search?hl=zh-CN&source=hp&q=" + txtSearch.Trim() + "&aq=f&aqi=&aql=&oq=&num=" + num + "";
            string url = "http://www.google.com.hk/search?hl=zh-CN&source=hp&q=" + txtSearch.Trim() + "&num=" + num + "";
            Uri urls = new Uri(url);

            string html = SearchProc.search(url, "UTF-8");
            html = html.Replace("<em>", "");
            html = html.Replace("</em>", "");
            //html = html.Replace("\n\t", "");
            //html = html.Replace("\n", "");
            //html = html.Replace("\n", "");
            //html = html.Replace("\t", "");

            //google 也有用<b>来处理结果
            html = html.Replace("<b>", "");
            html = html.Replace("</b>", "");

            //一起赋值
            this.txtSearch = txtSearch;
            this.html = html;
            webBrowser1.Url = urls;
            //List<Keyword> keywords = null;

            if (!string.IsNullOrEmpty(html))
            {
                t = new Thread(new ThreadStart(GetKeywordsThread));
                t.Start();
                t.Join();
            }
            return this.keywords;
        }

        public List<Keyword> GetKeywords(string html, string word)
        {
            int i = 1;
            List<Keyword> keywords = new List<Keyword>();
            string ss = "<h3 class=\"r\"><a.*?href=\"(?<url>.*?)\".*?>(?<content>.*?)</a>";
            MatchCollection mcTable = Regex.Matches(html, ss);

            foreach (Match mTable in mcTable)
            {
                if (mTable.Success)
                {
                    if (true)
                    {
                        Keyword keyword = new Keyword();
                        keyword.ID = i++;
                        keyword.Title = Regex.Replace(mTable.Groups["content"].Value, "<[^>]*>", string.Empty);

                        //手动解决link中的乱码 "以&sa"开始
                        keyword.Link = mTable.Groups["url"].Value.Substring(0, mTable.Groups["url"].Value.IndexOf("&sa="));
                        keywords.Add(keyword);
                    }
                }
            }

            return keywords;
        }

        private void GetKeywordsThread()
        {
            this.keywords = this.GetKeywords(this.html, this.txtSearch);
        }
    }
}
