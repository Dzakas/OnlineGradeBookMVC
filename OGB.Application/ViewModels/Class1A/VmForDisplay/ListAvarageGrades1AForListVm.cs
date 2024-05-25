using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1A
{
    public class ListAvarageGrades1AForListVm
    {
        public List<AvarageGrades1AForListVm> AvarageGrades1A { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
}
