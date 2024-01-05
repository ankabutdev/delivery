using UserService.Domain.Entities.Companies;

namespace UserService.Infrastructure.Interfaces.Companies;

internal interface ICompanyRepository : IRepository<Company, Company>
{
}
