using AutoMapper;
using Domain.Model;
using OGB.Application.Mapping;
using OGB.Application.ViewModels.Class1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Teachers
{
    public class TeacherForListVm : IMapFrom<Teacher>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Category { get; set; }
        public string YearsOfTeaching { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Teacher, TeacherForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
                .ForMember(d => d.YearsOfTeaching, opt => opt.MapFrom(s => s.YearsOfTeaching));
        }
    }
}
