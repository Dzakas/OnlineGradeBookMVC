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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _dataContext;
        public TeacherRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IQueryable<Teacher> GetAllTeachersInfo()
        {
            return _dataContext.Teacher;
        }
    }
}
