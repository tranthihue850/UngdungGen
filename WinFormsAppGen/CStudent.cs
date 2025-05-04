using System;
using System.Collections.Generic;
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
    }
}
