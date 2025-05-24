using GeneticSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class MultiplesTextFitness: IFitness
    {
        private readonly string[] targetTexts;
        private readonly string targetValue;

        public MultiplesTextFitness(string[] targetTexts, string targetValue)
        {
            this.targetTexts = targetTexts;
            this.targetValue = targetValue;
        }

        public double Evaluate(IChromosome chromosome)
        {
            int docIndex = (int)chromosome.GetGene(0).Value;

            if (docIndex < 0 || docIndex >= targetTexts.Length)
            {
                return 0; // Trả về 0 nếu chỉ số không hợp lệ
            }

            string documentContent = targetTexts[docIndex];
            
            // Kiểm tra sự xuất hiện của từ khóa
            if (!documentContent.Contains(targetValue, StringComparison.OrdinalIgnoreCase))
            {
                // string selectedText = targetTexts[docIndex];
                int distance = LevenshteinDistance(documentContent, targetValue);
                return 1.0 / (1.0 + distance);
                // return 0; // Nếu không có từ khóa, trả về 0
            }

            int matchCount = documentContent.Split(' ').Count(word => word.Equals(targetValue, StringComparison.OrdinalIgnoreCase));

            return matchCount; // Độ thích nghi là số lần xuất hiện của từ khóa

            //int textIndex = (int)chromosome.GetGene(0).Value;

            //// Đảm bảo chỉ số hợp lệ
            //if (textIndex < 0 || textIndex >= targetTexts.Length)
            //{
            //    return 0; // Trả về 0 nếu chỉ số không hợp lệ
            //}

            //// Lấy chuỗi được chọn từ targetTexts
            //string selectedText = targetTexts[textIndex];

            //// So sánh với targetValue
            //if (selectedText == targetValue)
            //{
            //    return 1; // Độ thích nghi là 1 nếu khớp hoàn toàn
            //}
            //else
            //{
            //    // Hoặc sử dụng Levenshtein Distance để đánh giá mức độ gần gũi
            //    int distance = LevenshteinDistance(selectedText, targetValue);
            //    return 1.0 / (1.0 + distance);
            //}
        }

        // Hàm tính khoảng cách Levenshtein
        private int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            for (int i = 0; i <= n; i++)
            {
                d[i, 0] = i;
            }

            for (int j = 0; j <= m; j++)
            {
                d[0, j] = j;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (s[i - 1] == t[j - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }

            return d[n, m];
        }
    }
}
