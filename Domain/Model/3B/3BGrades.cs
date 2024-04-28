using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3BGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _3BBiology _3BBiology { get; set; }
        public _3BChemistry _3BChemistry { get; set; }
        public _3BEnglish _3BEnglish { get; set; }
        public _3BGeography _3BGeography { get; set; }
        public _3BGerman _3BGerman { get; set; }
        public _3BHistory _3BHistory { get; set; }
        public _3BMath _3BMath { get; set; }
        public int StudentRef { get; set; }
        public _3BStudent _3BStudent { get; set; }
    }
}
