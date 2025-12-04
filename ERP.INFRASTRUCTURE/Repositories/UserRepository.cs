using ERP.APPLICATION;
using ERP.DOMAIN.Entities;
using ERP.INFRASTRUCTURE.Persistence;

namespace ERP.INFRASTRUCTURE.Repositories;

public class UserRepository(ErpDBContext _context) : IUserRepository
{
    public async Task<User> CreateUser(User user)
    {
        var result = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
}