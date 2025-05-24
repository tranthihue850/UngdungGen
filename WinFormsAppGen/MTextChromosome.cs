using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class MTextChromosome : ChromosomeBase
    {
        private static Random _random = new Random();
        private readonly string _possibleCharacters;

        public MTextChromosome(int length, string possibleCharacters) : base(length)
        {
            _possibleCharacters = possibleCharacters;
            CreateGene();
        }

        public override IChromosome CreateNew()
        {
            return new MTextChromosome(Length, _possibleCharacters);
        }

        private void CreateGene()
        {
            for (int i = 0; i < Length; i++)
            {
                var randomChar = _possibleCharacters[_random.Next(_possibleCharacters.Length)];                
                base.ReplaceGene(i, new Gene(randomChar));
            }
        }

        public override Gene GenerateGene(int index)
        {
            // Tạo gene ngẫu nhiên từ _possibleCharacters
            var randomChar = _possibleCharacters[_random.Next(_possibleCharacters.Length)];
            return new Gene(randomChar);
        }
    }
}
