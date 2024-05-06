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
        EditBiology1AVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(EditBiology1AVm model);
        EditChemistry1AVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(EditChemistry1AVm model);
        EditEnglish1AVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(EditEnglish1AVm model);
        EditGeography1AVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(EditGeography1AVm model);
        EditGerman1AVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(EditGerman1AVm model);
        EditHistory1AVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(EditHistory1AVm model);
        EditMath1AVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(EditMath1AVm model);
    }
}
