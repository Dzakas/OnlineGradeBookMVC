using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3AGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _3ABiology _3ABiology { get; set; }
        public _3AChemistry _3AChemistry { get; set; }
        public _3AEnglish _3AEnglish { get; set; }
        public _3AGeography _3AGeography { get; set; }
        public _3AGerman _3AGerman { get; set; }
        public _3AHistory _3AHistory { get; set; }
        public _3AMath _3AMath { get; set; }
        public int StudentRef { get; set; }
        public _3AStudent _3AStudent { get; set; }
    }
}
