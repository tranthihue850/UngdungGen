using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class CosineSimilarityFitness : IFitness
    {
        private readonly string _target;

        public CosineSimilarityFitness(string target)
        {
            _target = target;
        }

        public double Evaluate(IChromosome chromosome)
        {
            var genes = chromosome.GetGenes().Select(g => (char)g.Value).ToArray();
            var candidate = new string(genes);

            return CosineSimilarity(candidate, _target);
        }

        private double CosineSimilarity(string text1, string text2)
        {
            var vector1 = GetWordVector(text1);
            var vector2 = GetWordVector(text2);

            double dotProduct = vector1.Zip(vector2, (x, y) => x * y).Sum();
            double magnitude1 = Math.Sqrt(vector1.Sum(x => x * x));
            double magnitude2 = Math.Sqrt(vector2.Sum(x => x * x));

            if (magnitude1 == 0 || magnitude2 == 0) return 0;
            return dotProduct / (magnitude1 * magnitude2);
        }

        private double[] GetWordVector(string text)
        {
            var words = text.ToLower().Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var uniqueWords = words.Distinct().ToArray();
            double[] vector = new double[uniqueWords.Length];

            for (int i = 0; i < uniqueWords.Length; i++)
            {
                vector[i] = words.Count(w => w == uniqueWords[i]);
            }

            return vector;
        }
    }
}
