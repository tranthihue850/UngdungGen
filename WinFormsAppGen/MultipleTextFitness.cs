using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class MultipleTextFitness : IFitness
    {
        private readonly string[] _targetTexts;

        public MultipleTextFitness(string[] targetTexts)
        {
            _targetTexts = targetTexts;
        }

        public double Evaluate(IChromosome chromosome)
        {
            var generatedText = string.Join("", chromosome.GetGenes().Select(g => (char)g.Value));
            return _targetTexts.Max(target => CalculateSimilarity(generatedText, target));
        }

        private double CalculateSimilarity(string generatedText, string targetText)
        {
            int score = 0;

            for (int i = 0; i < Math.Min(generatedText.Length, targetText.Length); i++)
            {
                if (generatedText[i] == targetText[i])
                {
                    score++;
                }
            }

            // Trả về điểm số tương đồng
            return score;
        }
    }
}
