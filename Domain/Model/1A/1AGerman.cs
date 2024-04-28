using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1AGerman
    {
        public int Id { get; set; }
        public double TestAvarage {  get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public int GradesRef { get; set; }
        public _1AGrades _1AGrades { get; set; }
    }
}
