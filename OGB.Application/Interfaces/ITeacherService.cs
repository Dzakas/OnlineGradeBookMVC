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
        ListTeacherForListVm GetAllTeachers();
        ListTeacherAddressForListVm GetAllTeachersAddress();
        ListTeacherContactInfoForListVm GetAllTeachersContactInfo();
    }
}
