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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {


    
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id)
                  .UseIdentityColumn(5,2);



            builder.Property(i => i.Name)
                   .IsRequired() // Name is required
                   .HasMaxLength(100); // Set a maximum length for Name

            builder.Property(i => i.Bouns)
                   .HasColumnType("decimal(18,2)"); // Set Bouns to be a decimal with precision

            builder.Property(i => i.Salary)
                   .HasColumnType("decimal(18,2)"); // Set Salary to be a decimal with precision

            builder.Property(i => i.Address)
                   .HasMaxLength(200); // Set a maximum length for Address

            builder.Property(i => i.HourRate)
                   .HasColumnType("decimal(18,2)"); // Set HourRate to be a decimal with precision

     
            //Foreign Key [Department || Instructor]
            builder.HasOne(I => I.Department).
                WithOne(D => D.Instructor).
                HasForeignKey<Instructor>(I => I.Dept_Id);
        }
    }
}
