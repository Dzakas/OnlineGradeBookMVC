
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2CStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo2C ContactStudentInfo2C { get; set; }
        public _2CBiology _2CBiology { get; set; }
        public _2CChemistry _2CChemistry { get; set; }
        public _2CEnglish _2CEnglish { get; set; }
        public _2CGeography _2CGeography { get; set; }
        public _2CGerman _2CGerman { get; set; }
        public _2CHistory _2CHistory { get; set; }
        public _2CMath _2CMath { get; set; }
    }
}
