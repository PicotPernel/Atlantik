using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik
{
    public class Traversee
    {
        private int noTraversee;
        private DateTime heure;
        private string nomBateau;
        public Traversee(int nouvNoTraversee, DateTime nouvHeure, string nouvNomBateau)
        {
            noTraversee = nouvNoTraversee;
            heure = nouvHeure;
            nomBateau = nouvNomBateau;
        }
        public int GetNoTraversee()
        {
            return noTraversee;
        }
        public string GetHeure()
        {
            return heure.ToString("HH:mm");
        }
        public string GetNomBateau()
        {
            return nomBateau;
        }
    }
}
