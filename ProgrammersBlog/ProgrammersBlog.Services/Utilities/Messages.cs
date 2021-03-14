using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural) //plural tekil mi çoğul mu kategori 
            {
                if (isPlural)
                {
                    return "Hiçbir kategori bulunamadı";
                }
                else
                {
                    return "Böyle bir kategori bulunamadı";
                }
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla  silinmiştir.";
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }

            public static string NonDeleted()
            {
                return "Bir hata oluştu! Kategori silinememiştir";
            }
        }

        public static class Article
        {
            public static string NotFound(bool isPlural) //plural tekil mi çoğul mu kategori 
            {
                if (isPlural)
                {
                    return "Hiçbir makale bulunamadı";
                }
                else
                {
                    return "Böyle bir makale bulunamadı";
                }
            }

            public static string Add(string articleName)
            {
                return $"{articleName} adlı makale başarıyla eklenmiştir.";
            }

            public static string Update(string articleName)
            {
                return $"{articleName} adlı makale başarıyla güncellenmiştir.";
            }
            public static string Delete(string articleName)
            {
                return $"{articleName} adlı makale başarıyla  silinmiştir.";
            }

            public static string HardDelete(string articleName)
            {
                return $"{articleName} adlı makale başarıyla veritabanından silinmiştir.";
            }

            public static string NonDeleted()
            {
                return "Bir hata oluştu! Makale silinememiştir";
            }
            public static string IncreaseViewCount()
            {
                return "Makalenin okunma sayısı başarıyla bir arttırılmıştır";
            }
        }

        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yorum bulunamadı.";
                return "Böyle bir yorum bulunamadı.";
            }

            public static string Add(string createdByName)
            {
                return $"Sayın {createdByName}, yorumunuz başarıyla eklenmiştir.";
            }

            public static string Update(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla güncellenmiştir.";
            }
            public static string Delete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla silinmiştir.";
            }
            public static string HardDelete(string createdByName)
            {
                return $"{createdByName} tarafından eklenen yorum başarıyla veritabanından silinmiştir.";
            }

            public static string Approve(string createdByName)
            {
                return $"{createdByName} tarafından yorum başarıyla onaylanmıştır.";
            }
        }
    }
}
