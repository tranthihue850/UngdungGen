using GeneticSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow;

namespace WinFormsAppGen
{
    public class CGenChromosome
    {
        public int Index { get; set; } // Chỉ số của tài liệu
        public double Fitness { get; set; } // Độ thích nghi

        public CGenChromosome(int index)
        {
            Index = index;
            Fitness = 0;
        }

        public double Evaluate(CGenChromosome chromosome, string[] documents, string query)
        {
            string document = documents[chromosome.Index];
            int matchCount = document.Split(' ').Count(word => word.Equals(query, StringComparison.OrdinalIgnoreCase));
            chromosome.Fitness = matchCount; // Độ thích nghi là số lần xuất hiện của từ khóa
            return chromosome.Fitness;
        }

        public List<CGenChromosome> InitializePopulation(int populationSize, int documentCount)
        {
            Random random = new Random();
            var population = new List<CGenChromosome>();

            for (int i = 0; i < populationSize; i++)
            {
                int index = random.Next(0, documentCount);
                population.Add(new CGenChromosome(index));
            }

            return population;
        }

        public CGenChromosome SelectParent(List<CGenChromosome> population)
        {
            Random random = new Random();
            double totalFitness = population.Sum(c => c.Fitness);
            double randomValue = random.NextDouble() * totalFitness;

            foreach (var chromosome in population)
            {
                randomValue -= chromosome.Fitness;
                if (randomValue <= 0)
                {
                    return chromosome;
                }
            }

            return population.Last(); // Trả về chromosome cuối nếu không tìm thấy
        }

        public CGenChromosome Crossover(CGenChromosome parent1, CGenChromosome parent2)
        {
            // Ví dụ đơn giản: chọn một trong hai chỉ số ngẫu nhiên
            return new CGenChromosome(new Random().Next(0, 2) == 0 ? parent1.Index : parent2.Index);
        }

        public void Mutate(CGenChromosome chromosome, int documentCount)
        {
            // Đột biến: thay đổi chỉ số của chromosome ngẫu nhiên
            if (new Random().NextDouble() < 0.1) // 10% khả năng đột biến
            {
                chromosome.Index = new Random().Next(0, documentCount);
            }
        }

        public string RunGeneticAlgorithm(string[] documents, string query)
        {
            int populationSize = 50;
            var population = InitializePopulation(populationSize, documents.Length);
            int generations = 100;

            for (int generation = 0; generation < generations; generation++)
            {
                // Đánh giá quần thể
                foreach (var chromosome in population)
                {
                    Evaluate(chromosome, documents, query);
                }

                // Tạo thế hệ mới
                var newPopulation = new List<CGenChromosome>();
                for (int i = 0; i < populationSize; i++)
                {
                    var parent1 = SelectParent(population);
                    var parent2 = SelectParent(population);
                    var offspring = Crossover(parent1, parent2);
                    Mutate(offspring, documents.Length);
                    newPopulation.Add(offspring);
                }
                population = newPopulation;
            }

            // Tìm kiếm kết quả tốt nhất
            var bestChromosome = population.OrderByDescending(c => c.Fitness).First();
            return $"Best Match: {documents[bestChromosome.Index]} (Fitness: {bestChromosome.Fitness})";
        }
    }
}
