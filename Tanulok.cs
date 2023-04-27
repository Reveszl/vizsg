using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace Iskola1
{
    public class Tanulok
    {
        public int ev { get; private set; }
        public string osztaly { get; private set; }
        public string nev { get; private set; }

        public Tanulok(string tanulok)
        {
            string[] diak = tanulok.Split(';');
            this.ev = Convert.ToInt32(diak[0]);
            this.osztaly = diak[1];
            this.nev = diak[2];
        }

        public static string Kod(int ev, string osztaly, string nev)
        {
            return (ev.ToString().Last()+ osztaly +nev.Substring(0,3)+nev.Split(' ')[1].Substring(0,3)).ToLower();
        }
    }
}
