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
            tabControl1 = new TabControl();
            tabGen = new TabPage();
            label6 = new Label();
            tabBruteForce = new TabPage();
            tabKMP = new TabPage();
            tabDFA = new TabPage();
            tabBoyesMore = new TabPage();
            btnBruteForce = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRun).BeginInit();
            mainMenuStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            tabGen.SuspendLayout();
            tabBruteForce.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGen);
            tabControl1.Controls.Add(tabBruteForce);
            tabControl1.Controls.Add(tabKMP);
            tabControl1.Controls.Add(tabDFA);
            tabControl1.Controls.Add(tabBoyesMore);
            tabControl1.Location = new Point(12, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913, 231);
            tabControl1.TabIndex = 18;
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
            tabBruteForce.BackColor = Color.Transparent;
            tabBruteForce.Controls.Add(btnBruteForce);
            tabBruteForce.Location = new Point(4, 24);
            tabBruteForce.Name = "tabBruteForce";
            tabBruteForce.Padding = new Padding(3);
            tabBruteForce.Size = new Size(905, 203);
            tabBruteForce.TabIndex = 1;
            tabBruteForce.Text = "Brute Force";
            // 
            // tabKMP
            // 
            tabKMP.Location = new Point(4, 24);
            tabKMP.Name = "tabKMP";
            tabKMP.Size = new Size(905, 203);
            tabKMP.TabIndex = 2;
            tabKMP.Text = "Knuth Morris Pratt";
            tabKMP.UseVisualStyleBackColor = true;
            // 
            // tabDFA
            // 
            tabDFA.Location = new Point(4, 24);
            tabDFA.Name = "tabDFA";
            tabDFA.Size = new Size(905, 203);
            tabDFA.TabIndex = 3;
            tabDFA.Text = "Determistic";
            tabDFA.UseVisualStyleBackColor = true;
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
            // btnBruteForce
            // 
            btnBruteForce.Location = new Point(770, 17);
            btnBruteForce.Name = "btnBruteForce";
            btnBruteForce.Size = new Size(75, 23);
            btnBruteForce.TabIndex = 0;
            btnBruteForce.Text = "Thực hiện";
            btnBruteForce.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 511);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
            tabGen.ResumeLayout(false);
            tabGen.PerformLayout();
            tabBruteForce.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabGen;
        private TabPage tabBruteForce;
        private TabPage tabKMP;
        private TabPage tabDFA;
        private TabPage tabBoyesMore;
        private Label label6;
        private Button btnBruteForce;
    }
}
