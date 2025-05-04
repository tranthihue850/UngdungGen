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
            ((System.ComponentModel.ISupportInitialize)dataGridViewRun).BeginInit();
            mainMenuStrip.SuspendLayout();
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
            richTextBox1.Location = new Point(12, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 203);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(316, 155);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(325, 23);
            txtKetqua.TabIndex = 2;
            // 
            // txtPopulationMin
            // 
            txtPopulationMin.Location = new Point(416, 64);
            txtPopulationMin.Name = "txtPopulationMin";
            txtPopulationMin.Size = new Size(100, 23);
            txtPopulationMin.TabIndex = 3;
            txtPopulationMin.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 67);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Population Min:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 96);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 6;
            label2.Text = "Population Max:";
            // 
            // txtPopulationMax
            // 
            txtPopulationMax.Location = new Point(416, 93);
            txtPopulationMax.Name = "txtPopulationMax";
            txtPopulationMax.Size = new Size(100, 23);
            txtPopulationMax.TabIndex = 5;
            txtPopulationMax.Text = "200";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 135);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Kết quả tốt nhất:";
            // 
            // btnTuongdong
            // 
            btnTuongdong.Location = new Point(659, 31);
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
            dataGridViewRun.Location = new Point(12, 244);
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
            inputStudentToolStripMenuItem.Size = new Size(180, 22);
            inputStudentToolStripMenuItem.Text = "Input Student";
            inputStudentToolStripMenuItem.Click += inputStudentToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 511);
            Controls.Add(dataGridViewRun);
            Controls.Add(btnTuongdong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPopulationMax);
            Controls.Add(label1);
            Controls.Add(txtPopulationMin);
            Controls.Add(txtKetqua);
            Controls.Add(richTextBox1);
            Controls.Add(btnThuchien);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Name = "frmMain";
            Text = "Genertic";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRun).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
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
    }
}
