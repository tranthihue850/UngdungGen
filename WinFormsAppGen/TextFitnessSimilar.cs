using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class TextFitnessSimilar : IFitness
    {
        private readonly string _targetText;

        public TextFitnessSimilar(string targetText)
        {
            _targetText = targetText;
        }

        public double Evaluate(IChromosome chromosome)
        {
            var generatedText = string.Join("", chromosome.GetGenes().Select(g => (char)g.Value));
            return CalculateSimilarity(generatedText);
        }

        private double CalculateSimilarity(string generatedText)
        {
            int score = 0;

            for (int i = 0; i < _targetText.Length; i++)
            {
                if (i < generatedText.Length && generatedText[i] == _targetText[i])
                {
                    score++;
                }
            }

            // Độ tương đồng được tính theo tỷ lệ phần trăm
            return (double)score; // Trả về điểm số thay vì tỷ lệ
        }
    }
}
