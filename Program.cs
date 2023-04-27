using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Iskola1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //beolvasás

            List<Tanulok> lista = new List<Tanulok>();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Tanulok a = new Tanulok(sor);
                lista.Add(a);
            }

            //3. feladat
            Console.WriteLine("3. feladat:");

            int db = 0;
            foreach (var item in lista)
            {
                Console.WriteLine(item.ev + " " + item.osztaly + " " + item.nev);
                db++;
            }

            Console.WriteLine("Az iskolába " + db + " tanuló jár");

            //4. feladat
            Console.WriteLine("4. feladat:");

            db = 0;
            foreach (var item in lista)
            {
                db++;
                if (db == 1)
                {
                    Console.WriteLine(item.nev + "\t" + Tanulok.Kod(item.ev, item.osztaly, item.nev));
                }
                else if (db == 650)
                {
                    Console.WriteLine(item.nev + "\t" + Tanulok.Kod(item.ev, item.osztaly, item.nev));
                }
            }

            //5. feladat tesztek

            //6. feladat
            Console.WriteLine("6. feladat: azonositok.txt");

            StreamWriter sw = new StreamWriter("azonositok.txt");
            foreach (var item in lista)
            {
                sw.WriteLine(item.nev + ": " + Tanulok.Kod(item.ev, item.osztaly, item.nev));
            }

            sw.Close();
            sr.Close();
            Console.ReadLine();
        }
    }
}
