using OGB.Application.ViewModels.Class1B.VmForDisplay;
using OGB.Application.ViewModels.Class1B.VmForEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Interfaces
{
    public interface IClass1BService
    {
        ListStudentForList1BVm GetAllStudentsForList();
        ListAvarageGrades1BForListVm GetAllAvarageGradesForList();
        ListStudentsContactInfo1BForListVm GetAllStudentsContanctInfoForList();
        ListBiology1BForListVm GetAllBiologyForList();
        ListChemistry1BForListVm GetAllChemistryForList();
        ListEnglish1BForListVm GetAllEnglishForList();
        ListGeography1BForListVm GetAllGeographyForList();
        ListGerman1BForListVm GetAllGermanForList();
        ListHistory1BForListVm GetAllHistoryForList();
        ListMath1BForListVm GetAllMathForList();
        EditBiology1BVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(EditBiology1BVm model);
        EditChemistry1BVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(EditChemistry1BVm model);
        EditEnglish1BVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(EditEnglish1BVm model);
        EditGeography1BVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(EditGeography1BVm model);
        EditGerman1BVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(EditGerman1BVm model);
        EditHistory1BVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(EditHistory1BVm model);
        EditMath1BVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(EditMath1BVm model);
    }
}
