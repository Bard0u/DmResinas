using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DmResinas.Models;
using DmResinas.DTO;

namespace DmResinas.Controllers;

[Authorize(Roles = "Administrador")]
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    private readonly SignInManager<Clients> _signInManager;

    private readonly UserManager<Clients> _userManager;

    public AccountController(ILogger<AccountController> logger,
    SignInManager<Clients> signInManager,
    UserManager<Clients> userManager)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
 

  [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string returnUrl)
    {
        LoginDto loginDto = new();
        loginDto.ReturnUrl = returnUrl ?? Url.Content("~/");
        return View(loginDto);
    }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult Login(LoginDto login)
    {
       if (ModelState.IsValid)
        {
            return LocalRedirect(login.ReturnUrl);
        }
        return View(login);

        
    }

}