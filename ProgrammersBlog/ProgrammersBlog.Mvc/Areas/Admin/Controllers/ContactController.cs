using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Utilities;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;

        public ContactController(IContactService contactService, IMapper mapper, IToastNotification toastNotification)
        {
            _contactService = contactService;
            _mapper = mapper;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
           var contactResult = await _contactService.GetAsync(contactId:1);          
           return View(contactResult.Data);      
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactDto contactDto)
        {
            var contact = contactDto.Contact;
            var contactUpdateDto = _mapper.Map<ContactUpdateDto>(contact);
            if (ModelState.IsValid)
            {
              
                var contactResult = await _contactService.UpdateAsync(contactUpdateDto, "Berkay Küçük");
                if (contactResult.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(Messages.Contact.Update("Berkay Küçük"),new ToastrOptions {
                        
                        Title="Başarılı İşlem"
                    });
                    return View(contactResult.Data);
                }               
                   ModelState.AddModelError("", contactResult.Message);
                             
            }          
                return View(contactUpdateDto);
        }

    }
}
