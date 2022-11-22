using AutoMapper;
using RegisterApp.Models;
using RegisterApp.ModelsDTOs;

namespace RegisterApp.Utils
{
    public class AutoMapperProfiles: Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }


    }
}
