using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alakzat
{
    public interface IAlakzat
    {
        int OldalSzam { get; }
        double Terulet();
        double Kerulet();
    }
    public class Negyzet:IAlakzat
    {
        public int OldalSzam { get { return 4; } }
        private double OldalHossz { get; set; }
        public Negyzet()
        {
            OldalHossz = 1.0;
        }
        public Negyzet(double oldalHossz)
        {
            OldalHossz = oldalHossz;
        }
        public double Kerulet()
        {
            return OldalHossz * OldalSzam;
        }
        public double Terulet()
        {
            return OldalHossz * OldalHossz;
        }
        
    }
}
