using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGen
{
    public class Common
    {
        public const string SqlInsertRun = "INSERT INTO GeneticRunInfo (Generation, BestFitness, BestSolution, DataSearch, SearchType, MinPopulation, MaxPopulation) VALUES ({0}, {1}, '{2}','{3}','{4}',{5},{6})";
        public const string SqlSelectRun = "SELECT * FROM GeneticRunInfo Order by CreatedAt Desc";
    }
    public class CommonStudent
    {
        public const string SqlInsertStudent = "INSERT INTO StudenInfo (FullName, AddressResident) VALUES ('{0}', '{1}')";
        public const string SqlSelectStudent = "SELECT * FROM StudenInfo Order by CreatedAt Desc";
    }
}
