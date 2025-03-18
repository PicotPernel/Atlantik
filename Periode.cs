using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Cms;

namespace Atlantik
{
    public class Periode
    {
        private int noPeriode;
        private DateTime dateDebut;
        private DateTime dateFin;
        public Periode(int nouvNoPeriode, DateTime nouvDateDebut, DateTime nouvDateFin)
        {
            noPeriode = nouvNoPeriode;
            dateDebut = nouvDateDebut;
            dateFin = nouvDateFin;
        }
        public int GetNoPeriode()
        {
            return noPeriode;
        }
        public override string ToString()
        {
            return dateDebut.ToString("dd/MM/yyyy") + " - " + dateFin.Date.ToString("dd/MM/yyyy");
        }
    }
}
