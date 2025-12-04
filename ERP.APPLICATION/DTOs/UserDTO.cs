using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.DTOs;

public class CreateUserDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


    public User ToEntity()
    {
        return new User()
        {
            Name = this.Name,
            Email = this.Email,
            Password = this.Password,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }
}