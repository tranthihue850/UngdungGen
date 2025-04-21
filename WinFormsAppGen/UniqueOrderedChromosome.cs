using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class UniqueOrderedChromosome : ChromosomeBase
    {
        private static readonly int[] _possibleValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public UniqueOrderedChromosome(int length) : base(length)
        {
            CreateGenes();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            // Tạo một gene từ danh sách giá trị duy nhất
            return new Gene(_possibleValues[geneIndex]);
        }

        public override IChromosome CreateNew()
        {
            return new UniqueOrderedChromosome(Length);
        }

        public void ShuffleGenes()
        {
            // Sắp xếp ngẫu nhiên các gene
            var random = new Random();
            var shuffledValues = _possibleValues.OrderBy(x => random.Next()).ToArray();
            for (int i = 0; i < Length; i++)
            {
                ReplaceGene(i, new Gene(shuffledValues[i]));
            }
        }
    }
}
