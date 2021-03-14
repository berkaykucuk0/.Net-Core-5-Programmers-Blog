using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface ICategoryService
    {
        /// <summary>
        /// Alınan id değerine bağlı olarak istenen kategoriyi getirir.
        /// </summary>
        /// <param name="categoryId">Veritabanından çağırılacak olan kategorinin id değeri</param>
        /// <returns>DataResult tipinde CategoryDto geri döner.</returns>
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);

        /// <summary>
        /// Verilen id değerine  ait kategorinin CategoryUpdateDto  temsilini geriye döner.
        /// </summary>
        /// <param name="categoryId"> 0 dan büyük integer bir id değeri</param>
        /// <returns>Asenkron bir operasyon ile Task olarak işlem sonucunu Dataresult tipinde döner</returns>
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);

        /// <summary>
        /// Veritabanında bulunan tüm kategorileri çağırma işlemi
        /// </summary>
        /// <returns>DataResult tipinde CategoryListDto geri döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllAsync();

        /// <summary>
        /// Veritabanında bulunan IsDeleted=False olan kategorileri çağırma işlemi
        /// </summary>
        /// <returns>DataResult tipinde CategoryListDto geri döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAsync();

        /// <summary>
        /// Veritabanında bulunan IsDeleted=False ve IsActive=True olan kategorileri çağırma işlemi
        /// </summary>
        /// <returns>DataResult tipinde CategoryListDto geri döner.</returns>
        Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAndActiveAsync();

        /// <summary>
        /// Alınan categoryAddDto ve createdByName parametrelerine bağlı olarak kategori ekleme işlemi yapar.
        /// </summary>
        /// <param name="categoryAddDto">categoryAddDto adında gerekli parametreleri alır</param>
        /// <param name="createdByName">Ekleyen kullanıcının(admin,editör) ismini alır</param>
        /// <returns>Dataresult tipinde CategoryDto döner</returns>
        Task<IDataResult<CategoryDto>> AddAsync(CategoryAddDto categoryAddDto,string createdByName);

        /// <summary>
        /// Verilen CategoryUpdateDto'ya bağlı olarak ilgili kategorinin güncellenmesini sağlar.
        /// </summary>
        /// <param name="categoryUpdateDto">Güncellenecek olan kategorinin verilerini içeren Dto</param>
        /// <param name="modifiedByName">Güncellemeyi yapan kullanıcının adı</param>
        /// <returns>DataResult tipinde CategoryDto geri döner.</returns>
        Task<IDataResult<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto ,string modifiedByName);
        /// <summary>
        /// Kategorileri veritabanında silinme kolonunu True yapar ve deaktif eder.
        /// </summary>
        /// <param name="categoryId">Silinecek kategorinin Id sini alır</param>
        /// <param name="modifiedByName">Değişiklik yapan kullanıcının(Admin,Editör) adını alır</param>
        /// <returns>DataResult tipinde bir CategoryDto geri döner.</returns>
        Task<IDataResult<CategoryDto>> DeleteAsync(int categoryId, string modifiedByName);

        /// <summary>
        /// Verilen Id değerine ait kategoriyi veritabanından siler.
        /// </summary>
        /// <param name="categoryId">Veritabanından silinecek olan kategorinin Id değeri</param>
        /// <returns>Result tipinde değer geri döner</returns>
        Task<IResult> HardDeleteAsync(int categoryId);

        /// <summary>
        /// Veritabanı çerisinde bulunan silinmiş veya silinmemiş kategorilerin sayısını bulma işlemini gerçekleştirir.Parametre almaz.
        /// </summary>
        /// <returns>Dataresult integer  tipinde sayı sonucu üretir </returns>
        Task<IDataResult<int>> CountAsync();

        /// <summary>
        /// Silinmemiş olan kategorilerin sayısını bulma işlemini gerçekleştirir.Paratmetre almaz.
        /// </summary>
        /// <returns>Dataresult integer  tipinde sayı sonucu üretir </returns>
        Task<IDataResult<int>> CountByNonDeletedAsync();
    }
}
