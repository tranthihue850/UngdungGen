using System;
using System.Configuration;
using System.Windows.Forms;
using GeneticSharp;

namespace WinFormsAppGen
{
    public partial class frmMain : Form
    {
        string myConnection = ConfigurationManager.AppSettings["connectionString"].ToString();
        CStatusGenetic updateRun;
        private int MinValue;
        private int MaxValue;

        private bool IsNumberic(string input)
        {
            bool isNumeric = input.All(char.IsDigit);
            return isNumeric;
        }

        public int MinPopulation
        {
            get
            {
                if (string.IsNullOrEmpty(txtPopulationMin.Text) || !IsNumberic(txtPopulationMin.Text))
                {
                    return 100;
                }
                else
                {
                    return int.Parse(txtPopulationMin.Text);
                }
            }
            set
            {
                MinValue = value;
            }
        }

        public int MaxPopulation
        {
            get
            {
                if (string.IsNullOrEmpty(txtPopulationMax.Text) || !IsNumberic(txtPopulationMax.Text))
                {
                    return 200;
                }
                else
                {
                    var maxValue = int.Parse(txtPopulationMax.Text);
                    if (maxValue <= MinValue)
                        return 200;
                    return int.Parse(txtPopulationMax.Text);
                }
            }
            set
            {
                MaxValue = value;
            }
        }

        private void UpdateLog(int generation, double bestFitness, string bestSolution, string dataSearch, string searchType, int minPop, int maxPop)
        {
            GeneticRunInfo infoData = new GeneticRunInfo();
            infoData.Generation = generation;
            infoData.BestFitness = bestFitness;
            infoData.BestSolution = bestSolution;
            infoData.DataSearch = dataSearch;
            infoData.SearchType = searchType;
            infoData.MinPopulation = minPop;
            infoData.MaxPopulation = maxPop;
            updateRun.InsertRecordAfterRun(infoData);
        }

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
            UpdateLog(1, 0.5, bestText, targetText, "Normal", MinPopulation, MaxPopulation);
            dataGridViewRun.DataSource = updateRun.SelectGeneticRunInfo();
        }

        private void btnTuongdong_Click(object sender, EventArgs e)
        {
            string targetText = "HELLO WORLD";
            var fitness = new TextFitnessSimilar(targetText);
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
            UpdateLog(1, 0.5, bestText, targetText, "Similarity", MinPopulation, MaxPopulation);
            dataGridViewRun.DataSource = updateRun.SelectGeneticRunInfo();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

        }

        private void inputStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.ShowDialog();
        }
    }

}
