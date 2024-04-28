
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2AStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo2A ContactStudentInfo2A { get; set; }
        public _2ABiology _2ABiology { get; set; }
        public _2AChemistry _2AChemistry { get; set; }
        public _2AEnglish _2AEnglish { get; set; }
        public _2AGeography _2AGeography { get; set; }
        public _2AGerman _2AGerman { get; set; }
        public _2AHistory _2AHistory { get; set; }
        public _2AMath _2AMath { get; set; }
    }
}
