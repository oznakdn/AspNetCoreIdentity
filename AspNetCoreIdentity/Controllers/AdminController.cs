using AspNetCoreIdentity.Models.Identity;
using AspNetCoreIdentity.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIdentity.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        public IActionResult Index()
        {
           var users = _userManager.Users.ToList();
            return View(users);
        }

    }
}
