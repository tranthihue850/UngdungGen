using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class SearchKnuthMorrisPratt
    {
        private string querySearch;
        private string[] inputData;
        public SearchKnuthMorrisPratt(string[] texts, string query)
        {
            querySearch = query;
            inputData = texts;
        }

        // Hàm để tạo mảng prefix
        int[] ComputePrefixFunction(string pattern)
        {
            int m = pattern.Length;
            int[] pi = new int[m];
            int j = 0;

            for (int i = 1; i < m; i++)
            {
                while (j > 0 && pattern[i] != pattern[j])
                {
                    j = pi[j - 1];
                }
                if (pattern[i] == pattern[j])
                {
                    j++;
                }
                pi[i] = j;
            }

            return pi;
        }

        public void KMPAlgorithm(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] pi = ComputePrefixFunction(pattern);
            int j = 0; // chỉ số cho pattern

            for (int i = 0; i < n; i++)
            {
                while (j > 0 && text[i] != pattern[j])
                {
                    j = pi[j - 1];
                }
                if (text[i] == pattern[j])
                {
                    j++;
                }
                if (j == m)
                {
                    Console.WriteLine($"Chuỗi mẫu '{pattern}' được tìm thấy tại vị trí {i - m + 1}");
                    j = pi[j - 1]; // tiếp tục tìm kiếm
                }
            }                        
        }

        public void DoSearch()
        {
            foreach (var text in inputData)
            {
                KMPAlgorithm(text, querySearch);                
            }
        }
    }
}
