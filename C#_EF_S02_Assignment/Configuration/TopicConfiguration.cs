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
    public class TopicConfiguration:IEntityTypeConfiguration<Topic>
    {


        public void Configure(EntityTypeBuilder<Topic> builder)
        {
        builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn(10,10);
        builder.Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(100);

         // Foreign Key [Course || Topic]
         builder.HasOne(T=>T.Course).
                WithMany(C=>C.Topics).
                HasForeignKey(t => t.Course_ID);


        }
    }
}
