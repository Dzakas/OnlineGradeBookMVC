using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Model;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels.Class1C.VmForDisplay;
using OGB.Application.ViewModels.Class1C.VmForEdit;
using OGB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Services
{
    public class Class1CService : IClass1CService
    {
        private readonly IClass1CRepository _class1CRepository;
        private readonly IMapper _mapper;

        public Class1CService(IClass1CRepository class1CRepository, IMapper mapper)
        {
            _class1CRepository = class1CRepository;
            _mapper = mapper;
        }

        public ListAvarageGrades1CForListVm GetAllAvarageGradesForList(int pageSize, int pageNo)
        {
            var studentsAvarages = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<AvarageGrades1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsAvaragesToShow = studentsAvarages.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1CList = new ListAvarageGrades1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                AvarageGrades1C = studentsAvaragesToShow,
                Count = studentsAvarages.Count
            };
            return student1CList;
        }

        public ListStudentsContactInfo1CForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo)
        {
            var studentsContactInfo = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<StudentsContactInfo1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var studentsContactInfoToShow = studentsContactInfo.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1CContactInfoList = new ListStudentsContactInfo1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                StudentsContactInfo1C = studentsContactInfoToShow,
                Count = studentsContactInfo.Count
            };
            return student1CContactInfoList;
        }

        public ListStudentForList1CVm GetAllStudentsForList(int pageSize, int pageNo)
        {
            var students = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<StudentForList1CVm>(_mapper.ConfigurationProvider).ToList();
            var studentsToShow = students.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var student1CList = new ListStudentForList1CVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Students1C = studentsToShow,
                Count = students.Count
            };
            return student1CList;
        }
        public ListBiology1CForListVm GetAllBiologyForList(int pageSize, int pageNo)
        {
            var biology = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<Biology1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var biologyToShow = biology.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var biology1CList = new ListBiology1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Biology1C = biologyToShow,
                Count = biology.Count
            };
            return biology1CList;
        }
        public ListChemistry1CForListVm GetAllChemistryForList(int pageSize, int pageNo)
        {
            var chemistry = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<Chemistry1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var chemistryToShow = chemistry.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var chemistry1CList = new ListChemistry1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Chemistry1C = chemistryToShow,
                Count = chemistry.Count
            };
            return chemistry1CList;
        }
        public ListEnglish1CForListVm GetAllEnglishForList(int pageSize, int pageNo)
        {
            var english = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<English1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var englishToShow = english.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var english1CList = new ListEnglish1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                English1C = englishToShow,
                Count = english.Count
            };
            return english1CList;
        }
        public ListGeography1CForListVm GetAllGeographyForList(int pageSize, int pageNo)
        {
            var geography = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<Geography1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var geographyToShow = geography.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var geography1CList = new ListGeography1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Geography1C = geographyToShow,
                Count = geography.Count
            };
            return geography1CList;
        }
        public ListGerman1CForListVm GetAllGermanForList(int pageSize, int pageNo)
        {
            var german = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<German1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var germanToShow = german.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var german1CList = new ListGerman1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                German1C = germanToShow,
                Count = german.Count
            };
            return german1CList;
        }
        public ListHistory1CForListVm GetAllHistoryForList(int pageSize, int pageNo)
        {
            var history = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<History1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var historyToShow = history.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var history1CList = new ListHistory1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                History1C = historyToShow,
                Count = history.Count
            };
            return history1CList;
        }
        public ListMath1CForListVm GetAllMathForList(int pageSize, int pageNo)
        {
            var math = _class1CRepository.GetAll1CStudentsInfo()
                .ProjectTo<Math1CForListVm>(_mapper.ConfigurationProvider).ToList();
            var mathToShow = math.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var math1CList = new ListMath1CForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                Math1C = mathToShow,
                Count = math.Count
            };
            return math1CList;
        }


        public EditBiology1CVm GetBiologyGradeForEdit(int id)
        {
            var biologyGrade = _class1CRepository.GetBiologyGrade(id);
            var biologyGradeVm = _mapper.Map<EditBiology1CVm>(biologyGrade);
            return biologyGradeVm;
        }

        public void UpdateBiologyGrade(EditBiology1CVm model)
        {
            var biologyGrade = _mapper.Map<_1CBiology>(model);
            _class1CRepository.UpdateBiologyGrade(biologyGrade);
        }

        public EditChemistry1CVm GetChemistryGradeForEdit(int id)
        {
            var chemistryGrade = _class1CRepository.GetChemistryGrade(id);
            var chemistryGradeVm = _mapper.Map<EditChemistry1CVm>(chemistryGrade);
            return chemistryGradeVm;
        }

        public void UpdateChemistryGrade(EditChemistry1CVm model)
        {
            var chemistryGrade = _mapper.Map<_1CChemistry>(model);
            _class1CRepository.UpdateChemistryGrade(chemistryGrade);
        }

        public EditEnglish1CVm GetEnglishGradeForEdit(int id)
        {
            var englishGrade = _class1CRepository.GetEnglishGrade(id);
            var englishGradeVm = _mapper.Map<EditEnglish1CVm>(englishGrade);
            return englishGradeVm;
        }

        public void UpdateEnglishGrade(EditEnglish1CVm model)
        {
            var englishGrade = _mapper.Map<_1CEnglish>(model);
            _class1CRepository.UpdateEnglishGrade(englishGrade);
        }

        public EditGeography1CVm GetGeographyGradeForEdit(int id)
        {
            var geographyGrade = _class1CRepository.GetGeographyGrade(id);
            var geographyGradeVm = _mapper.Map<EditGeography1CVm>(geographyGrade);
            return geographyGradeVm;
        }

        public void UpdateGeographyGrade(EditGeography1CVm model)
        {
            var geographyGrade = _mapper.Map<_1CGeography>(model);
            _class1CRepository.UpdateGeographyGrade(geographyGrade);
        }

        public EditGerman1CVm GetGermanGradeForEdit(int id)
        {
            var germanGrade = _class1CRepository.GetGermanGrade(id);
            var germanGradeVm = _mapper.Map<EditGerman1CVm>(germanGrade);
            return germanGradeVm;
        }

        public void UpdateGermanGrade(EditGerman1CVm model)
        {
            var germanGrade = _mapper.Map<_1CGerman>(model);
            _class1CRepository.UpdateGermanGrade(germanGrade);
        }

        public EditHistory1CVm GetHistoryGradeForEdit(int id)
        {
            var historyGrade = _class1CRepository.GetHistoryGrade(id);
            var historyGradeVm = _mapper.Map<EditHistory1CVm>(historyGrade);
            return historyGradeVm;
        }

        public void UpdateHistoryGrade(EditHistory1CVm model)
        {
            var historyGrade = _mapper.Map<_1CHistory>(model);
            _class1CRepository.UpdateHistoryGrade(historyGrade);
        }

        public EditMath1CVm GetMathGradeForEdit(int id)
        {
            var mathGrade = _class1CRepository.GetMathGrade(id);
            var mathGradeVm = _mapper.Map<EditMath1CVm>(mathGrade);
            return mathGradeVm;
        }

        public void UpdateMathGrade(EditMath1CVm model)
        {
            var mathGrade = _mapper.Map<_1CMath>(model);
            _class1CRepository.UpdateMathGrade(mathGrade);
        }
    }
}
