using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ContactStudentInfo2C
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int StudentRef { get; set; }
        public _2CStudent _2CStudent { get; set; }
    }
}
