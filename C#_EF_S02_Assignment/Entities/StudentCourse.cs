using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class StudentCourse
    {
        public double Grade { get; set; }
        //Foreign Key
        public int Student_Id { get; set; }
        public int Course_Id { get; set; }


    }
}
