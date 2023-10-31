using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class Date
    {

        private int annee;
        private int mois;
        private int jour;
        private DateTime laDate;

        public Date(int annee, int mois, int jour)
        {
            this.annee = annee;
            this.mois = mois;
            this.jour = jour;
            this.laDate = laDate;
        }

        public static Date Aujourdhui()
        {
            return Date.Aujourdhui();
        }

        public int Difference(Date uneDate)
        {
            TimeSpan difference = laDate - uneDate; 
            return (int)difference.TotalDays;
        }

        public int Annee { get => annee; }
        public int Mois { get => mois;}
        public int Jour { get => jour; }
        public DateTime LaDate { get => laDate; }
    }
}
