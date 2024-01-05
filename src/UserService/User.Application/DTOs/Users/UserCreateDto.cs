using Microsoft.AspNetCore.Http;
using UserService.Domain.Enums;


namespace UserService.Application.DTOs.Users;

public class UserCreateDto
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public IFormFile ImagePath { get; set; } = default!;

    public UserRole UserRole { get; set; }

    public Guid CompanyId { get; set; }

    public Guid ClientId { get; set; }

}
