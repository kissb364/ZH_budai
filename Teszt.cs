using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alakzat;

namespace Geometria
{
    internal class Teszt
    {
        private static List<IAlakzat> lista = new List<IAlakzat>();
        public static void Kiir(IAlakzat alakzat)
        {
            string alak = (alakzat is Alakzat.Negyzet)? "Négyzet" : "Kör" ;
            Console.WriteLine($"{alak} területe: {alakzat.Terulet()}");
            Console.WriteLine($"{alak} kerülete: {alakzat.Kerulet()}");
            Console.WriteLine($"{alak} oldalainak száma: {alakzat.OldalSzam}");
        }
        static void Main(string[] args)
        {
            Negyzet n1 = new Negyzet();
            lista.Add( n1 );

            Negyzet n2 = new Negyzet(2.5);
            lista.Add(n2);

            Kor k1 = new Kor();
            lista.Add(k1);

            Kor k2 = new Kor(2);
            lista.Add(k2);

            foreach (var item in lista) 
            { 
                Kiir(item); 
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
