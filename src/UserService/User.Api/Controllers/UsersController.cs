using Microsoft.AspNetCore.Mvc;
using UserService.Application.DTOs.Users;
using UserService.Application.Interfaces.Users;

namespace UserService.Api.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync()
    {
        var result = await _service.GetAllUserAsync();
        return Ok(result);
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(UserCreateDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return Ok(result);
    }
}
