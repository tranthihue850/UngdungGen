using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class MutipleTextChromosome: ChromosomeBase
    {
        private readonly string[] targetTexts;
        private readonly int chromosomeLength; // Độ dài chromosome

        public MutipleTextChromosome(string[] targetTexts) : base(2)
        {
            this.targetTexts = targetTexts;
            this.chromosomeLength = 1; // Độ dài chromosome luôn là 1

            CreateGenes();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            Random random = new Random();
            int textIndex = random.Next(targetTexts.Length); // Chọn ngẫu nhiên một chỉ số từ targetTexts
            return new Gene(textIndex); // Gene chứa chỉ số của chuỗi
        }

        public override IChromosome CreateNew()
        {
            return new MutipleTextChromosome(targetTexts);
        }

        public override IChromosome Clone()
        {
            var clone = base.Clone() as MutipleTextChromosome;
            return clone;
        }
    }
}
