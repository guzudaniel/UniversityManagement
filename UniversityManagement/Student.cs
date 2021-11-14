using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Student : BasePerson
    {
        public int Year;

        public Student(int year)
        {
            Year = year;
        }
        public override void Save()
        {

        }
    }
}
