using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1B.VmForDisplay
{
    public class ListChemistry1BForListVm
    {
        public List<Chemistry1BForListVm> Chemistry1B { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
}
