using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Assignment.Contexts
{
    public class EFS02AssDbContext:DbContext
    {

        //To Connect Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .;Database=EFS02Assignment;Trusted_Connection=True;TrustServerCertificate=True");
        }

        //Configuration Class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        //Names Table That In Database

    }
}
