using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodfoku
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
        }
        public static string MfEgyenlet(double a, double b, double c)
        {
            if (a == 0) throw new Exception("Nem másodfokú!");
            else
            {
                double diszkr = b * b - 4 * a * c;
                if (diszkr < 0) return "Nincs valós gyök!";
                else
                {
                    double x1 = (-b + Math.Sqrt(diszkr)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(diszkr)) / (2 * a);
                    return x1.ToString("0.00") + ' ' + x2.ToString("0.00");
                }
            }
        }
    }
}
