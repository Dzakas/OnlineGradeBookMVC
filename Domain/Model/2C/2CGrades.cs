using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2CGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _2CBiology _2CBiology { get; set; }
        public _2CChemistry _2CChemistry { get; set; }
        public _2CEnglish _2CEnglish { get; set; }
        public _2CGeography _2CGeography { get; set; }
        public _2CGerman _2CGerman { get; set; }
        public _2CHistory _2CHistory { get; set; }
        public _2CMath _2CMath { get; set; }
        public int StudentRef { get; set; }
        public _2CStudent _2CStudent { get; set; }
    }
}
