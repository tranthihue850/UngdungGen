using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class OTMultipleTextFitness : IFitness
    {
        private readonly string[] targetTexts;
        private readonly string targetValue;

        public OTMultipleTextFitness(string[] targetTexts, string targetValue)
        {
            this.targetTexts = targetTexts;
            this.targetValue = targetValue;
        }

        public double Evaluate(IChromosome chromosome)
        {
            var generatedText = string.Join("", chromosome.GetGenes().Select(g => (char)g.Value));

            // Tính toán độ thích nghi dựa trên sự gần gũi với targetValue
            int fitnessValue = CalculateFitness(generatedText);

            return fitnessValue;
        }

        private int CalculateFitness(string generatedText)
        {
            // Độ thích nghi là số ký tự khớp với targetValue
            int matchCount = 0;

            for (int i = 0; i < Math.Min(generatedText.Length, targetValue.Length); i++)
            {
                if (generatedText[i] == targetValue[i])
                {
                    matchCount++;
                }
            }

            // Trả về độ thích nghi (có thể điều chỉnh hệ số)
            return matchCount;
        }
    }
}
