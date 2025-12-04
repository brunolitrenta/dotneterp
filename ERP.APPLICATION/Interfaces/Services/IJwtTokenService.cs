using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.Interfaces.Services;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}