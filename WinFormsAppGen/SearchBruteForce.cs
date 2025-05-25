using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class SearchBruteForce
    {
        private string querySearch;
        private string[] inputData;

        public SearchBruteForce(string[] texts, string query) 
        {
            querySearch = query;
            inputData = texts;
        }

        public void DoSearch()
        {
            foreach (var text in inputData)
            {
                int index = BFSearch(text, querySearch);
                if (index != -1)
                {
                    Console.WriteLine($"Chuỗi '{querySearch}' được tìm thấy trong: \"{text}\" tại vị trí: {index}");
                }
                else
                {
                    Console.WriteLine($"Chuỗi '{querySearch}' không được tìm thấy trong: \"{text}\".");
                }
            }
        }

        int BFSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    return i; // Trả về vị trí bắt đầu của pattern trong text
                }
            }
            return -1; // Không tìm thấy
        }
    }
}
