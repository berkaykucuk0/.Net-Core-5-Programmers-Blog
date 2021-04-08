﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class PageUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olamaz")]
        public string Title { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden küçük olamaz")]
        public string Content { get; set; }

        public string Thumbnail { get; set; }

        [DisplayName("Resim")]
        [Required(ErrorMessage = "{0}  alanı boş geçilemez!")]
        [DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }

        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olamaz")]
        public string SeoAuthor { get; set; }

        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olamaz")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Etiketler")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olamaz")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden küçük olamaz")]
        public string SeoTags { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [DisplayName("Aktif mi?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        [DisplayName("Silindi mi?")]
        public bool IsDeleted { get; set; }
    }
}
