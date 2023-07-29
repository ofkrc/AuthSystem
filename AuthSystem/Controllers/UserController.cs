using AuthSystem.Areas.Identity.Data;
using AuthSystem.Controllers;
using AuthSystem.Data;
using AuthSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AuthDbContext _context;

    public UserController(ILogger<UserController> logger, UserManager<ApplicationUser> userManager, AuthDbContext dbContext)
    {
        _logger = logger;
        this._userManager = userManager;
        _context = dbContext;
    }

    public IActionResult Index()
    {
        var id = _userManager.GetUserId(this.User);
        ViewData["FirstName"] = _userManager.GetUserName(this.User);

        var user = _context.Users.SingleOrDefault(u => u.Id == id); // Veriyi doğrudan ApplicationDbContext ile alın

        return View(user);
    }
}
