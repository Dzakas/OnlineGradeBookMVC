
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
        public ContactStudentInfo2B StudentContactInfo2B { get; set; }
        public _2BGrades _2BGrades { get; set; }
    }
}
