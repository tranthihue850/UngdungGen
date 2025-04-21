using System;
using GeneticSharp;

namespace WinFormsAppGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var fitness = new MyProblemFitness(5);
            //var population = new Population(50, 100, new UniqueOrderedChromosome(10));

            //var selection = new RouletteWheelSelection();
            //var crossover = new OrderedCrossover(); // Sử dụng OrderedCrossover
            //var mutation = new UniformMutation();

            //var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            //{
            //    Termination = new GenerationNumberTermination(1000)
            //};

            //ga.Start();

            //var bestChromosome = ga.BestChromosome;
            //var best = string.Join(", ", bestChromosome.GetGenes().Select(g => g.Value));
            //// Console.WriteLine($"Best Match: {string.Join(", ", bestChromosome.GetGenes().Select(g => g.Value))}");
            
            string targetText = "HELLO WORLD";
            var fitness = new TextFitness(targetText);
            var population = new Population(100, 200, new TextChromosome(targetText.Length));

            var selection = new RouletteWheelSelection();
            var crossover = new UniformCrossover();
            var mutation = new UniformMutation();

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            {
                Termination = new GenerationNumberTermination(1000)
            };

            ga.Start();

            var bestChromosome = ga.BestChromosome;
            var bestText = string.Join("", bestChromosome.GetGenes().Select(g => (char)g.Value));

            txtKetqua.Text = string.Format("Best Match: {0}", bestText);
        }
    }

    

    

    

    
}
