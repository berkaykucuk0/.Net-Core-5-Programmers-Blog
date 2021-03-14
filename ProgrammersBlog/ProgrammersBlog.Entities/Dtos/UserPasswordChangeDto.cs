using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserPasswordChangeDto
    {
        [DisplayName("Şuanki Şifre")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(5, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("Yeni Şifre")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(5, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }


        [Compare("NewPassword" , ErrorMessage ="Yeni şifre ile tekrarı birbiriyle aynı olmalıdır!")]
        [DisplayName("Yeni Şifre Tekrarı")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(5, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
    }
}
