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
    public class TeacherAddressForListVm : IMapFrom<Teacher>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string ZipCode { get; set; }
        public int TeacherRef { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Teacher, TeacherAddressForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.City, opt => opt.MapFrom(s => s.TeacherAddress.City))
                .ForMember(d => d.Street, opt => opt.MapFrom(s => s.TeacherAddress.Street))
                .ForMember(d => d.HomeNumber, opt => opt.MapFrom(s => s.TeacherAddress.HomeNumber))
                .ForMember(d => d.ZipCode, opt => opt.MapFrom(s => s.TeacherAddress.ZipCode))
                .ForMember(d => d.TeacherRef, opt => opt.MapFrom(s => s.TeacherAddress.TeacherRef));
        }
    }
}
