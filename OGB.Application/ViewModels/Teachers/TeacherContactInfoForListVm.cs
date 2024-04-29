using AutoMapper;
using Domain.Model;
using OGB.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Teachers
{
    public class TeacherContactInfoForListVm : IMapFrom<Teacher>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int TeacherRef { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Teacher, TeacherContactInfoForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(s => s.TeacherContactInfo.PhoneNumber))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => s.TeacherContactInfo.Email))
                .ForMember(d => d.TeacherRef, opt => opt.MapFrom(s => s.TeacherContactInfo.TeacherRef));
        }
    }
}
