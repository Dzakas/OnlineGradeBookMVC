using OGB.Application.ViewModels.Class1A;
using OGB.Application.ViewModels.Class1A.VmForEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Interfaces
{
    public interface IClass1AService
    {
        ListStudentForList1AVm GetAllStudentsForList();
        ListAvarageGrades1AForListVm GetAllAvarageGradesForList();
        ListStudentsContactInfo1AForListVm GetAllStudentsContanctInfoForList();
        ListBiology1AForListVm GetAllBiologyForList();
        ListChemistry1AForListVm GetAllChemistryForList();
        ListEnglish1AForListVm GetAllEnglishForList();
        ListGeography1AForListVm GetAllGeographyForList();
        ListGerman1AForListVm GetAllGermanForList();
        ListHistory1AForListVm GetAllHistoryForList();
        ListMath1AForListVm GetAllMathForList();
        NewBiologyVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(NewBiologyVm model);
        NewChemistryVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(NewChemistryVm model);
        NewEnglishVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(NewEnglishVm model);
        NewGeographyVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(NewGeographyVm model);
        NewGermanVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(NewGermanVm model);
        NewHistoryVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(NewHistoryVm model);
        NewMathVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(NewMathVm model);
    }
}
