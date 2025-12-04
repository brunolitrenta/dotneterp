using ERP.APPLICATION.Interfaces.Services;
using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.DTOs;

public class CreateUserDTO(IHasher hasher)
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; }  = string.Empty;
    public string Password { get; set; } = string.Empty;


    public User ToEntity()
    {
        return new User()
        {
            Name = this.Name,
            Email = this.Email,
            Password = hasher.HashPassword(this.Password),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }
}