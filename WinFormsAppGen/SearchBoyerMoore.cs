using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class SearchBoyerMoore
    {
        private string querySearch;
        private string[] inputData;
        public SearchBoyerMoore(string[] texts, string query)
        {
            querySearch = query;
            inputData = texts;
        }

        private int[] CreateBadCharacterTable(string pattern)
        {
            int[] badChar = new int[256]; // Bảng cho tất cả ký tự ASCII
            for (int i = 0; i < badChar.Length; i++)
            {
                badChar[i] = -1; // Khởi tạo với -1
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                badChar[(int)pattern[i]] = i; // Cập nhật vị trí ký tự
            }

            return badChar;
        }

        private List<int> BMSearch(string text, string pattern)
        {
            int[] badChar = CreateBadCharacterTable(pattern);
            List<int> positions = new List<int>();
            int m = pattern.Length;
            int n = text.Length;
            int s = 0; // Vị trí dịch chuyển

            while (s <= n - m)
            {
                int j = m - 1; // Bắt đầu từ ký tự cuối của mẫu

                while (j >= 0 && pattern[j] == text[s + j])
                {
                    j--;
                }

                if (j < 0)
                {
                    positions.Add(s); // Thêm vị trí tìm thấy
                    s += (s + m < n) ? m - badChar[text[s + m]] : 1; // Dịch chuyển
                }
                else
                {
                    s += Math.Max(1, j - badChar[text[s + j]]); // Dịch chuyển
                }
            }

            return positions;
        }

        public void DoSearch()
        {
            foreach (var text in inputData)
            {
                List<int> result = BMSearch(text, querySearch);
                Console.WriteLine("Pattern found at indices: " + string.Join(", ", result));
            }
        }
    }
}
