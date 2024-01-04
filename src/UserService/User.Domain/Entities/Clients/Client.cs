﻿using UserService.Domain.Entities.Companies;
using UserService.Domain.Entities.Users;

namespace UserService.Domain.Entities.Clients;

public class Client : BaseEntity
{
    public Guid UserId { get; set; }

    public string FullName { get; set; }

    //public Status Status { get; set; }

    public string PhoneNumber { get; set; }

    public Guid CompanyId { get; set; }

    public Company Company { get; set; }

    public ICollection<User> Users { get; set; }

}
