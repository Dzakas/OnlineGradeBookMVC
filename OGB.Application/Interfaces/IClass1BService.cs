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
        ListStudentForList1BVm GetAllStudentsForList(int pageSize, int pageNo);
        ListAvarageGrades1BForListVm GetAllAvarageGradesForList(int pageSize, int pageNo);
        ListStudentsContactInfo1BForListVm GetAllStudentsContanctInfoForList(int pageSize, int pageNo);
        ListBiology1BForListVm GetAllBiologyForList(int pageSize, int pageNo);
        ListChemistry1BForListVm GetAllChemistryForList(int pageSize, int pageNo);
        ListEnglish1BForListVm GetAllEnglishForList(int pageSize, int pageNo);
        ListGeography1BForListVm GetAllGeographyForList(int pageSize, int pageNo);
        ListGerman1BForListVm GetAllGermanForList(int pageSize, int pageNo);
        ListHistory1BForListVm GetAllHistoryForList(int pageSize, int pageNo);
        ListMath1BForListVm GetAllMathForList(int pageSize, int pageNo);
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
