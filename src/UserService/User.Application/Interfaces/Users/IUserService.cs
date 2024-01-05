using UserService.Application.DTOs.Users;
using UserService.Domain.Entities.Users;

namespace UserService.Application.Interfaces.Users;

public interface IUserService
{
    public ValueTask<IEnumerable<User>> GetAllUserAsync();

    public ValueTask<IEnumerable<User>> GetByIdAsync(Guid id);

    public ValueTask<int> CountAsync();

    public ValueTask<bool> CreateAsync(UserCreateDto dto);

    public ValueTask<bool> UpdateAsync(Guid id, UserUpdateDto dto);

    public ValueTask<bool> DeleteAsync(Guid id);
}
