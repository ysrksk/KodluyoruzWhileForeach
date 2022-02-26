using System;

namespace whileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While

            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortolama hesaplayıp comsole yazdıran program.
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi)
            {
                toplam += sayac;
                ++ sayac;
            }
            System.Console.WriteLine(toplam/sayi);

            // 'a' dan '' ye kadar tüm harrfleri console e yazdır

            char character = 'a';
            while(character <'z');
            {
                System.Console.WriteLine(character);
                character ++;
            }

            System.Console.WriteLine("**** Foreach *****");

            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}
