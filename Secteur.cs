using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Secteur
    {
        private int noSecteur;
        private string nom;
        public Secteur(int nouvNoSecteur, string nouvNom)
        { 
            this.noSecteur = nouvNoSecteur;
            this.nom = nouvNom;
        }
        public int GetNoSecteur()
        {
            return noSecteur;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
