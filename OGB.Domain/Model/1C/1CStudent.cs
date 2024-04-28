
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1CStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo1C ContactStudentInfo1C { get; set; }
        public _1CBiology _1CBiology { get; set; }
        public _1CChemistry _1CChemistry { get; set; }
        public _1CEnglish _1CEnglish { get; set; }
        public _1CGeography _1CGeography { get; set; }
        public _1CGerman _1CGerman { get; set; }
        public _1CHistory _1CHistory { get; set; }
        public _1CMath _1CMath { get; set; }
    }
}
