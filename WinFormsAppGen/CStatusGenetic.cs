using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class GeneticRunInfo
    {
        public Guid Id { get; set; }
        public int Generation { get; set; }
        public double BestFitness { get; set; }
        public string BestSolution { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DataSearch { get; set; }
        public string SearchType { get; set; }
    }

    public class CStatusGenetic
    {
        private string ConnectionString; 
        public CStatusGenetic(string connString)
        {
            ConnectionString = connString;
        }

        public bool InsertRecordAfterRun(GeneticRunInfo dataRun)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string sqlQuery = string.Format(Common.SqlInsertRun, dataRun.Generation, dataRun.BestFitness,
                    dataRun.BestSolution, dataRun.DataSearch, dataRun.SearchType);
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
    }
}
