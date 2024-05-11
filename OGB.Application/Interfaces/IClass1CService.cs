using OGB.Application.ViewModels.Class1C.VmForDisplay;
using OGB.Application.ViewModels.Class1C.VmForEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Interfaces
{
    public interface IClass1CService
    {
        ListStudentForList1CVm GetAllStudentsForList();
        ListAvarageGrades1CForListVm GetAllAvarageGradesForList();
        ListStudentsContactInfo1CForListVm GetAllStudentsContanctInfoForList();
        ListBiology1CForListVm GetAllBiologyForList();
        ListChemistry1CForListVm GetAllChemistryForList();
        ListEnglish1CForListVm GetAllEnglishForList();
        ListGeography1CForListVm GetAllGeographyForList();
        ListGerman1CForListVm GetAllGermanForList();
        ListHistory1CForListVm GetAllHistoryForList();
        ListMath1CForListVm GetAllMathForList();
        EditBiology1CVm GetBiologyGradeForEdit(int id);
        void UpdateBiologyGrade(EditBiology1CVm model);
        EditChemistry1CVm GetChemistryGradeForEdit(int id);
        void UpdateChemistryGrade(EditChemistry1CVm model);
        EditEnglish1CVm GetEnglishGradeForEdit(int id);
        void UpdateEnglishGrade(EditEnglish1CVm model);
        EditGeography1CVm GetGeographyGradeForEdit(int id);
        void UpdateGeographyGrade(EditGeography1CVm model);
        EditGerman1CVm GetGermanGradeForEdit(int id);
        void UpdateGermanGrade(EditGerman1CVm model);
        EditHistory1CVm GetHistoryGradeForEdit(int id);
        void UpdateHistoryGrade(EditHistory1CVm model);
        EditMath1CVm GetMathGradeForEdit(int id);
        void UpdateMathGrade(EditMath1CVm model);
    }
}
