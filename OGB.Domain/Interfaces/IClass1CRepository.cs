using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Domain.Interfaces
{
    public interface IClass1CRepository
    {
        IQueryable<_1CStudent> GetAll1CStudentsInfo();
        _1CBiology GetBiologyGrade(int gradeid);
        void UpdateBiologyGrade(_1CBiology biology);
        _1CChemistry GetChemistryGrade(int gradeid);
        void UpdateChemistryGrade(_1CChemistry chemistry);
        _1CEnglish GetEnglishGrade(int gradeid);
        void UpdateEnglishGrade(_1CEnglish english);
        _1CGeography GetGeographyGrade(int gradeid);
        void UpdateGeographyGrade(_1CGeography geography);
        _1CGerman GetGermanGrade(int gradeid);
        void UpdateGermanGrade(_1CGerman german);
        _1CHistory GetHistoryGrade(int gradeid);
        void UpdateHistoryGrade(_1CHistory history);
        _1CMath GetMathGrade(int gradeid);
        void UpdateMathGrade(_1CMath math);
    }
}
