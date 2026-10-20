using Microsoft.AspNetCore.Mvc;
using ComprendreLesDependances.Api.Repositories;
using ComprendreLesDependances.Api.Services;

namespace ComprendreLesDependances.Api.Controllers;

[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController()
    {
        _userService = new UserService();
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAllAsync();
        return Ok(users);
    }
}
