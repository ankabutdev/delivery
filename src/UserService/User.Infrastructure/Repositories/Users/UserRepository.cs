using Microsoft.EntityFrameworkCore;
using UserService.Domain.Entities.Users;
using UserService.Infrastructure.Data;
using UserService.Infrastructure.Interfaces.Users;

namespace UserService.Infrastructure.Repositories.Users;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CountAsync()
        => await _dbContext.Users.CountAsync();

    public async ValueTask<int> CreateAsync(User entity)
    {
        if (entity == null)
            return 0;

        await _dbContext.AddAsync(entity);

        var result = await _dbContext.SaveChangesAsync();

        return result;
    }

    public ValueTask<int> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<IEnumerable<User>> GetAllUserAsync()
        => await _dbContext.Users.ToListAsync();

    public ValueTask<IEnumerable<User>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
