using DmResinas.DTO;

namespace DmResinas.Services;

public interface IHomeService
{
    Task<HomeDto> GetIndexData();
}