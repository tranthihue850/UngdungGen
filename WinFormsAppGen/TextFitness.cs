using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class TextFitness : IFitness
    {
        private readonly string _target;

        public TextFitness(string target)
        {
            _target = target;
        }

        public double Evaluate(IChromosome chromosome)
        {
            // Đánh giá độ phù hợp của chromosome với chuỗi mục tiêu
            var genes = chromosome.GetGenes().Select(g => (char)g.Value);
            var candidate = new string(genes.ToArray());

            // Tính điểm dựa trên số ký tự trùng khớp
            return candidate.Zip(_target, (c, t) => c == t ? 1 : 0).Sum();
        }
    }
}
