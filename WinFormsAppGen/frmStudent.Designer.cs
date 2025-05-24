namespace WinFormsAppGen
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            btnSave = new Button();
            label1 = new Label();
            textBoxStudentId = new TextBox();
            textBoxFullName = new TextBox();
            label2 = new Label();
            textBoxAddress = new TextBox();
            label3 = new Label();
            btnLoad = new Button();
            dataGridViewStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(713, 105);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 30);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Student Id";
            // 
            // textBoxStudentId
            // 
            textBoxStudentId.Location = new Point(124, 25);
            textBoxStudentId.Name = "textBoxStudentId";
            textBoxStudentId.Size = new Size(180, 23);
            textBoxStudentId.TabIndex = 2;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(124, 64);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(180, 23);
            textBoxFullName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Full Name";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(421, 26);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(367, 58);
            textBoxAddress.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 29);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Resident Address";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(618, 105);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(21, 146);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowTemplate.Height = 25;
            dataGridViewStudent.Size = new Size(767, 292);
            dataGridViewStudent.TabIndex = 8;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(dataGridViewStudent);
            Controls.Add(btnLoad);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(textBoxFullName);
            Controls.Add(label2);
            Controls.Add(textBoxStudentId);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStudent";
            Text = "Student Info";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox textBoxStudentId;
        private TextBox textBoxFullName;
        private Label label2;
        private TextBox textBoxAddress;
        private Label label3;
        private Button btnLoad;
        private DataGridView dataGridViewStudent;
    }
}