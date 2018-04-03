using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkoleRegister.Models;

namespace SkoleRegister.ViewModels
{
    class MainViewModel
    {
        private DataManager dm;

        public Student CurrentPerson { get; set; }
        public List<Student> PersonGallery { get; set; } 

        public MainViewModel()
        {
            dm = new DataManager();

            CurrentPerson = dm.ImportantPerson;
            PersonGallery = dm.ImportantPersons;
        }
    }
}
