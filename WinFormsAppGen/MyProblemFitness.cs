using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class MyProblemFitness : IFitness
    {
        private readonly int _target;

        public MyProblemFitness(int target)
        {
            _target = target;
        }

        public double Evaluate(IChromosome chromosome)
        {
            // Đánh giá độ thích nghi (thay đổi theo yêu cầu của bạn)
            //return 1.0; // Ví dụ
            var sum = chromosome.GetGenes().Sum(g => (int)g.Value);
            return 1.0 / (1.0 + Math.Abs(_target - sum)); // Đánh giá độ thích nghi
        }
    }
}
