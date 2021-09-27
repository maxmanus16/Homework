using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Math
    {
        public void Toplama(double sayi1, double sayi2)
        {
            double Ans = sayi1 + sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Cikartma(double sayi1, double sayi2)
        {
            double Ans = sayi1 - sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Bolme(double sayi1, double sayi2)
        {
            double Ans = sayi1 / sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Carpma(double sayi1, double sayi2)
        {
            double Ans = sayi1 * sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
    }
}
