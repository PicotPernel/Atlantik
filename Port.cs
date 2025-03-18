using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Port
    {
        private int noPort;
        private string nom;
        public Port (int nouvNoPort, string nouvNom)
        {
            noPort = nouvNoPort;
            nom = nouvNom;
        }
        public int GetNoPort()
        {
            return noPort;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
