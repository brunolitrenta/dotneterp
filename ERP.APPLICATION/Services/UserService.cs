using ERP.APPLICATION.DTOs;
using ERP.DOMAIN.Entities;

namespace ERP.APPLICATION.Services;

public interface IUserService
{
    Task<User> CreateUser(CreateUserDTO user);
    Task<User> GetUser(string email);
}

public class UserService(IUserRepository _repository)
{
    public async Task<User> CreateUser(CreateUserDTO user)
    {
        return await _repository.CreateUser(user.ToEntity());
    }

    public async Task<User> GetUser(string email)
    {
        return await _repository.GetUser(email);
    }
}