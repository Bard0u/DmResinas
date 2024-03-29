using System.Security.Claims;
using DmResinas.Data;
using DmResinas.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DmResinas.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _contexto;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UsuarioService(AppDbContext contexto, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _contexto = contexto;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<UsuarioDto> GetUsuarioLogado()
    {
        var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userAccount = await _userManager.FindByIdAsync(userId);
        var usuario = await _contexto.Usuarios.Where(u => u.UsuarioId == userId).SingleOrDefaultAsync();
        var perfis = string.Join(", ", await _userManager.GetRolesAsync(userAccount));
        UsuarioDto UsuarioDto = new() {
            UsuarioId = userId,
            Nome = usuario.Nome,
            DataNascimento = usuario.DataNascimento,
            Foto = usuario.Foto,
            Email = userAccount.Email,
            UserName = userAccount.UserName,
            Perfil = perfis
        };
        return UsuarioDto;
    }
}