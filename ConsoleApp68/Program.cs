using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyekullaniciadisifre
{
    class Program
    {
        static void Main(string[] args)
        {

            string kul_adi = "aaa";
            string sifre = "12345";

            Console.WriteLine("Lütfen kullanıcı adınızı girin");
            string kullaniciadi = Console.ReadLine();

            Console.WriteLine("Lütfen kullanıcı şifrenizi girin");
            string kullanici_sifre = Console.ReadLine();

            if (kullaniciadi == kul_adi && kullanici_sifre == sifre)
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış");
            }

            Console.ReadLine();
        }
    }
}