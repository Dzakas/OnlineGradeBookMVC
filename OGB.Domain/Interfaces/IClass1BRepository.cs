using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Domain.Interfaces
{
    public interface IClass1BRepository
    {
        IQueryable<_1BStudent> GetAll1BStudentsInfo();
        _1BBiology GetBiologyGrade(int gradeid);
        void UpdateBiologyGrade(_1BBiology biology);
        _1BChemistry GetChemistryGrade(int gradeid);
        void UpdateChemistryGrade(_1BChemistry chemistry);
        _1BEnglish GetEnglishGrade(int gradeid);
        void UpdateEnglishGrade(_1BEnglish english);
        _1BGeography GetGeographyGrade(int gradeid);
        void UpdateGeographyGrade(_1BGeography geography);
        _1BGerman GetGermanGrade(int gradeid);
        void UpdateGermanGrade(_1BGerman german);
        _1BHistory GetHistoryGrade(int gradeid);
        void UpdateHistoryGrade(_1BHistory history);
        _1BMath GetMathGrade(int gradeid);
        void UpdateMathGrade(_1BMath math);
    }
}
