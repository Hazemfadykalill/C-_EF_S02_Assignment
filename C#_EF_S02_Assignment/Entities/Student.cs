using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        // Foreign Key
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"Id : {Id} :: FName : {FName} :: LName : {FName} :: Address : {Address} :: DepartmentId : {Dept_Id}";
        }
    }
}
