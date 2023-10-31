using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationCRAB
{
    public class TypeBorne
    {

        private string codeTypeborne;

        private int dureeRevision;
        private int nbJoursEntreRevisions;
        private int nbUnitesEntreRevisions;

        public TypeBorne(string codeTypeborne, int dureeRevision, int nbJoursEntreRevisions, int nbUnitesEntreRevisions)
        {
            this.codeTypeborne = codeTypeborne;
            this.dureeRevision = dureeRevision;
            this.nbJoursEntreRevisions = nbJoursEntreRevisions;
            this.nbUnitesEntreRevisions = nbUnitesEntreRevisions;
        }

        public string CodeTypeBorne { get => codeTypeborne; }
        public int DureeRevision { get => dureeRevision; set => dureeRevision = value; }

        public int NbJoursEntreRevisions { get => nbJoursEntreRevisions; set  => nbJoursEntreRevisions = value;}

        public int NbUnitesEntreRevisions { get => nbUnitesEntreRevisions; set => nbJoursEntreRevisions = value;  }
    }
}
