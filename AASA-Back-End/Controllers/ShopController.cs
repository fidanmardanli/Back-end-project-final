using AASA_Back_End.Data;
using AASA_Back_End.Models;
using AASA_Back_End.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AASA_Back_End.Controllers
{
    public class ShopController : Controller
    {
        //private readonly AppDbContext _context;
        //public ShopController(AppDbContext context)
        //{
        //    _context = context;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    IEnumerable<Type> types = await _context.Types.Where(m => m.IsDeleted == false).ToListAsync();

        //    ShopVM model = new ShopVM
        //    {
        //        Types = types,
        //    };

        //    return View(types);
        //}
    }
}
