using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Kimden
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "hardaalyunusemre@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //Kime
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //İçerik
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            //Başlık
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("hardaalyunusemre@gmail.com", "tzusqowenomcxhfe");
            client.Send(mimeMessage);
            client.Disconnect(true);

            //Gönderilen Mailin Veri Tabanına Kaydedilmesi.


            return View();
        }
    }
}
