using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularBlogCore.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularBlogCore.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //[Route("api/[controller]")] metotun ismine göre eşleşme var api/Auth 'a post isteği gelirse çalışacak
        //[Route("api/[controller]/[action]")] methot ismine göre eşleşir /api/IsAuthenticated
        [HttpPost]
        public IActionResult IsAuthenticated(AdminUser adminUser)
        {
            bool status = false;
            if(adminUser.Email == "tuna@tuna.com" && adminUser.Password == "Tuna")
            {
                status = true;
            }
            //class ile resulta gönderiyoruz, direk değişkeni gönderirsem Json nesnesine döndürmüyor.
            var result = new
            {
                status = status
            };
            return Ok(result);
        }



    }
}