using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3BGerman
    {
        public int Id { get; set; }
        public double TestAvarage {  get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public int StudentRef { get; set; }
        public _3BStudent _3BStudent { get; set; }
    }
}
