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
    public class Class1BRepository : IClass1BRepository
    {
        private readonly DataContext _dataContext;
        public Class1BRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<_1BStudent> GetAll1BStudentsInfo()
        {
            return _dataContext._1BStudents;
        }

        public _1BBiology GetBiologyGrade(int gradeId)
        {
            return _dataContext._1BBiology.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BChemistry GetChemistryGrade(int gradeId)
        {
            return _dataContext._1BChemistry.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BEnglish GetEnglishGrade(int gradeId)
        {
            return _dataContext._1BEnglish.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BGeography GetGeographyGrade(int gradeId)
        {
            return _dataContext._1BGeography.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BGerman GetGermanGrade(int gradeId)
        {
            return _dataContext._1BGerman.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BHistory GetHistoryGrade(int gradeId)
        {
            return _dataContext._1BHistory.FirstOrDefault(p => p.Id == gradeId);
        }

        public _1BMath GetMathGrade(int gradeId)
        {
            return _dataContext._1BMath.FirstOrDefault(p => p.Id == gradeId);
        }

        public void UpdateBiologyGrade(_1BBiology biology)
        {
            _dataContext.Attach(biology);
            _dataContext.Entry(biology).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(biology).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateChemistryGrade(_1BChemistry chemistry)
        {
            _dataContext.Attach(chemistry);
            _dataContext.Entry(chemistry).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(chemistry).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateEnglishGrade(_1BEnglish english)
        {
            _dataContext.Attach(english);
            _dataContext.Entry(english).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(english).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(english).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGeographyGrade(_1BGeography geography)
        {
            _dataContext.Attach(geography);
            _dataContext.Entry(geography).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(geography).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateGermanGrade(_1BGerman german)
        {
            _dataContext.Attach(german);
            _dataContext.Entry(german).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(german).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(german).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateHistoryGrade(_1BHistory history)
        {
            _dataContext.Attach(history);
            _dataContext.Entry(history).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(history).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(history).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }

        public void UpdateMathGrade(_1BMath math)
        {
            _dataContext.Attach(math);
            _dataContext.Entry(math).Property("TestAvarage").IsModified = true;
            _dataContext.Entry(math).Property("ShortQuizAvarage").IsModified = true;
            _dataContext.Entry(math).Property("HomeworkAvarage").IsModified = true;
            _dataContext.SaveChanges();
        }
    }
}
