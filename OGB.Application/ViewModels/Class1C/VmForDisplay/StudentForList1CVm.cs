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
    public class StudentForList1CVm : IMapFrom<_1CStudent>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Avarage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_1CStudent, StudentForList1CVm>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Avarage, opt => opt.MapFrom(s => (((s._1CBiology.HomeworkAvarage + s._1CBiology.TestAvarage + s._1CBiology.ShortQuizAvarage) / 3) +
                ((s._1CChemistry.HomeworkAvarage + s._1CChemistry.TestAvarage + s._1CChemistry.ShortQuizAvarage) / 3) +
                ((s._1CEnglish.HomeworkAvarage + s._1CEnglish.TestAvarage + s._1CEnglish.ShortQuizAvarage) / 3) +
                ((s._1CGeography.HomeworkAvarage + s._1CGeography.TestAvarage + s._1CGeography.ShortQuizAvarage) / 3) +
                ((s._1CGerman.HomeworkAvarage + s._1CGerman.TestAvarage + s._1CGerman.ShortQuizAvarage) / 3) +
                ((s._1CHistory.HomeworkAvarage + s._1CHistory.TestAvarage + s._1CHistory.ShortQuizAvarage) / 3) +
                ((s._1CMath.HomeworkAvarage + s._1CMath.TestAvarage + s._1CMath.ShortQuizAvarage) / 3)) / 7));
        }
    }
}
