using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Entities
{
    public class Topic
    {

        public int Id { get; set; }
        public string Name { get; set; }

        //foreign Key
        public int Course_ID { get; set; }

        public Course Course { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} :: Name : {Name} ::  CpurseId : {Course_ID}";
        }

    }
}
