using AspNetCoreIdentity.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIdentity.Controllers
{
    public class AdminController : BaseController
    {

        
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(userManager, signInManager) { }
        
       


        public IActionResult Index()
        {
           var users = _userManager.Users.ToList();
            return View(users);
        }

    }
}
