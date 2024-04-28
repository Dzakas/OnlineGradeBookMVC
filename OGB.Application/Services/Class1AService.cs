using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Model;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels.Class1A;
using OGB.Application.ViewModels.Class1A.VmForEdit;
using OGB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Services
{
    public class Class1AService : IClass1AService
    {
        private readonly IClass1ARepository _class1ARepository;
        private readonly IMapper _mapper;

        public Class1AService(IClass1ARepository class1ARepository, IMapper mapper)
        {
            _class1ARepository = class1ARepository;
            _mapper = mapper;            
        }

        public ListAvarageGrades1AForListVm GetAllAvarageGradesForList()
        {
            var studentsAvarages = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<AvarageGrades1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var student1AList = new ListAvarageGrades1AForListVm()
            {
                AvarageGrades1A = studentsAvarages,
                Count = studentsAvarages.Count
            };
            return student1AList;
        }

        public ListStudentsContactInfo1AForListVm GetAllStudentsContanctInfoForList()
        {
            var studentsContactInfo = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<StudentsContactInfo1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var student1AContactInfoList = new ListStudentsContactInfo1AForListVm()
            {
                StudentsContactInfo1A = studentsContactInfo,
                Count = studentsContactInfo.Count
            };
            return student1AContactInfoList;
        }

        public ListStudentForList1AVm GetAllStudentsForList()
        {
            var students = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<StudentForList1AVm>(_mapper.ConfigurationProvider).ToList();

            var student1AList = new ListStudentForList1AVm()
            {
                Students1A = students,
                Count = students.Count
            };
            return student1AList;
        }
        public ListBiology1AForListVm GetAllBiologyForList()
        {
            var biology = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Biology1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var biology1AList = new ListBiology1AForListVm()
            {
                Biology1A = biology,
                Count = biology.Count
            };
            return biology1AList;
        }
        public ListChemistry1AForListVm GetAllChemistryForList()
        {
            var chemistry = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Chemistry1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var chemistry1AList = new ListChemistry1AForListVm()
            {
                Chemistry1A = chemistry,
                Count = chemistry.Count
            };
            return chemistry1AList;
        }
        public ListEnglish1AForListVm GetAllEnglishForList()
        {
            var english = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<English1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var english1AList = new ListEnglish1AForListVm()
            {
                English1A = english,
                Count = english.Count
            };
            return english1AList;
        }
        public ListGeography1AForListVm GetAllGeographyForList()
        {
            var geography = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Geography1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var geography1AList = new ListGeography1AForListVm()
            {
                Geography1A = geography,
                Count = geography.Count
            };
            return geography1AList;
        }
        public ListGerman1AForListVm GetAllGermanForList()
        {
            var german = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<German1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var german1AList = new ListGerman1AForListVm()
            {
                German1A = german,
                Count = german.Count
            };
            return german1AList;
        }
        public ListHistory1AForListVm GetAllHistoryForList()
        {
            var history = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<History1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var history1AList = new ListHistory1AForListVm()
            {
                History1A = history,
                Count = history.Count
            };
            return history1AList;
        }
        public ListMath1AForListVm GetAllMathForList()
        {
            var math = _class1ARepository.GetAll1AStudentsInfo()
                .ProjectTo<Math1AForListVm>(_mapper.ConfigurationProvider).ToList();

            var math1AList = new ListMath1AForListVm()
            {
                Math1A = math,
                Count = math.Count
            };
            return math1AList;
        }


        public NewBiologyVm GetBiologyGradeForEdit(int id)
        {
            var biologyGrade = _class1ARepository.GetBiologyGrade(id);
            var biologyGradeVm = _mapper.Map<NewBiologyVm>(biologyGrade);
            return biologyGradeVm;
        }

        public void UpdateBiologyGrade(NewBiologyVm model)
        {
            var biologyGrade = _mapper.Map<_1ABiology>(model);
            _class1ARepository.UpdateBiologyGrade(biologyGrade);
        }

        public NewChemistryVm GetChemistryGradeForEdit(int id)
        {
            var chemistryGrade = _class1ARepository.GetChemistryGrade(id);
            var chemistryGradeVm = _mapper.Map<NewChemistryVm>(chemistryGrade);
            return chemistryGradeVm;
        }

        public void UpdateChemistryGrade(NewChemistryVm model)
        {
            var chemistryGrade = _mapper.Map<_1AChemistry>(model);
            _class1ARepository.UpdateChemistryGrade(chemistryGrade);
        }

        public NewEnglishVm GetEnglishGradeForEdit(int id)
        {
            var englishGrade = _class1ARepository.GetEnglishGrade(id);
            var englishGradeVm = _mapper.Map<NewEnglishVm>(englishGrade);
            return englishGradeVm;
        }

        public void UpdateEnglishGrade(NewEnglishVm model)
        {
            var englishGrade = _mapper.Map<_1AEnglish>(model);
            _class1ARepository.UpdateEnglishGrade(englishGrade);
        }

        public NewGeographyVm GetGeographyGradeForEdit(int id)
        {
            var geographyGrade = _class1ARepository.GetGeographyGrade(id);
            var geographyGradeVm = _mapper.Map<NewGeographyVm>(geographyGrade);
            return geographyGradeVm;
        }

        public void UpdateGeographyGrade(NewGeographyVm model)
        {
            var geographyGrade = _mapper.Map<_1AGeography>(model);
            _class1ARepository.UpdateGeographyGrade(geographyGrade);
        }

        public NewGermanVm GetGermanGradeForEdit(int id)
        {
            var germanGrade = _class1ARepository.GetGermanGrade(id);
            var germanGradeVm = _mapper.Map<NewGermanVm>(germanGrade);
            return germanGradeVm;
        }

        public void UpdateGermanGrade(NewGermanVm model)
        {
            var germanGrade = _mapper.Map<_1AGerman>(model);
            _class1ARepository.UpdateGermanGrade(germanGrade);
        }

        public NewHistoryVm GetHistoryGradeForEdit(int id)
        {
            var historyGrade = _class1ARepository.GetHistoryGrade(id);
            var historyGradeVm = _mapper.Map<NewHistoryVm>(historyGrade);
            return historyGradeVm;
        }

        public void UpdateHistoryGrade(NewHistoryVm model)
        {
            var historyGrade = _mapper.Map<_1AHistory>(model);
            _class1ARepository.UpdateHistoryGrade(historyGrade);
        }

        public NewMathVm GetMathGradeForEdit(int id)
        {
            var mathGrade = _class1ARepository.GetMathGrade(id);
            var mathGradeVm = _mapper.Map<NewMathVm>(mathGrade);
            return mathGradeVm;
        }

        public void UpdateMathGrade(NewMathVm model)
        {
            var mathGrade = _mapper.Map<_1AMath>(model);
            _class1ARepository.UpdateMathGrade(mathGrade);
        }
    }
}
