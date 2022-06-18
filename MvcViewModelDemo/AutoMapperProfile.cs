using AutoMapper;
using MvcViewModelDemo.Data.Models;
using MvcViewModelDemo.Models.ViewModel;

namespace MvcViewModelDemo;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Department, DepartmentViewModel>().ReverseMap();
    }
}