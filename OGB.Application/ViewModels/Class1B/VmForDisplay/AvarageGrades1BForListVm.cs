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
    public class AvarageGrades1BForListVm : IMapFrom<_1BStudent>
    {
        public int Id { get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public bool Passed => BiologyAvarage > 2 || ChemistryAvarage > 2 || EnglishAvarage > 2 ||
            GeographyAvarage > 2 || GermanAvarage > 2 || HistoryAvarage > 2 || MathAvarage > 2 ||
            ((BiologyAvarage + ChemistryAvarage + EnglishAvarage + GeographyAvarage + GermanAvarage + HistoryAvarage + MathAvarage) / 7 > 2);

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1BStudent, AvarageGrades1BForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.BiologyAvarage, opt => opt.MapFrom(s => (s._1BBiology.ShortQuizAvarage + s._1BBiology.HomeworkAvarage + s._1BBiology.TestAvarage) / 3))
                .ForMember(d => d.ChemistryAvarage, opt => opt.MapFrom(s => (s._1BChemistry.ShortQuizAvarage + s._1BChemistry.HomeworkAvarage + s._1BChemistry.TestAvarage) / 3))
                .ForMember(d => d.EnglishAvarage, opt => opt.MapFrom(s => (s._1BEnglish.ShortQuizAvarage + s._1BEnglish.HomeworkAvarage + s._1BEnglish.TestAvarage) / 3))
                .ForMember(d => d.GeographyAvarage, opt => opt.MapFrom(s => (s._1BGeography.ShortQuizAvarage + s._1BGeography.HomeworkAvarage + s._1BGeography.TestAvarage) / 3))
                .ForMember(d => d.GermanAvarage, opt => opt.MapFrom(s => (s._1BGerman.ShortQuizAvarage + s._1BGerman.HomeworkAvarage + s._1BGerman.TestAvarage) / 3))
                .ForMember(d => d.HistoryAvarage, opt => opt.MapFrom(s => (s._1BHistory.ShortQuizAvarage + s._1BHistory.HomeworkAvarage + s._1BHistory.TestAvarage) / 3))
                .ForMember(d => d.MathAvarage, opt => opt.MapFrom(s => (s._1BMath.ShortQuizAvarage + s._1BMath.HomeworkAvarage + s._1BMath.TestAvarage) / 3));
        }
    }
}
