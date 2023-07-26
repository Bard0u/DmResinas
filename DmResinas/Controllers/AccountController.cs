using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using DmResinas.DTO;
using DmResinas.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

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
        _signInManager = signInManager;
        _userManager = userManager;
    
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
    public async Task<IActionResult> Login(LoginDto login)
    {
        if (ModelState.IsValid)
        {
            string userName = login.Email;
            if (IsValidEmail(login.Email))
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                    userName = user.UserName;
            }

            var result = await _signInManager.PasswordSignInAsync(
                userName, login.Password, login.RememberMe, true
            );
            if (result.Succeeded)
            {
                _logger.LogInformation($"Usuario {login.Email} acessou o sistema");
                return LocalRedirect(login.ReturnUrl);
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning($"Usuario {login.Email} está bloqueado");
                return RedirectToAction("Lockout");
            }
            ModelState.AddModelError("login", "Usuário e/ou Senha Inválidos!!!");

        }
        return View(login);
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        _logger.LogInformation($"Usuario {ClaimTypes.Email} saiu da conta");
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");

    }
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register()
    {

        return View();
    }
    


    private bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

}