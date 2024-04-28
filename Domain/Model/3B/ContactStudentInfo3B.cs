using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ContactStudentInfo3B
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int StudentRef { get; set; }
        public _3BStudent _3BStudent { get; set; }
    }
}
