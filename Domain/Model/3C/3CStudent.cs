
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
        public ContactStudentInfo3C StudentContactInfo3C { get; set; }
        public _3CGrades _3CGrades { get; set; }
    }
}
