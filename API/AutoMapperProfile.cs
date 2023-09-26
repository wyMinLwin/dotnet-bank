using System;
using MODEL.Entities;
using MODEL.DTOs.Employee;
using AutoMapper;
namespace API
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<CreateEmployeeDTO, Employee>();
		}
	}
}

