using AutoMapper;
using Domain.Model;
using OGB.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1C.VmForDisplay
{
    public class German1CForListVm : IMapFrom<_1CStudent>
    {
        public int Id { get; set; }
        public double TestAvarage { get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1CStudent, German1CForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.TestAvarage, opt => opt.MapFrom(s => s._1CGerman.TestAvarage))
                .ForMember(d => d.ShortQuizAvarage, opt => opt.MapFrom(s => s._1CGerman.ShortQuizAvarage))
                .ForMember(d => d.HomeworkAvarage, opt => opt.MapFrom(s => s._1CGerman.HomeworkAvarage));
        }
    }
}
