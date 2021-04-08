using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
        //     public string Address { get; set; }
        //public string Email { get; set; }
        //public string Telephone { get; set; }
        //public string MapIframe { get; set; }

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
          
            builder.Property(c => c.Address).HasColumnType("NVARCHAR(MAX)");

            builder.Property(c => c.Email).HasColumnType("NVARCHAR(MAX)");
            builder.Property(u => u.Email).HasMaxLength(100);

            builder.Property(c => c.Email).HasColumnType("NVARCHAR(MAX)");
            builder.Property(u => u.Email).HasMaxLength(50);

            builder.Property(c => c.Email).HasColumnType("NVARCHAR(MAX)");

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();           
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Contact");
        }
    }
}
