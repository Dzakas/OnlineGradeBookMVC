
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3AStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo3A ContactStudentInfo3A { get; set; }
        public _3ABiology _3ABiology { get; set; }
        public _3AChemistry _3AChemistry { get; set; }
        public _3AEnglish _3AEnglish { get; set; }
        public _3AGeography _3AGeography { get; set; }
        public _3AGerman _3AGerman { get; set; }
        public _3AHistory _3AHistory { get; set; }
        public _3AMath _3AMath { get; set; }
    }
}
