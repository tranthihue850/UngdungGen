namespace WinFormsAppGen
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnThuchien = new Button();
            richTextBox1 = new RichTextBox();
            txtKetqua = new TextBox();
            txtPopulationMin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPopulationMax = new TextBox();
            label3 = new Label();
            btnTuongdong = new Button();
            dataGridViewRun = new DataGridView();
            mainMenuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            inputStudentToolStripMenuItem = new ToolStripMenuItem();
            btnTimkiem = new Button();
            btnSearchMul = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            txtGenerationNum = new TextBox();
            tabControlAlgorithm = new TabControl();
            tabGen = new TabPage();
            label6 = new Label();
            tabBruteForce = new TabPage();
            txtSearchBruteForce = new TextBox();
            label8 = new Label();
            richTextBox2 = new RichTextBox();
            label7 = new Label();
            btnBruteForce = new Button();
            tabKMP = new TabPage();
            tabRabinKarp = new TabPage();
            tabBoyesMore = new TabPage();
            btnKMPSearch = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            tabSuffixTree = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRun).BeginInit();
            mainMenuStrip.SuspendLayout();
            tabControlAlgorithm.SuspendLayout();
            tabGen.SuspendLayout();
            tabBruteForce.SuspendLayout();
            tabKMP.SuspendLayout();
            SuspendLayout();
            // 
            // btnThuchien
            // 
            btnThuchien.Location = new Point(804, 31);
            btnThuchien.Name = "btnThuchien";
            btnThuchien.Size = new Size(75, 23);
            btnThuchien.TabIndex = 0;
            btnThuchien.Text = "Thực hiện";
            btnThuchien.UseVisualStyleBackColor = true;
            btnThuchien.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 155);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(336, 164);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(325, 23);
            txtKetqua.TabIndex = 2;
            // 
            // txtPopulationMin
            // 
            txtPopulationMin.Location = new Point(436, 73);
            txtPopulationMin.Name = "txtPopulationMin";
            txtPopulationMin.Size = new Size(100, 23);
            txtPopulationMin.TabIndex = 3;
            txtPopulationMin.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 76);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Population Min:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 105);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 6;
            label2.Text = "Population Max:";
            // 
            // txtPopulationMax
            // 
            txtPopulationMax.Location = new Point(436, 102);
            txtPopulationMax.Name = "txtPopulationMax";
            txtPopulationMax.Size = new Size(100, 23);
            txtPopulationMax.TabIndex = 5;
            txtPopulationMax.Text = "200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 144);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Kết quả tốt nhất:";
            // 
            // btnTuongdong
            // 
            btnTuongdong.Location = new Point(677, 31);
            btnTuongdong.Name = "btnTuongdong";
            btnTuongdong.Size = new Size(121, 23);
            btnTuongdong.TabIndex = 8;
            btnTuongdong.Text = "Tính tương đồng";
            btnTuongdong.UseVisualStyleBackColor = true;
            btnTuongdong.Click += btnTuongdong_Click;
            // 
            // dataGridViewRun
            // 
            dataGridViewRun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRun.Location = new Point(12, 297);
            dataGridViewRun.Name = "dataGridViewRun";
            dataGridViewRun.RowTemplate.Height = 25;
            dataGridViewRun.Size = new Size(901, 255);
            dataGridViewRun.TabIndex = 10;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(937, 24);
            mainMenuStrip.TabIndex = 11;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { inputStudentToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 20);
            toolStripMenuItem1.Text = "Main";
            // 
            // inputStudentToolStripMenuItem
            // 
            inputStudentToolStripMenuItem.Name = "inputStudentToolStripMenuItem";
            inputStudentToolStripMenuItem.Size = new Size(146, 22);
            inputStudentToolStripMenuItem.Text = "Input Student";
            inputStudentToolStripMenuItem.Click += inputStudentToolStripMenuItem_Click;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(810, 72);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(75, 23);
            btnTimkiem.TabIndex = 12;
            btnTimkiem.Text = "Tìm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnSearchMul
            // 
            btnSearchMul.Location = new Point(768, 9);
            btnSearchMul.Name = "btnSearchMul";
            btnSearchMul.Size = new Size(119, 23);
            btnSearchMul.TabIndex = 13;
            btnSearchMul.Text = "Thực hiện";
            btnSearchMul.UseVisualStyleBackColor = true;
            btnSearchMul.Click += btnSearchMul_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 12);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 14;
            label4.Text = "Nội dung cần tìm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(436, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(165, 23);
            txtSearch.TabIndex = 15;
            txtSearch.Text = "Anh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 46);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 17;
            label5.Text = "Generation Num:";
            // 
            // txtGenerationNum
            // 
            txtGenerationNum.Location = new Point(436, 43);
            txtGenerationNum.Name = "txtGenerationNum";
            txtGenerationNum.Size = new Size(100, 23);
            txtGenerationNum.TabIndex = 16;
            txtGenerationNum.Text = "1000";
            // 
            // tabControlAlgorithm
            // 
            tabControlAlgorithm.Controls.Add(tabGen);
            tabControlAlgorithm.Controls.Add(tabBruteForce);
            tabControlAlgorithm.Controls.Add(tabKMP);
            tabControlAlgorithm.Controls.Add(tabRabinKarp);
            tabControlAlgorithm.Controls.Add(tabBoyesMore);
            tabControlAlgorithm.Controls.Add(tabSuffixTree);
            tabControlAlgorithm.Location = new Point(12, 31);
            tabControlAlgorithm.Name = "tabControlAlgorithm";
            tabControlAlgorithm.SelectedIndex = 0;
            tabControlAlgorithm.Size = new Size(913, 231);
            tabControlAlgorithm.TabIndex = 18;
            // 
            // tabGen
            // 
            tabGen.Controls.Add(label6);
            tabGen.Controls.Add(txtPopulationMin);
            tabGen.Controls.Add(btnSearchMul);
            tabGen.Controls.Add(label5);
            tabGen.Controls.Add(txtKetqua);
            tabGen.Controls.Add(richTextBox1);
            tabGen.Controls.Add(txtGenerationNum);
            tabGen.Controls.Add(label1);
            tabGen.Controls.Add(txtSearch);
            tabGen.Controls.Add(txtPopulationMax);
            tabGen.Controls.Add(label4);
            tabGen.Controls.Add(label2);
            tabGen.Controls.Add(label3);
            tabGen.Location = new Point(4, 24);
            tabGen.Name = "tabGen";
            tabGen.Padding = new Padding(3);
            tabGen.Size = new Size(905, 203);
            tabGen.TabIndex = 0;
            tabGen.Text = "Genertic";
            tabGen.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 18;
            label6.Text = "Kết quả chạy:";
            // 
            // tabBruteForce
            // 
            tabBruteForce.BackColor = Color.Gainsboro;
            tabBruteForce.Controls.Add(txtSearchBruteForce);
            tabBruteForce.Controls.Add(label8);
            tabBruteForce.Controls.Add(richTextBox2);
            tabBruteForce.Controls.Add(label7);
            tabBruteForce.Controls.Add(btnBruteForce);
            tabBruteForce.Location = new Point(4, 24);
            tabBruteForce.Name = "tabBruteForce";
            tabBruteForce.Padding = new Padding(3);
            tabBruteForce.Size = new Size(905, 203);
            tabBruteForce.TabIndex = 1;
            tabBruteForce.Text = "Brute Force";
            // 
            // txtSearchBruteForce
            // 
            txtSearchBruteForce.Location = new Point(299, 35);
            txtSearchBruteForce.Name = "txtSearchBruteForce";
            txtSearchBruteForce.Size = new Size(173, 23);
            txtSearchBruteForce.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 14);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 3;
            label8.Text = "Nội dung cần tìm:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(22, 35);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(244, 147);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 13);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 1;
            label7.Text = "Kết quả chạy:";
            // 
            // btnBruteForce
            // 
            btnBruteForce.Location = new Point(770, 17);
            btnBruteForce.Name = "btnBruteForce";
            btnBruteForce.Size = new Size(99, 23);
            btnBruteForce.TabIndex = 0;
            btnBruteForce.Text = "Thực hiện";
            btnBruteForce.UseVisualStyleBackColor = true;
            btnBruteForce.Click += btnBruteForce_Click;
            // 
            // tabKMP
            // 
            tabKMP.Controls.Add(textBox1);
            tabKMP.Controls.Add(label10);
            tabKMP.Controls.Add(label9);
            tabKMP.Controls.Add(btnKMPSearch);
            tabKMP.Location = new Point(4, 24);
            tabKMP.Name = "tabKMP";
            tabKMP.Size = new Size(905, 203);
            tabKMP.TabIndex = 2;
            tabKMP.Text = "Knuth Morris Pratt";
            tabKMP.UseVisualStyleBackColor = true;
            // 
            // tabRabinKarp
            // 
            tabRabinKarp.BackColor = Color.Gainsboro;
            tabRabinKarp.Location = new Point(4, 24);
            tabRabinKarp.Name = "tabRabinKarp";
            tabRabinKarp.Size = new Size(905, 203);
            tabRabinKarp.TabIndex = 3;
            tabRabinKarp.Text = "Rabin Karp";
            // 
            // tabBoyesMore
            // 
            tabBoyesMore.Location = new Point(4, 24);
            tabBoyesMore.Name = "tabBoyesMore";
            tabBoyesMore.Size = new Size(905, 203);
            tabBoyesMore.TabIndex = 4;
            tabBoyesMore.Text = "Boyer Moore";
            tabBoyesMore.UseVisualStyleBackColor = true;
            // 
            // btnKMPSearch
            // 
            btnKMPSearch.Location = new Point(755, 23);
            btnKMPSearch.Name = "btnKMPSearch";
            btnKMPSearch.Size = new Size(115, 23);
            btnKMPSearch.TabIndex = 0;
            btnKMPSearch.Text = "Thực hiện";
            btnKMPSearch.UseVisualStyleBackColor = true;
            btnKMPSearch.Click += btnKMPSearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 16);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 1;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(328, 23);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 2;
            label10.Text = "Dữ liệu tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 3;
            // 
            // tabSuffixTree
            // 
            tabSuffixTree.BackColor = Color.Gainsboro;
            tabSuffixTree.Location = new Point(4, 24);
            tabSuffixTree.Name = "tabSuffixTree";
            tabSuffixTree.Size = new Size(905, 203);
            tabSuffixTree.TabIndex = 5;
            tabSuffixTree.Text = "Suffix Tree";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 511);
            Controls.Add(tabControlAlgorithm);
            Controls.Add(btnTimkiem);
            Controls.Add(dataGridViewRun);
            Controls.Add(btnTuongdong);
            Controls.Add(btnThuchien);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Name = "frmMain";
            Text = "Genertic";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRun).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            tabControlAlgorithm.ResumeLayout(false);
            tabGen.ResumeLayout(false);
            tabGen.PerformLayout();
            tabBruteForce.ResumeLayout(false);
            tabBruteForce.PerformLayout();
            tabKMP.ResumeLayout(false);
            tabKMP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThuchien;
        private RichTextBox richTextBox1;
        private TextBox txtKetqua;
        private TextBox txtPopulationMin;
        private Label label1;
        private Label label2;
        private TextBox txtPopulationMax;
        private Label label3;
        private Button btnTuongdong;
        private DataGridView dataGridViewRun;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem inputStudentToolStripMenuItem;
        private Button btnTimkiem;
        private Button btnSearchMul;
        private Label label4;
        private TextBox txtSearch;
        private Label label5;
        private TextBox txtGenerationNum;
        private TabControl tabControlAlgorithm;
        private TabPage tabGen;
        private TabPage tabBruteForce;
        private TabPage tabKMP;
        private TabPage tabRabinKarp;
        private TabPage tabBoyesMore;
        private Label label6;
        private Button btnBruteForce;
        private Label label7;
        private RichTextBox richTextBox2;
        private TextBox txtSearchBruteForce;
        private Label label8;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Button btnKMPSearch;
        private TabPage tabSuffixTree;
    }
}
