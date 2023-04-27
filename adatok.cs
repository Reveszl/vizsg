using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonWPF
{
    internal class adatok
    {
        public int Adoszam { get; private set; }
        public string Utca { get; private set; }
        public string Hazszam { get; private set; }
        public string Kategoria { get; set; }
        public int Terulet { get; private set; }

        public adatok(string sor)
        {
            string[] adat = sor.Split(' ');
            this.Adoszam = Convert.ToInt32(adat[0]);
            this.Utca = adat[1];
            this.Hazszam = adat[2];
            this.Kategoria = adat[3];
            this.Terulet = Convert.ToInt32(adat[4]);
        }
    }
}
