﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Foreign Key

        public List<Topic> Topics { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} :: Name : {Name} :: Duration : {Duration} :: Description : {Description}";
        }
    }
}
