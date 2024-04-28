using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2BGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _2BBiology _2BBiology { get; set; }
        public _2BChemistry _2BChemistry { get; set; }
        public _2BEnglish _2BEnglish { get; set; }
        public _2BGeography _2BGeography { get; set; }
        public _2BGerman _2BGerman { get; set; }
        public _2BHistory _2BHistory { get; set; }
        public _2BMath _2BMath { get; set; }
        public int StudentRef { get; set; }
        public _2BStudent _2BStudent { get; set; }
    }
}
