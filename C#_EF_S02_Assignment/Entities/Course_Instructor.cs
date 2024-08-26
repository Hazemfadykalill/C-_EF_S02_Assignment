using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class Course_Instructor
    {
        // Composite Key
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }
    }
}
