using AuthSystem.Areas.Identity.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Security.Claims;

namespace AuthSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            ViewData["FirstName"] = _userManager.GetUserName(this.User);
            return View();
        }
        //public IActionResult Index()
        //{
        //    string Id = _userManager.GetUserId(this.User);
        //    var list = GetFirstName(Id);
        //    return View();
        //}

        //public UserModel GetFirstName(string id)
        //{

        //    UserModel userModel = new UserModel();
        //    var list = userModel.Users.Find(x => x.Id == id);

        //    userModel.UserName = list.UserName;
        //    userModel.FirstName = list.FirstName;
        //    userModel.Email = list.Email;
        //    userModel.LastName = list.LastName;
        //    userModel.PhoneNumber = list.PhoneNumber;

        //    return userModel;
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}