namespace ERP.APPLICATION.DTOs.Auth;

public class TokenDTO
{
    public string Token { get; set; } = string.Empty;
    public DateTime ExpiresAt { get; set; } = DateTime.UtcNow + TimeSpan.FromHours(3);
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}