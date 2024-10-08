﻿using System;
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
        public List<Student> Students { get; set; }
        public int Ins_Id  { get; set; }

        public Instructor Instructor { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} :: Name : {Name} :: HiringDate : {HiringDate} :: InstructorId : {Ins_Id}";
        }
    }
}
