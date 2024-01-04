using UserService.Domain.Entities.Companies;

namespace UserService.Domain.Entities.Schedules;

public class Schedule : BaseEntity
{
    public string Day { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public Guid CompanyId { get; set; }

}
