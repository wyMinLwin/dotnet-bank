using System;
using MODEL;
using MODEL.DTOs;

namespace BAL.Services.IServices
{
	public interface IAuthService
	{
		Task<ServiceReponse<string>> Login(LoginDTO request);
	}
}

