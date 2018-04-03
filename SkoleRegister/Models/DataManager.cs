using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleRegister.Models
{
    public class DataManager
    {
        public Student ImportantPerson { get; set; }
        public List<Student> ImportantPersons { get; set; }

        public DataManager()
        {
            ImportantPerson = new Student { FirstName = "Anders", LastName = "And" };
            ImportantPersons = new List<Student>()
            {
                new Student {FirstName = "Anders", LastName="And"},
                new Student {FirstName = "Mickey", LastName="Mouse"},
                new Student {FirstName = "Georg", LastName="Gearløs"},
                new Student {FirstName = "Fætter", LastName="Guf"},
                new Student {FirstName = "Minnie", LastName="Mouse"}
            };
        }
    }
}