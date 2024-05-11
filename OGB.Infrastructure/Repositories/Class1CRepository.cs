using Domain.Model;
using Infrastructure;
using OGB.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Infrastructure.Repositories
{
    public class Class1CRepository : IClass1CRepository
    {
        private readonly DataContext _dataContext;
        public Class1CRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<_1CStudent> GetAll1CStudentsInfo()
        {
            return _dataContext._1CStudents;
        }

        public _1CBiology GetBiologyGrade(int gradeId)
        {
            return _dataContext._1CBiology.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CChemistry GetChemistryGrade(int gradeId)
        {
            return _dataContext._1CChemistry.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CEnglish GetEnglishGrade(int gradeId)
        {
            return _dataContext._1CEnglish.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CGeography GetGeographyGrade(int gradeId)
        {
            return _dataContext._1CGeography.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CGerman GetGermanGrade(int gradeId)
        {
            return _dataContext._1CGerman.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CHistory GetHistoryGrade(int gradeId)
        {
            return _dataContext._1CHistory.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1CMath GetMathGrade(int gradeId)
        {
            return _dataContext._1CMath.FirstOrDefault(p => p.Id == gradeId);
        }

        public void UpdateBiologyGrade(_1CBiology biology)
        {
            _dataContext.Attach(biology);
            _dataContext.Entry(biology).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateChemistryGrade(_1CChemistry chemistry)
        {
            _dataContext.Attach(chemistry);
            _dataContext.Entry(chemistry).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateEnglishGrade(_1CEnglish english)
        {
            _dataContext.Attach(english);
            _dataContext.Entry(english).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(english).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(english).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGeographyGrade(_1CGeography geography)
        {
            _dataContext.Attach(geography);
            _dataContext.Entry(geography).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGermanGrade(_1CGerman german)
        {
            _dataContext.Attach(german);
            _dataContext.Entry(german).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(german).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(german).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateHistoryGrade(_1CHistory history)
        {
            _dataContext.Attach(history);
            _dataContext.Entry(history).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(history).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(history).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateMathGrade(_1CMath math)
        {
            _dataContext.Attach(math);
            _dataContext.Entry(math).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(math).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(math).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }
    }
}
