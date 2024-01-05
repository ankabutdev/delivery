using UserService.Domain.Enums;

namespace UserService.Domain.Entities.Users;

public class User : BaseEntity
{
    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string ImagePath { get; set; }

    public UserRole UserRole { get; set; }

}
