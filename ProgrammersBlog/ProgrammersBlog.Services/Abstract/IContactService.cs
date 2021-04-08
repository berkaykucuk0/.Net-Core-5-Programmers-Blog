using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IContactService
    {
       
        Task<IDataResult<ContactDto>> GetAsync(int contactId);
        Task<IDataResult<ContactDto>> AddAsync(ContactAddDto contactAddDto, string createdByName);
        Task<IDataResult<ContactDto>> UpdateAsync(ContactUpdateDto contactUpdateDto, string modifiedByName);
    }
}
