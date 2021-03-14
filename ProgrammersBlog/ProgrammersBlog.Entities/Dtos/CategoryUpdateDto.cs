using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }


        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(50, ErrorMessage = "{0} için en fazla 50 karakter girebilirsiniz")]
        [MinLength(3, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(500, ErrorMessage = "{0} için en fazla 500 karakter girebilirsiniz")]
        [MinLength(3, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        public string Description { get; set; }

        [DisplayName("Aktif mi?")]
        public bool IsActive { get; set; }

        [DisplayName("Silindi mi?")]
        public bool IsDeleted { get; set; }

        [DisplayName("Kategori Özel Not Alanı")]
        [Required(ErrorMessage = "{0} boş geçilemez!")]
        [MaxLength(500, ErrorMessage = "{0} için en fazla 500 karakter girebilirsiniz")]
        [MinLength(3, ErrorMessage = "{0} için en az 3 karakter girebilirsiniz")]
        public string Note { get; set; }
    }
}
