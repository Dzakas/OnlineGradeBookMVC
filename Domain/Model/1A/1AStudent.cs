
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1AStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactStudentInfo1A StudentContactInfo1A { get; set; }
        public _1AGrades _1AGrades { get; set; }
    }
}
