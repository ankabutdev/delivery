using UserService.Domain.Entities.Staffs;
using UserService.Domain.Entities.Users;

namespace UserService.Domain.Entities.Companies;

public class Company : BaseEntity
{
    public Guid UserId { get; set; }

    public Guid? MainId { get; set; }

    public string Name { get; set; }

    public string? Owner { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string SiteUrl { get; set; }

    public string Region { get; set; }

    public string EmployeesMax { get; set; }

    public string EmployeesMin { get; set; }

    public double InComeEnter { get; set; }

    public double InComeLeave { get; set; }

    public string LatItude { get; set; }

    public string LongItude { get; set; }

    public ICollection<User> Users { get; set; }

    public ICollection<Staff> Staffs { get; set; }
}
