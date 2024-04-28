
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2BStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo2B ContactStudentInfo2B { get; set; }
        public _2BBiology _2BBiology { get; set; }
        public _2BChemistry _2BChemistry { get; set; }
        public _2BEnglish _2BEnglish { get; set; }
        public _2BGeography _2BGeography { get; set; }
        public _2BGerman _2BGerman { get; set; }
        public _2BHistory _2BHistory { get; set; }
        public _2BMath _2BMath { get; set; }
    }
}
