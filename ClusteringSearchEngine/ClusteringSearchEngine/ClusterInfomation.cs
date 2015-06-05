using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClusteringSearchEngine
{
    class ClusterInfomation
    {
        static List<Keyword> ResultKeywords = new List<Keyword>();
        public static List<Keyword> ClusterInfo(string SearchText, List<List<Keyword>> ListKeywords)
        {
            string[] words = SearchText.Split(' ');
            foreach (List<Keyword> keywords in ListKeywords)
            {
                foreach (Keyword keyword in keywords)
                {
                    bool isContainAll = true;
                    foreach (string word in words)
                    {
                        if (!keyword.Title.Contains(word))
                        {
                            isContainAll = false;
                            break;
                        }
                    }
                    if (isContainAll)
                        ResultKeywords.Add(keyword);
                }
            }
            return ResultKeywords;
        }
    }
}
