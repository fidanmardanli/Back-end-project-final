using AASA_Back_End.Data;
using AASA_Back_End.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AASA_Back_End.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {

        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Employee> employees = await _context.Employeees.AsNoTracking().ToListAsync();
            //if (searchBy == "Position")
            //{
            //    return View(employees.Where(x => x.Position == search)
            //            .ToList().ToPagedList(page ?? 1, 3));
            //}
            //else
            //{
            //    return (IActionResult)View(employees.Where(x => x.FullName.StartsWith(search)))
            //        .ToString().ToPagedList(page ?? 1, 3)); 
            //}
            return View(employees);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetStatus(int id)
        {
            Employee employee = await _context.Employeees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee is null) return NotFound();

            if (employee.IsActive)
            {
                employee.IsActive = false;
            }
            else
            {
                employee.IsActive = true;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
