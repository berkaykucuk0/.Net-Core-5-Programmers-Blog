using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserLoginDto
    {
        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(10, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(5, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool  RememberMe { get; set; }
    }
}
