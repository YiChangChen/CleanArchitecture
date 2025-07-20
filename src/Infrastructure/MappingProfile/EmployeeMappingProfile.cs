using AutoMapper;
using Domain;
using Infrastructure.Entities;

namespace Infrastructure.MappingProfile
{
    public class EmployeeMappingProfile: Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeEntity>();
        }
    }
}