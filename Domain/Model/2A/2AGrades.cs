using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2AGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _2ABiology _2ABiology { get; set; }
        public _2AChemistry _2AChemistry { get; set; }
        public _2AEnglish _2AEnglish { get; set; }
        public _2AGeography _2AGeography { get; set; }
        public _2AGerman _2AGerman { get; set; }
        public _2AHistory _2AHistory { get; set; }
        public _2AMath _2AMath { get; set; }
        public int StudentRef { get; set; }
        public _2AStudent _2AStudent { get; set; }
    }
}
