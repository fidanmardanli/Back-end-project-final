using Microsoft.AspNetCore.Mvc;
using AASA_Back_End.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AASA_Back_End.Models;
using AASA_Back_End.ViewModel;
using Microsoft.AspNetCore.Http;

namespace AASA_Back_End.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            //HttpContext.Session.SetString("name", "Fidan");

            //Response.Cookies.Append("surname", "Mardanli");

            Slider slider = _context.Sliders.FirstOrDefault();

          Slider2 slider2 = _context.Sliders2.FirstOrDefault();


            //HomeVM model = new HomeVM
            //{
            //    Sliders = slider,

            //    Categories = category
              
            //};
          

            return View(slider2);
        }

        //public IActionResult Test()
        //{
        //    var sessionData = HttpContext.Session.GetString("name");

        //    var cookieData = Request.Cookies["surname"];

        //    return Json(sessionData + "-" + cookieData);
        //}
        
    }
}
