using UserService.Domain.Entities.Users;

namespace UserService.Infrastructure.Interfaces.Users;

public interface IUserRepository : IRepository<User, User>
{
}
