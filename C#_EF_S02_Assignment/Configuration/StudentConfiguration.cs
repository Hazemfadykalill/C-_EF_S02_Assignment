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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {


            // Define the primary key
            builder.HasKey(s => s.Id);

            // Define properties
            builder.Property(s => s.Id)
                   .UseIdentityColumn(10,10); 

            builder.Property(s => s.Age)
                   .IsRequired(); // Age is required

            builder.Property(s => s.FName)
                   .IsRequired() // First Name is required
                   .HasMaxLength(50).
                   HasColumnType("varchar"); // Set a maximum length for FName

            builder.Property(s => s.LName)
                   .IsRequired() // Last Name is required
                   .HasMaxLength(50).
                   HasColumnType("varchar"); // Set a maximum length for LName

            builder.Property(s => s.Address)
                   .HasMaxLength(200).
                   HasColumnType("varchar"); // Set a maximum length for Address

            // Define the foreign key

            builder.HasOne(S => S.Department).
                WithMany(D => D.Students).
                HasForeignKey(Id => Id.Dept_Id);

             
        }
    }
}
