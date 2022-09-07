using System;

namespace Donguler_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den başlayarak console'dan girilen sayıya kadar sayı dahil ortalama hesaplayıp console yazdıran program
            Console.Write("Lütfen bir sayi giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //A'dan Z'ye kadar tüm harfleri yazdır
            char karakter='a';
            while(karakter<'z')
            {
                Console.Write(karakter);
                karakter++;
            }

            Console.Write("***** FOREACH *****");
            string[] arabalar={"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
