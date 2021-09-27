using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Math
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int Ans = sayi1 + sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Cikartma(int sayi1, int sayi2)
        {
            int Ans = sayi1 - sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int Ans = sayi1 / sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int Ans = sayi1 * sayi2;
            Console.WriteLine("Cevap: " + Ans);
        }
    }
}
