using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ContactUpdateDto
    {
        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Site E-Posta Adresi")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Site Telefon Numarası")]
        [MaxLength(13, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")] // +905555555555 // 13 characters
        [MinLength(13, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır.")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [DisplayName("Adres")]
        public string MapIframe { get; set; }

        [Required]
        public int Id { get; set; }

    }
}
