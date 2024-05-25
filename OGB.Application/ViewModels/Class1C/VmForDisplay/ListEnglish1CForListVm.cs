using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.ViewModels.Class1C.VmForDisplay
{
    public class ListEnglish1CForListVm
    {
        public List<English1CForListVm> English1C { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }
}
