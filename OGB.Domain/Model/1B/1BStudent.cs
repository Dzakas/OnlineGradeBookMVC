
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1BStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo1B ContactStudentInfo1B { get; set; }
        public _1BBiology _1BBiology { get; set; }
        public _1BChemistry _1BChemistry { get; set; }
        public _1BEnglish _1BEnglish { get; set; }
        public _1BGeography _1BGeography { get; set; }
        public _1BGerman _1BGerman { get; set; }
        public _1BHistory _1BHistory { get; set; }
        public _1BMath _1BMath { get; set; }
    }
}
