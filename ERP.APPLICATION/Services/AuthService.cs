using ERP.APPLICATION.DTOs.Auth;
using ERP.APPLICATION.Interfaces.Services;

namespace ERP.APPLICATION.Services;

public interface IAuthService
{
    Task<TokenDTO> Login(LoginDTO login);
}

public class AuthService(IUserRepository userRepository, IHasher hasher, IJwtTokenService jwtTokenService)
{
    public async Task<TokenDTO> Login(LoginDTO login)
    {
        var user = await userRepository.GetUser(login.Email);

        if (!hasher.VerifyPassword(login.Password, user.Password))
            throw new Exception("Invalid login");

        var token = jwtTokenService.GenerateToken(user);

        return new TokenDTO
        {
            Token = token,
            ExpiresAt = DateTime.UtcNow.AddHours(3),
            Email = user.Email,
        };
    }
}