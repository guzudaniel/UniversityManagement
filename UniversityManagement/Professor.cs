using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Professor : BasePerson
    {
        public string Course;
        public Professor(string course)
        {
            Course = course;
        }
        public override void Save()
        {

        }
    }
}
