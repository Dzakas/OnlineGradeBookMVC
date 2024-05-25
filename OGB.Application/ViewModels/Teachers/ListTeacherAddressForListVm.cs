using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Teachers
{
    public class ListTeacherAddressForListVm
    {
        public List<TeacherAddressForListVm> TeacherAddresses { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
}
