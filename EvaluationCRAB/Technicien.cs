using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class Technicien
    {

        private int matricule;
        private string nom;
        private string prenom;
        private Collection<Visite> lesVisites;


        public Technicien(int matricule, string nom, string prenom, Collection<Visite> lesVisites) { }

        public Technicien(int matricule, string nom, string prenom)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.lesVisites = lesVisites;
        }

       public int GetTempsOccupe()
            {
                return 18;
            }

        public void AffecterVisite(Visite uneVisite) { 
           this.lesVisites.Add(uneVisite);
        }


        public int Matricule { get => matricule; }
        public string Prenom { get => nom; }

        public string Nom { get => nom; }

        public Collection<Visite> LesVisites { get => lesVisites; }

    }
}
