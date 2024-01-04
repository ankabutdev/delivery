﻿using UserService.Domain.Entities.Clients;
using UserService.Domain.Entities.Companies;
using UserService.Domain.Enums;

namespace UserService.Domain.Entities.Users;

public class User : BaseEntity
{
    public string FullName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string ImagePath { get; set; }

    public UserRole UserRole { get; set; }

    public Guid CompanyId { get; set; }

    public Company Company { get; set; }

    public Guid ClientId { get; set; }

    public Client Client { get; set; }

}
