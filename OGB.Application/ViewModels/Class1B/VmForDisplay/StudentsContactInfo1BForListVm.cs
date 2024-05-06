using AutoMapper;
using Domain.Model;
using OGB.Application.Mapping;
using OGB.Application.ViewModels.Class1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1B.VmForDisplay
{
    public class StudentsContactInfo1BForListVm : IMapFrom<_1BStudent>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1BStudent, StudentsContactInfo1BForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(s => s.ContactStudentInfo1B.PhoneNumber))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => s.ContactStudentInfo1B.Email));
        }
    }
}
