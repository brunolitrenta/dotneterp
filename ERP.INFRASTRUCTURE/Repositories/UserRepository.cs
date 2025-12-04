using ERP.APPLICATION;
using ERP.DOMAIN.Entities;
using ERP.INFRASTRUCTURE.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ERP.INFRASTRUCTURE.Repositories;

public class UserRepository(ErpDBContext _context) : IUserRepository
{
    public async Task<User> CreateUser(User user)
    {
        var result = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<User> GetUser(string email)
    {
        return await _context.Users.Where(u => u.Email == email).FirstOrDefaultAsync() ?? throw new Exception("User not found");
    }
}