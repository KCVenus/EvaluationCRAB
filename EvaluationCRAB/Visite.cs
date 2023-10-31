using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvaluationCRAB
{
    public class Visite
    {

        private char etat;

        private int dureeTotal;

        private Collection<Borne> lesbornes;

        public Visite(Collection<Borne> lesbornesAVisiter, Station laStation) => this.lesbornes = lesbornesAVisiter;

        public Visite() { };


        public void ChangerEtat() {
            
        }

        public Visite VisiteAFaire()
        {
            Collection<Borne> lesBornesAReviser = new Collection<Borne>();
            Visite visiteAFaire = new Visite(lesBornesAReviser, LaStation);

            // note à moi même quand on met bien le type de l'objet avant l'objet, pas besoin de préciser que la collection est une collection d'Objet 'x'
            foreach (Borne borne in lesBornes)
            {
                int i = +0;
                // attention le code qui suit ne fonctionne pas car contrairement a Windev on ne peux pas verifier de condition directement dans un if comme cela, il faur stocker la valeur puis vérifier.
                //              if (lesBornes[i].estAReviser)
                //             {
                //                   lesBornesAReviser.Add(borne);
                //                }
                //           }
                // donc :
                bool ok = true;

                // ok = lesBornes[i].estAReviser;

                // et NON toujours pas ! il faut aussi stocker la valeur de I dans un object !!!
                Borne borne1 = borne;
                borne1 = lesbornes[i];

                // code pas bon, trouver une solution :
                //    ok = borne1.estAReviser;
                // suposon que la borne séléctionné soit à Reviser

                if (ok = true)
                {
                    lesBornesAReviser.Add(borne1);
                    return visiteAFaire;
                } else
                {
                    return null;
                }
                

            }
        }


        public char Etat {  get => etat; }  
        public int DureeTotale { get => dureeTotal; }
        public Station LaStation { get => LaStation; }

        public Collection<Borne> lesBornes { get => lesbornes; }
    }
}
