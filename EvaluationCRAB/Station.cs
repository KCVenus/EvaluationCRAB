using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class Station
    {

        private int idStation;
        private string libelleEmplacement;
        private Collection<Borne> lesBornes;


        public Station(int idStation, string libelleEmplacement)
        {
            this.idStation = idStation;
            this.lesBornes = new Collection<Borne>();
            this.libelleEmplacement = libelleEmplacement;
        }


    public Station(int idStation, string libelleEmplacement, Collection<Borne> lesBornes)
        {
            this.idStation = idStation;
            this.lesBornes = new Collection<Borne>();
            this.libelleEmplacement = libelleEmplacement;
        }
       


    public Visite AjouteBorne(Borne borne)
        {
            var ok = new Visite();
            return ok;
        }
    }
}
