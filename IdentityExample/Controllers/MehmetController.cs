using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.Controllers
{
    public class MehmetController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public MehmetController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Olustur()
        {
            return View();
        }
    }
}
