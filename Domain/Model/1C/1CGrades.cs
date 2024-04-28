using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1CGrades
    {
        public int Id {  get; set; }
        public double BiologyAvarage { get; set; }
        public double ChemistryAvarage { get; set; }
        public double EnglishAvarage { get; set; }
        public double GeographyAvarage { get; set; }
        public double GermanAvarage { get; set; }
        public double HistoryAvarage { get; set; }
        public double MathAvarage { get; set; }
        public _1CBiology _1CBiology { get; set; }
        public _1CChemistry _1CChemistry { get; set; }
        public _1CEnglish _1CEnglish { get; set; }
        public _1CGeography _1CGeography { get; set; }
        public _1CGerman _1CGerman { get; set; }
        public _1CHistory _1CHistory { get; set; }
        public _1CMath _1CMath { get; set; }
        public int StudentRef { get; set; }
        public _1CStudent _1CStudent { get; set; }
    }
}
