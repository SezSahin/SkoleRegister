using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleRegister.Models
{
    class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int ClassID { get; set; }
        public Course(int id, string name, DateTime time, int classId)
        {
            this.ID = id;
            this.Name = name;
            this.Time = time;
            this.ClassID = classId;
        }
    }
}
