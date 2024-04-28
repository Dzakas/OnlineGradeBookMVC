
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3BStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo3B ContactStudentInfo3B { get; set; }
        public _3BBiology _3BBiology { get; set; }
        public _3BChemistry _3BChemistry { get; set; }
        public _3BEnglish _3BEnglish { get; set; }
        public _3BGeography _3BGeography { get; set; }
        public _3BGerman _3BGerman { get; set; }
        public _3BHistory _3BHistory { get; set; }
        public _3BMath _3BMath { get; set; }
    }
}
