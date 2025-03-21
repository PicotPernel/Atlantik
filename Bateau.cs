using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Atlantik
{
    class Bateau
    {
        private int noBateau;
        private string nom;
        public Bateau(int nouvNoBateau, string nouvNom)
        {
            noBateau = nouvNoBateau;
            nom = nouvNom;
        }
        public int GetNoBateau()
        {
            return noBateau;
        }
        public override string ToString()
        {
            return nom;
        }
    }
}
