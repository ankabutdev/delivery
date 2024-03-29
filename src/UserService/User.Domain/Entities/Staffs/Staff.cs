﻿using UserService.Domain.Entities.Companies;
using UserService.Domain.Enums;

namespace UserService.Domain.Entities.Staffs;

public class Staff : BaseEntity
{
    public Guid CompanyId { get; set; }

    public Company Company { get; set; }

    public string FullName { get; set; }

    public string PhoneNumber { get; set; }

    public StaffType StaffType { get; set; }
}
