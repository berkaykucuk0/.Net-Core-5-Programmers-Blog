using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class EmailSendDto
    {
        [DisplayName("Ad Soyad")]
        [Required(ErrorMessage ="{0} girmek zorunludur.")]
        [MaxLength(100,ErrorMessage ="{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(1, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        public string Name  { get; set; }

        [DisplayName("E-posta")]
        [Required(ErrorMessage = "{0} girmek zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email  { get; set; }


        [DisplayName("Konu")]
        [Required(ErrorMessage = "{0} girmek zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(1, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        public string Subject { get; set; }


        [DisplayName("Mesajınız")]
        [Required(ErrorMessage = "{0} girmek zorunludur.")]
        [MaxLength(1500, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(2, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        public string Message { get; set; }
    }
}
