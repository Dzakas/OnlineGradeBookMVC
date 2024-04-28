using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1BGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _1BBiology _1BBiology { get; set; }
        public _1BChemistry _1BChemistry { get; set; }
        public _1BEnglish _1BEnglish { get; set; }
        public _1BGeography _1BGeography { get; set; }
        public _1BGerman _1BGerman { get; set; }
        public _1BHistory _1BHistory { get; set; }
        public _1BMath _1BMath { get; set; }
        public int StudentRef {  get; set; }
        public _1BStudent _1BStudent { get; set; }
    }
}
