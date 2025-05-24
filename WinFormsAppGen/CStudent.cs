using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class StudentInfo
    {
        public Guid Id { get; set; }        
        public string FullName { get; set; }
        public string AddressResident { get; set; }
        
    }

    public class CStudent
    {
        private string ConnectionString;
        
        public CStudent(string connString)
        {
            ConnectionString = connString;
        }

        public bool InsertRecord(StudentInfo dataRun)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string sqlQuery = string.Format(CommonStudent.SqlInsertStudent, dataRun.FullName, dataRun.AddressResident);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public DataTable SelectStudentInfo()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(CommonStudent.SqlSelectStudent, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tblRun = new DataTable();
            adapter.Fill(tblRun);
            return tblRun;
        }
    }
}
