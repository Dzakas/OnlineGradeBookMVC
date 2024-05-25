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
        ListStudentForList1CVm GetAllStudentsForList(int pageSize, int pageNo);
        ListAvarageGrades1CForListVm GetAllAvarageGradesForList(int pageSize, int pageNo);
        ListStudentsContactInfo1CForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo);
        ListBiology1CForListVm GetAllBiologyForList(int pageSize, int pageNo);
        ListChemistry1CForListVm GetAllChemistryForList(int pageSize, int pageNo);
        ListEnglish1CForListVm GetAllEnglishForList(int pageSize, int pageNo);
        ListGeography1CForListVm GetAllGeographyForList(int pageSize, int pageNo);
        ListGerman1CForListVm GetAllGermanForList(int pageSize, int pageNo);
        ListHistory1CForListVm GetAllHistoryForList(int pageSize, int pageNo);
        ListMath1CForListVm GetAllMathForList(int pageSize, int pageNo);
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
