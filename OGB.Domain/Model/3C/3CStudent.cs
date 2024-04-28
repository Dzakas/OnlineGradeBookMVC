
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3CStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo3C ContactStudentInfo3C { get; set; }
        public _3CBiology _3CBiology { get; set; }
        public _3CChemistry _3CChemistry { get; set; }
        public _3CEnglish _3CEnglish { get; set; }
        public _3CGeography _3CGeography { get; set; }
        public _3CGerman _3CGerman { get; set; }
        public _3CHistory _3CHistory { get; set; }
        public _3CMath _3CMath { get; set; }
    }
}
