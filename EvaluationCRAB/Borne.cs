using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class Borne
    {
        private int idBorne;
        private DateTime dateDerniereRevision;
        private int indiceCompteurUnites;
        private TypeBorne leType;

        public Borne(int idBorne, Date dateDerniereRevision, int indiceCompteurUnites, TypeBorne leType)
        {
            this.idBorne = idBorne;
            this.dateDerniereRevision = dateDerniereRevision;
            this.indiceCompteurUnites = indiceCompteurUnites;
            this.leType = leType;
        }

        public int GetDureeRevision() {
            int dureeRevision = LeType.DureeRevision;
            return dureeRevision;
        }

        public bool estAReviser()
        {
            Date dateDuJour = Date.Aujourdhui();
            int difference = 0;
            difference = dateDuJour.Difference(DateTime DateDerniereRevision);

             if(difference > LeType.NbJoursEntreRevisions || this.indiceCompteurUnites > LeType.NbUnitesEntreRevisions ) {

                return true;

            }
            return false;
        }


        public int IdBorne { get => idBorne; }
        public Date DateDerniereRevision { get => dateDerniereRevision; }
        public int  IndiceCompteurUnitees { get => indiceCompteurUnites;}

        public TypeBorne LeType { get => leType; }
    }
}
