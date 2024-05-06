using AutoMapper;
using Domain.Model;
using OGB.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1B.VmForDisplay
{
    public class StudentForList1BVm : IMapFrom<_1BStudent>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Avarage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1BStudent, StudentForList1BVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Avarage, opt => opt.MapFrom(s => (((s._1BBiology.HomeworkAvarage + s._1BBiology.TestAvarage + s._1BBiology.ShortQuizAvarage) / 3) +
                ((s._1BChemistry.HomeworkAvarage + s._1BChemistry.TestAvarage + s._1BChemistry.ShortQuizAvarage) / 3) +
                ((s._1BEnglish.HomeworkAvarage + s._1BEnglish.TestAvarage + s._1BEnglish.ShortQuizAvarage) / 3) +
                ((s._1BGeography.HomeworkAvarage + s._1BGeography.TestAvarage + s._1BGeography.ShortQuizAvarage) / 3) +
                ((s._1BGerman.HomeworkAvarage + s._1BGerman.TestAvarage + s._1BGerman.ShortQuizAvarage) / 3) +
                ((s._1BHistory.HomeworkAvarage + s._1BHistory.TestAvarage + s._1BHistory.ShortQuizAvarage) / 3) +
                ((s._1BMath.HomeworkAvarage + s._1BMath.TestAvarage + s._1BMath.ShortQuizAvarage) / 3)) / 7));
        }
    }
}
