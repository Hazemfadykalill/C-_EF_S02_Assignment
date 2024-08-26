using C__EF_S02_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {


        //foreign key
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Foreign Key [Course || Topic]
            builder.HasMany(C => C.Topics).WithOne(T => T.Course).HasForeignKey(C => C.Course_ID);
        }
    }
}
