using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1 = 15;
            double sayi2 = 4;
            DortISlem dortISlem = new DortISlem();
            Console.WriteLine("Toplamı: {0}", dortISlem.Topla(sayi1, sayi2));
            Console.WriteLine("Farkı: {0}", dortISlem.Cıkar(sayi1, sayi2));
            Console.WriteLine("Bölümü: {0}", dortISlem.Bol(sayi1, sayi2));
            Console.WriteLine("Çarpımı: {0}", dortISlem.Carp(sayi1, sayi2));

        }
    }
    class DortISlem
    {
        public double Topla (double s1,double s2)
        {
            return (s1 + s2);
        }
        public double Cıkar(double s1, double s2)
        {
            return (s1 - s2);
        }
        public double Bol(double s1, double s2)
        {
            return (s1 / s2);
        }
        public double Carp(double s1, double s2)
        {
            return (s1 * s2);
        }


    }
}
