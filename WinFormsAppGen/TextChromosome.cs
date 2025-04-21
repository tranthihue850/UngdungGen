using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class TextChromosome : ChromosomeBase
    {
        private static readonly char[] _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
        private static Random _random = new Random();

        public TextChromosome(int length) : base(length)
        {
            CreateGenes();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            // Tạo gene ngẫu nhiên từ các ký tự có sẵn
            return new Gene(_characters[_random.Next(_characters.Length)]);
        }

        public override IChromosome CreateNew()
        {
            return new TextChromosome(Length);
        }
    }
}
