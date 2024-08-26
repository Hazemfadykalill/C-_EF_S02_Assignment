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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {



            // Define the primary key
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn(10,2);



            builder.Property(d => d.Name)
                   .IsRequired() // Name is required
                   .HasMaxLength(100); // Set a maximum length for Name

            builder.Property(d => d.HiringDate)
                   .IsRequired().HasColumnType("date"); // HiringDate is required

            //Foreign Key [ Department|| Student]
            builder.HasMany(D => D.Students).
                WithOne(S => S.Department).
                HasForeignKey(S => S.Dept_Id);



            //Foreign Key [Department || Instructor]
            builder.HasOne(D => D.Instructor).WithOne(I => I.Department).HasForeignKey<Department>(D=>D.Ins_Id);
       



        }
    }
}
