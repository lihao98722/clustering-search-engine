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
    class BaiduSearch
    {
        protected string uri = "http://www.baidu.com/s?wd=";

        protected Encoding queryEncoding = Encoding.GetEncoding("UTF-8");
        protected Encoding pageEncoding = Encoding.GetEncoding("UTF-8");

        protected string resultPattern = @"(?<=找到相关结果[约]?)[0-9,]*?(?=个)"; //通过此消息判断换页

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
            int num = 100;//搜索条数
            string url = "http://www.baidu.com/s?wd=" + txtSearch.Trim() + "&rn=" + num + "";
            Uri urls = new Uri(url);
            //string html = search(url, "gb2312");
            string html = SearchProc.search(url, "UTF-8");

            html = html.Replace("<em>", "");
            html = html.Replace("</em>", "");

            //一定要预处理，把一下字符串去掉，否则匹配时会漏掉大部分的link
            html = html.Replace("\n\t", "");
            html = html.Replace("\n", "");
            html = html.Replace("\n", "");
            html = html.Replace("\t", "");

            //一起赋值
            this.txtSearch = txtSearch;
            this.html = html;

            webBrowser1.Url = urls;
            //List<Keyword> keywords = null;
            if (!string.IsNullOrEmpty(html))
            {
                int count = this.GetSearchCount(html);//搜索条数
                if (count > 0)
                {
                    t = new Thread(new ThreadStart(GetKeywordsThread));
                    t.Start();
                    t.Join();
                }
            }
            return this.keywords;
        }

        public int GetSearchCount(string html)
        {
            int result = 0;
            string searchcount = string.Empty;

            Regex regex = new Regex(resultPattern);
            Match match = regex.Match(html);
            if (match.Success)
            {
                searchcount = match.Value;
            }
            else
            {
                searchcount = "0";
            }

            if (searchcount.IndexOf(",") > 0)
            {
                searchcount = searchcount.Replace(",", string.Empty);
            }

            int.TryParse(searchcount, out result);
            return result;
        }

        public List<Keyword> GetKeywords(string html, string word)
        {

            int i = 1;
            List<Keyword> keywords = new List<Keyword>();
            string ss = "<h3 class=\"t\"><a.*?href=\"(?<url>.*?)\".*?>(?<content>.*?)</a>";
            //string ss = "<a.*?href=\"(?<url>.*?)\".*?>(?<content>.*?)</a>";

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
                        keyword.Link = mTable.Groups["url"].Value;
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
