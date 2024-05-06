using AutoMapper;
using Domain.Model;
using OGB.Application.Interfaces;
using OGB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OGB.Application.ViewModels.Class1B.VmForDisplay;
using AutoMapper.QueryableExtensions;
using OGB.Application.ViewModels.Class1B.VmForEdit;

namespace OGB.Application.Services
{
    public class Class1BService : IClass1BService
    {
        private readonly IClass1BRepository _class1BRepository;
        private readonly IMapper _mapper;

        public Class1BService(IClass1BRepository class1BRepository, IMapper mapper)
        {
            _class1BRepository = class1BRepository;
            _mapper = mapper;
        }

        public ListAvarageGrades1BForListVm GetAllAvarageGradesForList()
        {
            var studentsAvarages = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<AvarageGrades1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var student1BList = new ListAvarageGrades1BForListVm()
            {
                AvarageGrades1B = studentsAvarages,
                Count = studentsAvarages.Count
            };
            return student1BList;
        }

        public ListStudentsContactInfo1BForListVm GetAllStudentsContanctInfoForList()
        {
            var studentsContactInfo = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<StudentsContactInfo1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var student1BContactInfoList = new ListStudentsContactInfo1BForListVm()
            {
                StudentsContactInfo1B = studentsContactInfo,
                Count = studentsContactInfo.Count
            };
            return student1BContactInfoList;
        }

        public ListStudentForList1BVm GetAllStudentsForList()
        {
            var students = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<StudentForList1BVm>(_mapper.ConfigurationProvider).ToList();

            var student1BList = new ListStudentForList1BVm()
            {
                Students1B = students,
                Count = students.Count
            };
            return student1BList;
        }
        public ListBiology1BForListVm GetAllBiologyForList()
        {
            var biology = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<Biology1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var biology1BList = new ListBiology1BForListVm()
            {
                Biology1B = biology,
                Count = biology.Count
            };
            return biology1BList;
        }
        public ListChemistry1BForListVm GetAllChemistryForList()
        {
            var chemistry = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<Chemistry1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var chemistry1BList = new ListChemistry1BForListVm()
            {
                Chemistry1B = chemistry,
                Count = chemistry.Count
            };
            return chemistry1BList;
        }
        public ListEnglish1BForListVm GetAllEnglishForList()
        {
            var english = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<English1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var english1BList = new ListEnglish1BForListVm()
            {
                English1B = english,
                Count = english.Count
            };
            return english1BList;
        }
        public ListGeography1BForListVm GetAllGeographyForList()
        {
            var geography = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<Geography1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var geography1BList = new ListGeography1BForListVm()
            {
                Geography1B = geography,
                Count = geography.Count
            };
            return geography1BList;
        }
        public ListGerman1BForListVm GetAllGermanForList()
        {
            var german = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<German1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var german1BList = new ListGerman1BForListVm()
            {
                German1B = german,
                Count = german.Count
            };
            return german1BList;
        }
        public ListHistory1BForListVm GetAllHistoryForList()
        {
            var history = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<History1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var history1BList = new ListHistory1BForListVm()
            {
                History1B = history,
                Count = history.Count
            };
            return history1BList;
        }
        public ListMath1BForListVm GetAllMathForList()
        {
            var math = _class1BRepository.GetAll1BStudentsInfo()
                .ProjectTo<Math1BForListVm>(_mapper.ConfigurationProvider).ToList();

            var math1BList = new ListMath1BForListVm()
            {
                Math1B = math,
                Count = math.Count
            };
            return math1BList;
        }


        public EditBiology1BVm GetBiologyGradeForEdit(int id)
        {
            var biologyGrade = _class1BRepository.GetBiologyGrade(id);
            var biologyGradeVm = _mapper.Map<EditBiology1BVm>(biologyGrade);
            return biologyGradeVm;
        }

        public void UpdateBiologyGrade(EditBiology1BVm model)
        {
            var biologyGrade = _mapper.Map<_1BBiology>(model);
            _class1BRepository.UpdateBiologyGrade(biologyGrade);
        }

        public EditChemistry1BVm GetChemistryGradeForEdit(int id)
        {
            var chemistryGrade = _class1BRepository.GetChemistryGrade(id);
            var chemistryGradeVm = _mapper.Map<EditChemistry1BVm>(chemistryGrade);
            return chemistryGradeVm;
        }

        public void UpdateChemistryGrade(EditChemistry1BVm model)
        {
            var chemistryGrade = _mapper.Map<_1BChemistry>(model);
            _class1BRepository.UpdateChemistryGrade(chemistryGrade);
        }

        public EditEnglish1BVm GetEnglishGradeForEdit(int id)
        {
            var englishGrade = _class1BRepository.GetEnglishGrade(id);
            var englishGradeVm = _mapper.Map<EditEnglish1BVm>(englishGrade);
            return englishGradeVm;
        }

        public void UpdateEnglishGrade(EditEnglish1BVm model)
        {
            var englishGrade = _mapper.Map<_1BEnglish>(model);
            _class1BRepository.UpdateEnglishGrade(englishGrade);
        }

        public EditGeography1BVm GetGeographyGradeForEdit(int id)
        {
            var geographyGrade = _class1BRepository.GetGeographyGrade(id);
            var geographyGradeVm = _mapper.Map<EditGeography1BVm>(geographyGrade);
            return geographyGradeVm;
        }

        public void UpdateGeographyGrade(EditGeography1BVm model)
        {
            var geographyGrade = _mapper.Map<_1BGeography>(model);
            _class1BRepository.UpdateGeographyGrade(geographyGrade);
        }

        public EditGerman1BVm GetGermanGradeForEdit(int id)
        {
            var germanGrade = _class1BRepository.GetGermanGrade(id);
            var germanGradeVm = _mapper.Map<EditGerman1BVm>(germanGrade);
            return germanGradeVm;
        }

        public void UpdateGermanGrade(EditGerman1BVm model)
        {
            var germanGrade = _mapper.Map<_1BGerman>(model);
            _class1BRepository.UpdateGermanGrade(germanGrade);
        }

        public EditHistory1BVm GetHistoryGradeForEdit(int id)
        {
            var historyGrade = _class1BRepository.GetHistoryGrade(id);
            var historyGradeVm = _mapper.Map<EditHistory1BVm>(historyGrade);
            return historyGradeVm;
        }

        public void UpdateHistoryGrade(EditHistory1BVm model)
        {
            var historyGrade = _mapper.Map<_1BHistory>(model);
            _class1BRepository.UpdateHistoryGrade(historyGrade);
        }

        public EditMath1BVm GetMathGradeForEdit(int id)
        {
            var mathGrade = _class1BRepository.GetMathGrade(id);
            var mathGradeVm = _mapper.Map<EditMath1BVm>(mathGrade);
            return mathGradeVm;
        }

        public void UpdateMathGrade(EditMath1BVm model)
        {
            var mathGrade = _mapper.Map<_1BMath>(model);
            _class1BRepository.UpdateMathGrade(mathGrade);
        }
    }
}
