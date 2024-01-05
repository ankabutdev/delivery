using Microsoft.EntityFrameworkCore;
using UserService.Domain.Entities.Clients;
using UserService.Domain.Entities.Companies;
using UserService.Domain.Entities.Schedules;
using UserService.Domain.Entities.Staffs;
using UserService.Domain.Entities.Users;

namespace UserService.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

}
