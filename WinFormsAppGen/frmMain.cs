using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using GeneticSharp;

namespace WinFormsAppGen
{
    public partial class frmMain : Form
    {
        string myConnection = ConfigurationManager.AppSettings["connectionString"].ToString();
        CStatusGenetic updateRun;
        CStudent Student;
        private int MinValue;
        private int MaxValue;
        private List<string> ListStudentName;

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
            Student = new CStudent(myConnection);
            LoadListStudentName();
        }

        private void LoadListStudentName()
        {
            ListStudentName = new List<string>();
            var students = Student.SelectStudentInfo();
            for (int i = 0; i < students.Rows.Count; i++)
            {
                if (students.Rows[i]["FullName"] != DBNull.Value)
                    ListStudentName.Add(students.Rows[i]["FullName"].ToString());

            }
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Khởi tạo danh sách tên sinh viên
            string[] targetTexts = ListStudentName.ToArray();
            // 
            var targetValue = "Anh";
            // Định nghĩa fitness function
            var fitness = new OTMultipleTextFitness(targetTexts, targetValue);

            // Khởi tạo quần thể
            var population = new Population(100, 200, new MTextChromosome(targetValue.Length, "ABCDEFGHIJKLMNOPQRSTUVWXYZ "));

            // Các thành phần của GA
            var selection = new RouletteWheelSelection();
            var crossover = new UniformCrossover();
            var mutation = new UniformMutation();

            // Khởi tạo thuật toán di truyền
            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            {
                Termination = new GenerationNumberTermination(1000)
            };

            // Bắt đầu thuật toán
            ga.Start();

            // Lấy kết quả tốt nhất
            var bestChromosome = ga.BestChromosome;
            var bestValue = bestChromosome.Fitness.Value;
            var bestText = string.Join("", bestChromosome.GetGenes().Select(g => (char)g.Value));
            txtKetqua.Text = string.Format("Best Match: {0}", bestText);
        }

        private void Timkiem()
        {
            string[] targetTexts = ListStudentName.ToArray();
            var fitness = new MultipleTextFitness(targetTexts);
            var population = new Population(100, 200, new MTextChromosome(30, "ABCDEFGHIJKLMNOPQRSTUVWXYZ "));

            var selection = new RouletteWheelSelection();
            var crossover = new UniformCrossover();
            var mutation = new UniformMutation();

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            {
                Termination = new GenerationNumberTermination(1000)
            };

            ga.Start();

            var bestChromosome = ga.BestChromosome;
            var bestValue = bestChromosome.Fitness.Value;
            var bestText = string.Join("", bestChromosome.GetGenes().Select(g => (char)g.Value));
            UpdateLog(1, bestValue, bestText, String.Join(", ", ListStudentName), "Multiple", MinPopulation, MaxPopulation);
            dataGridViewRun.DataSource = updateRun.SelectGeneticRunInfo();
            txtKetqua.Text = string.Format("Best Match: {0}", bestText);
        }

        private void btnSearchMul_Click(object sender, EventArgs e)
        {
            var targetValue = txtSearch.Text;
            string[] targetTexts = ListStudentName.ToArray();  // new string[] { "Hello Friend", "Hello Papa", "Hella", "Hello" };
            
            // Khởi tạo fitness function
            var fitness = new MultiplesTextFitness(targetTexts, targetValue);

            // Khởi tạo quần thể
            var population = new Population(100, 200, new MutipleTextChromosome(targetTexts));

            // Chọn phương pháp chọn lọc
            var selection = new RouletteWheelSelection(); // TournamentSelection(4); //

            // Định nghĩa các thuật toán tiến hóa
            var crossover = new UniformCrossover();
            var mutation = new UniformMutation();

            // Khởi tạo thuật toán di truyền
            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation)
            {
                Termination = new GenerationNumberTermination(1000),
                CrossoverProbability = 0.9F,
                MutationProbability = 0.05F
            };

            // Bắt đầu thuật toán
            ga.Start();

            // Lấy kết quả tốt nhất
            var bestChromosome = ga.BestChromosome;            
            int bestIndex = (int)bestChromosome.GetGene(0).Value;
            //string bestText = targetTexts[bestIndex];

            if (bestChromosome.Fitness > 0 && bestChromosome.Fitness < 1)
            {
                CGenChromosome check = new CGenChromosome(0);
                var result = check.RunGeneticAlgorithm(targetTexts, targetValue);
                txtKetqua.Text = result;
                UpdateLog(bestIndex, bestChromosome.Fitness ?? 0.0, result, String.Join(", ", ListStudentName), "Multiple", MinPopulation, MaxPopulation);
                dataGridViewRun.DataSource = updateRun.SelectGeneticRunInfo();
                return;
            }

            if (bestIndex >= 0 && bestIndex < targetTexts.Length)
            {
                string bestDocument = targetTexts[bestIndex];
                txtKetqua.Text = $"Best Match: {bestDocument} (Fitness: {bestChromosome.Fitness})";

                UpdateLog(bestIndex, bestChromosome.Fitness ?? 0.0, bestDocument, String.Join(", ", ListStudentName), "Multiple", MinPopulation, MaxPopulation);
                dataGridViewRun.DataSource = updateRun.SelectGeneticRunInfo();
            }
            else
            {
                txtKetqua.Text = "Chỉ số không hợp lệ.";
            }            
            
        }
    }

}
