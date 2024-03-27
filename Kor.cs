using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alakzat
{
    public class Kor : IAlakzat
    {
        public int OldalSzam { get { return 0; } }
        private double Sugar { get; set; }
        public Kor()
        {
            Sugar = 1.0;
        }
        public Kor(double sugar)
        {
            Sugar = sugar;
        }
        public double Kerulet()
        {
            return 2 * Sugar * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(Sugar, 2) * Math.PI;
        }
    }
}
