using System;
using Microsoft.AspNetCore.Mvc;
using BAL.Services.IServices;
using MODEL;
using MODEL.DTOs;
namespace API.Controllers
{
	[ApiController]
    [Route("[controller]/api")]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;
		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("Login")]
		public async Task<ActionResult<ServiceReponse<string>>> Login(LoginDTO request)
		{
			ServiceReponse<string> response = await _authService.Login(request);
			if (response.Data == null)
			{
				return BadRequest(response);
			}
			return Ok(response);
		}
	}
}

