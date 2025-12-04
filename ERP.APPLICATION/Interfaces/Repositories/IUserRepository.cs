using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION;

public interface IUserRepository
{
    Task<User> CreateUser(User user);
    Task<User> GetUser(string email);
}