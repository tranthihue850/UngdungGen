using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class SearchRabinKarp
    {
        private string querySearch;
        private string[] inputData;
        public SearchRabinKarp(string[] texts, string query)
        {
            querySearch = query;
            inputData = texts;
        }

        private long CreateHash(string str, int length)
        {
            long hash = 0;
            for (int i = 0; i < length; i++)
            {
                hash += (long)(str[i] * Math.Pow(256, length - 1 - i));
            }
            return hash;
        }

        // Hàm tìm kiếm chuỗi
        public List<int> RKSearch(string text, string pattern)
        {
            int textLength = text.Length;
            int patternLength = pattern.Length;
            long patternHash = CreateHash(pattern, patternLength);
            long textHash = CreateHash(text, patternLength);
            long h = (long)Math.Pow(256, patternLength - 1);
            List<int> positions = new List<int>();

            for (int i = 0; i <= textLength - patternLength; i++)
            {
                // So sánh giá trị băm
                if (patternHash == textHash)
                {
                    // Kiểm tra nội dung chuỗi
                    if (text.Substring(i, patternLength) == pattern)
                    {
                        positions.Add(i);
                    }
                }

                // Tính toán hàm băm cho chuỗi tiếp theo
                if (i < textLength - patternLength)
                {
                    textHash = (256 * textHash - text[i] * h + text[i + patternLength]) % 101;
                    if (textHash < 0)
                    {
                        textHash += 101; // Đảm bảo giá trị băm dương
                    }
                }
            }

            return positions;
        }

        public void DoSearch()
        {
            foreach (var text in inputData)
            {
                List<int> result = RKSearch(text, querySearch);
                Console.WriteLine("Pattern found at indices: " + string.Join(", ", result));
            }
        }
    }
}
