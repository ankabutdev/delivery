using UserService.Application.DTOs.Users;
using UserService.Application.Interfaces.Users;
using UserService.Domain.Entities.Users;
using UserService.Domain.Enums;
using UserService.Infrastructure.Interfaces.Users;

namespace UserService.Application.Services.Users;

public class UserServices : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserServices(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async ValueTask<int> CountAsync()
        => await _userRepository.CountAsync();

    public async ValueTask<bool> CreateAsync(UserCreateDto dto)
    {
        if (dto == null)
            return false;

        var user = new User()
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Password = dto.Password,
            UserRole = UserRole.User,
            ImagePath = dto.ImagePath.ToString()
        };

        var result = await _userRepository.CreateAsync(user);
        return result > 0;
    }

    public ValueTask<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<IEnumerable<User>> GetAllUserAsync()
        => await _userRepository.GetAllUserAsync();

    public ValueTask<IEnumerable<User>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(Guid id, UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
