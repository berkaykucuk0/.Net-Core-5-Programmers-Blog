using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Models
{
    public class ContactViewModel
    {
        public EmailSendDto EmailSendDto  { get; set; }
        public ContactDto ContactDto { get; set; }
    }
}
