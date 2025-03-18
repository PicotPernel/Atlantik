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
        public Liaison(string nouvNoDepart, string nouvNoArrivee, int nouvNoLiaison)
        {
            this.nomPortDepart = nouvNoDepart;
            this.nomPortArrivee = nouvNoArrivee;
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