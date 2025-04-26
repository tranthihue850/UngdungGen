using System;
using System.Configuration;
using GeneticSharp;

namespace WinFormsAppGen
{
    public partial class frmMain : Form
    {
        string myConnection = ConfigurationManager.AppSettings["connectionString"].ToString();
        CStatusGenetic updateRun;
        public frmMain()
        {
            InitializeComponent();
            updateRun = new CStatusGenetic(myConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void btnTuongdong_Click(object sender, EventArgs e)
        {
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
            UpdateLog(1,0.5,bestText,targetText,"Similarity");
        }

        private void UpdateLog(int generation, double bestFitness, string bestSolution, string dataSearch, string searchType)
        {
            GeneticRunInfo infoData = new GeneticRunInfo();
            infoData.Generation = generation;
            infoData.BestFitness = bestFitness;
            infoData.BestSolution = bestSolution;
            infoData.DataSearch = dataSearch;
            infoData.SearchType = searchType;
            updateRun.InsertRecordAfterRun(infoData);
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            
        }
    }

}
