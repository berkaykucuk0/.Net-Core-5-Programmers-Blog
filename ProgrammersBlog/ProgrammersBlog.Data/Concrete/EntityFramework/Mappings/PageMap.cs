
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
    public class PageMap : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);         
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreateDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);

            builder.HasData(new Page
            {
              Id=1,
              Title = "Deneme Sayfası",
              Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
              CreateDate=DateTime.Now,
              CreatedByName= "Berkay Küçük",
              IsActive=true,
              IsDeleted=false,
              ModifiedByName= "Berkay Küçük",
              ModifiedDate= DateTime.Now,
              Note="ilk sayfa",
              SeoAuthor="page",
              SeoDescription="page",
              SeoTags="page",
              Thumbnail= "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 2,
                Title = "Deneme Sayfası 2",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 3,
                Title = "Deneme Sayfası 3",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 4,
                Title = "Deneme Sayfası 4",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 5,
                Title = "Deneme Sayfası 5",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 6,
                Title = "Deneme Sayfası 6",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 7,
                Title = "Deneme Sayfası 7",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 8,
                Title = "Deneme Sayfası 8",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 9,
                Title = "Deneme Sayfası 9",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            },
            new Page
            {
                Id = 10,
                Title = "Deneme Sayfası 10",
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum,  comes from a line in section 1.10.32.",
                CreateDate = DateTime.Now,
                CreatedByName = "Berkay Küçük",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "Berkay Küçük",
                ModifiedDate = DateTime.Now,
                Note = "ilk sayfa",
                SeoAuthor = "page",
                SeoDescription = "page",
                SeoTags = "page",
                Thumbnail = "pageImages/defaultPage.png"
            }

                );
        }
    }
}
