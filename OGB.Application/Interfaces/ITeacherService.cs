using OGB.Application.ViewModels.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Interfaces
{
    public interface ITeacherService
    {
        ListTeacherForListVm GetAllTeachers(int pageSize, int pageNo);
        ListTeacherAddressForListVm GetAllTeachersAddress(int pageSize, int pageNo);
        ListTeacherContactInfoForListVm GetAllTeachersContactInfo(int pageSize, int pageNo);
    }
}
