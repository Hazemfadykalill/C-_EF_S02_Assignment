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

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).UseIdentityColumn(10,10);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            builder.Property(c => c.Duration)
                   .IsRequired();
            // Foreign Key [Course || Topic]
            builder.HasMany(C => C.Topics).WithOne(T => T.Course).HasForeignKey(C => C.Course_ID);
        }
    }
}
