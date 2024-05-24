using Microsoft.AspNetCore.Mvc;

namespace car.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
