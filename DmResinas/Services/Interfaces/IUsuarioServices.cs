using DmResinas.DTO;

namespace DmResinas.Services;

public interface IUsuarioService
{
    Task<UsuarioDto> GetUsuarioLogado();
}