using car.DAL;
using car.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace car.Controllers
{
    public class HomeController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories.Select(car => new Category
            {
                Description = car.Description,
                Employee = car.Employee,
                Id = car.Id,
                Name = car.Name,
                Image = car.Image
            }).ToListAsync();

            return View(data);
        }
    }
}
