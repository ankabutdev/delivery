namespace UserService.Infrastructure.Interfaces;

public interface IRepository<TModel, TViewModel>
{
    public ValueTask<IEnumerable<TViewModel>> GetAllUserAsync();

    public ValueTask<IEnumerable<TViewModel>> GetByIdAsync(Guid id);

    public ValueTask<int> CountAsync();

    public ValueTask<int> CreateAsync(TModel entity);

    public ValueTask<int> UpdateAsync(TModel entity);

    public ValueTask<int> DeleteAsync(Guid id);
}
