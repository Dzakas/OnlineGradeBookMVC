using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1AGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _1ABiology _1ABiology { get; set; }
        public _1AChemistry _1AChemistry { get; set; }
        public _1AEnglish _1AEnglish { get; set; }
        public _1AGeography _1AGeography { get; set; }
        public _1AGerman _1AGerman { get; set; }
        public _1AHistory _1AHistory { get; set; }
        public _1AMath _1AMath { get; set; }
        public int StudentRef {  get; set; }
        public _1AStudent _1AStudent { get; set; }
    }
}
