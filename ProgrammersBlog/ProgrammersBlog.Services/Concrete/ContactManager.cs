using AutoMapper;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Utilities;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using ProgrammersBlog.Shared.IUtilites.Results.Concrede;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class ContactManager:IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<ContactDto>> AddAsync(ContactAddDto contactAddDto, string createdByName)
        {
            var contactInfo = _mapper.Map<Contact>(contactAddDto);
            contactInfo.CreatedByName = createdByName;
            contactInfo.ModifiedByName = createdByName;

            var addedContactInfo = await _unitOfWork.Contact.AddAsync(contactInfo);
            await _unitOfWork.SaveAsync();

            return new DataResult<ContactDto>(ResultStatus.Success, Messages.Contact.Add(createdByName), new ContactDto
            {
                 Contact =addedContactInfo,
                 Message= Messages.Contact.Add(createdByName),
                 ResultStatus=ResultStatus.Success
            });
        }

        public async Task<IDataResult<ContactDto>> GetAsync(int contactId)
        {
            var contactInfo = await _unitOfWork.Contact.GetAsync(c => c.Id == contactId);
            if (contactInfo != null)
            {
                return new DataResult<ContactDto>(ResultStatus.Success, new ContactDto
                {

                    ResultStatus = ResultStatus.Success,
                    Contact = contactInfo
                });
            }

            return new DataResult<ContactDto>(ResultStatus.Error, new ContactDto
            {
                ResultStatus = ResultStatus.Success,
                Contact = null,
                Message = "Bir hata oluştu"
            });
        }

        public async  Task<IDataResult<ContactDto>> UpdateAsync(ContactUpdateDto contactUpdateDto, string modifiedByName)
        {           
            var oldContactInfo = await _unitOfWork.Contact.GetAsync(c => c.Id == contactUpdateDto.Id);
            var contactInfo = _mapper.Map<ContactUpdateDto, Contact>(contactUpdateDto, oldContactInfo);
            contactInfo.ModifiedByName = modifiedByName;
            var updatedContactInfo = await _unitOfWork.Contact.UpdateAsync(contactInfo);
            await _unitOfWork.SaveAsync();
            return new DataResult<ContactDto>(ResultStatus.Success, Messages.Contact.Update(modifiedByName), new ContactDto
            {
                Contact = updatedContactInfo,
                ResultStatus = ResultStatus.Success,
                Message = Messages.Contact.Update(modifiedByName)
            });
        }
    }
}
