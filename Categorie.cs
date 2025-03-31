using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Categorie
    {
        private string lettreCategorie;
        private string libelle;
        public Categorie(string nouvLettreCategorie, string nouvLibelle)
        {
            lettreCategorie = nouvLettreCategorie;
            libelle = nouvLibelle;
        }
        public string GetLettreCategorie()
        {
            return lettreCategorie;
        }
        public override string ToString()
        {
            return lettreCategorie + " " + libelle;
        }
    }
}
