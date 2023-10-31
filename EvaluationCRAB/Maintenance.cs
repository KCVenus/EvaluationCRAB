using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class Maintenance
    {

        private Collection<Station> lesStation;
        private Collection<Technicien> lesTechniciens;
        private Collection<Visite> lesVisites;

        public Maintenance() { }


        public void Reviser() { }


        public void AffecterVisite(Visite uneVisite) {
            int temps = 0;
            int temps2 = 0;
            foreach (Visite viste in lesvisites)
            {

                foreach (Technicien technicien in lesTechniciens)
                {
                    Technicien technicien1;
                    Technicien technicien2;
                    int i = +0;
                    int total = lesTechniciens.Count;
                    technicien1 = lestechniciens.ElementAt(i);
                    technicien2 = lestechniciens.ElementAt(++i);
                    temps = technicien1.GetTempsOccupe();
                    temps2 = technicien2.GetTempsOccupe();
                    if (temps < temps2)
                    {
                        lesTechniciens[i].AffecterVisite(lesvisites[i]);
                        lesvisites[i].ChangerEtat();
                    }


                }

            }
          

        }

        public Collection<Station> lesStations { get => lesStations; }
        public Collection<Technicien> lestechniciens { get => lestechniciens;}

        public Collection<Visite> lesvisites { get => lesVisites; }




    }
}
