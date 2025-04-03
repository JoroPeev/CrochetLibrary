using CrochetLibrary.Models.Auth;
using CrochetLibrary.Services.Auth;
using Microsoft.AspNetCore.Mvc;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterModel model)
    {
        var result = await _authService.RegisterAsync(model);

        if (result.Succeeded)
        {
            return Ok(new { message = "User registered successfully" });
        }
        return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        bool success = await _authService.LoginAsync(model);
        if (success)
        {
            return Ok(new { message = "Login successful" });
        }
        return Unauthorized();
    }

    [HttpPost("add-admin")]
    public async Task<IActionResult> AddAdmin([FromBody] string email)
    {
        bool success = await _authService.AddAdminRoleAsync(email);
        if (!success)
        {
            return NotFound(new { message = "User not found or role creation failed" });
        }
        return Ok(new { message = "Admin role assigned successfully" });
    }
}
