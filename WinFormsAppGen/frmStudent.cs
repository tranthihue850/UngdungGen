using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGen
{
    public partial class frmStudent : Form
    {
        string myConnection = ConfigurationManager.AppSettings["connectionString"].ToString();
        CStudent Student;
        public frmStudent()
        {
            InitializeComponent();
            Student = new CStudent(myConnection);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo();
            student.FullName = textBoxFullName.Text.Replace("'","''");
            student.AddressResident = textBoxAddress.Text.Replace("'", "''");
            Student.InsertRecord(student);
            dataGridViewStudent.DataSource = Student.SelectStudentInfo();
            ResetControl();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = Student.SelectStudentInfo();
        }
        private void ResetControl()
        {
            textBoxFullName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
        }
    }
}
