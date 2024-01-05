using UserService.Domain.Entities.Clients;

namespace UserService.Infrastructure.Interfaces.Clients;

public interface IClientRepository : IRepository<Client, Client>
{
}
