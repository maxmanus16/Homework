﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basit Hesap Makineme Hoş Geldniz!");
            string islem;
           
            Math math = new Math();

            int sayi1, sayi2;
            Console.WriteLine("İşlem yapmak istediğiniz ilk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem yapmak istediğiniz ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğinzi işlemi seçiniz (*, /, +, -)");
            islem = Console.ReadLine();


            if (islem == "*")
            {
               math.Carpma(sayi1, sayi2);
            }
            else if (islem =="/")
            {
                math.Bolme(sayi1, sayi2);
            }
            else if (islem == "+")
            {
                math.Toplama(sayi1, sayi2);
            }
            else if (islem == "-")
            {
                math.Cikartma(sayi1, sayi2);
            }
        }
    }
}
