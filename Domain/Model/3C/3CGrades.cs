using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _3CGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _3CBiology _3CBiology { get; set; }
        public _3CChemistry _3CChemistry { get; set; }
        public _3CEnglish _3CEnglish { get; set; }
        public _3CGeography _3CGeography { get; set; }
        public _3CGerman _3CGerman { get; set; }
        public _3CHistory _3CHistory { get; set; }
        public _3CMath _3CMath { get; set; }
        public int StudentRef { get; set; }
        public _3CStudent _3CStudent { get; set; }
    }
}
