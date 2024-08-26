using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        // Foreign Key
        public int Ins_Id  { get; set; }
        public List<Student> Students { get; set; }
    }
}
