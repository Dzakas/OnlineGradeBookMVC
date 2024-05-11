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
    public class AvarageGrades1CForListVm : IMapFrom<_1CStudent>
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
            profile.CreateMap<_1CStudent, AvarageGrades1CForListVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.BiologyAvarage, opt => opt.MapFrom(s => (s._1CBiology.ShortQuizAvarage + s._1CBiology.HomeworkAvarage + s._1CBiology.TestAvarage) / 3))
                .ForMember(d => d.ChemistryAvarage, opt => opt.MapFrom(s => (s._1CChemistry.ShortQuizAvarage + s._1CChemistry.HomeworkAvarage + s._1CChemistry.TestAvarage) / 3))
                .ForMember(d => d.EnglishAvarage, opt => opt.MapFrom(s => (s._1CEnglish.ShortQuizAvarage + s._1CEnglish.HomeworkAvarage + s._1CEnglish.TestAvarage) / 3))
                .ForMember(d => d.GeographyAvarage, opt => opt.MapFrom(s => (s._1CGeography.ShortQuizAvarage + s._1CGeography.HomeworkAvarage + s._1CGeography.TestAvarage) / 3))
                .ForMember(d => d.GermanAvarage, opt => opt.MapFrom(s => (s._1CGerman.ShortQuizAvarage + s._1CGerman.HomeworkAvarage + s._1CGerman.TestAvarage) / 3))
                .ForMember(d => d.HistoryAvarage, opt => opt.MapFrom(s => (s._1CHistory.ShortQuizAvarage + s._1CHistory.HomeworkAvarage + s._1CHistory.TestAvarage) / 3))
                .ForMember(d => d.MathAvarage, opt => opt.MapFrom(s => (s._1CMath.ShortQuizAvarage + s._1CMath.HomeworkAvarage + s._1CMath.TestAvarage) / 3));
        }
    }
}
