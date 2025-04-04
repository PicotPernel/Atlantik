using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Client
    {
        private int noCLient;
        private string nom;
        private string prenom;
        public Client(int nouvNoCLient, string nouvNom, string nouvPrenom)
        {
            noCLient = nouvNoCLient;
            nom = nouvNom;
            prenom = nouvPrenom;
        }
        public int GetNoClient()
        {
            return noCLient;
        }
        public override string ToString()
        {
            return nom + ", " + prenom;
        }
    }
}
