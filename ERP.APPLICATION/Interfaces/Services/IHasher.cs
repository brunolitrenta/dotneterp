namespace ERP.APPLICATION.Interfaces.Services;

public interface IHasher
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hashedPassword);
}