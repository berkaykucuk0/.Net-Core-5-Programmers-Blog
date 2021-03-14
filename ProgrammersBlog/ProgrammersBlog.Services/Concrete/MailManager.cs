using Microsoft.Extensions.Options;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.Abstract;
using ProgrammersBlog.Shared.IUtilites.Results.ComplexTypes;
using ProgrammersBlog.Shared.IUtilites.Results.Concrede;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;

        public MailManager(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        //Şifremi unuttum falan diyo kullanıcı biz kullanıcıya mail atıyoruz
        public IResult Send(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail),
                To = { new MailAddress(emailSendDto.Email) },
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                //GÖNDERİLECEK MAİLİN ŞEKLİ İŞTE YUKARDA LOGO FALAN FİLAN BURADAN YAPILIYOR
                Body = $"{emailSendDto.Message}"

            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-postanız başarıyla gönderilmiştir.");
        }

        //Kullanıcı bize mail gönderiyo iletişimden o zaman bunu
        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail),
                To = { new MailAddress("kucuk_beko_19@hotmail.com") },
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                //GÖNDERİLECEK MAİLİN ŞEKLİ İŞTE YUKARDA LOGO FALAN FİLAN BURADAN YAPILIYOR
                Body = $"Gönderen kişi {emailSendDto.Name} , Gönderen E-posta Adresi: {emailSendDto.Email} <br> {emailSendDto.Message}"

            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);
            return new Result(ResultStatus.Success, $"E-postanız başarıyla gönderilmiştir.");
        }
    }
}
