using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Liaison
    {
        private string nomPortDepart;
        private string nomPortArrivee;
        private int noLiaison;
        public Liaison(string nouvNomDepart, string nouvNomArrivee, int nouvNoLiaison)
        {
            this.nomPortDepart = nouvNomDepart;
            this.nomPortArrivee = nouvNomArrivee;
            this.noLiaison = nouvNoLiaison;
        }
        public int GetNoLiaison()
        {
            return noLiaison;
        }
        public override string ToString()
        {
            return nomPortDepart + " - " + nomPortArrivee;
        }
    }
}