using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using AngularBlogCore.API.Models;

namespace AngularBlogCore.API.Controllers
{
    //actionun ismine göre cağırıyoruz farklı bir yöntem /SendContactEmail

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelperController : ControllerBase
    {
    [HttpPost]
          public IActionResult SendContactEmail([FromBody] Contact contact )
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mailMessage.From = new MailAddress("tuna.aksit35@gmail.com");
                mailMessage.To.Add("kskli.tna@hotmail.com");
                mailMessage.Subject = contact.Subject;
                mailMessage.Body = contact.Message;
                mailMessage.IsBodyHtml = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("tuna.aksit35@gmail.com", "Aytekim147852");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }










        }

    }
}