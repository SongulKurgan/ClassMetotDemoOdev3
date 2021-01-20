using System;

namespace ClassMetotDemoOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TC = 9473820173;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Al";
            musteri1.Yas = 54;
            musteri1.Sehir = "Ankara";
            musteri1.KrediAlıyorMu = "Evet";

            Musteri musteri2 = new Musteri();
            musteri2.TC = 3293730271;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Gül";
            musteri2.Yas = 34;
            musteri2.Sehir = "İzmir";
            musteri2.KrediAlıyorMu = "Hayır";

            Musteri musteri3 = new Musteri();
            musteri3.TC = 28363829173;
            musteri3.Adi = "Leyla";
            musteri3.Soyadi = "Baş";
            musteri3.Yas = 19;
            musteri3.Sehir = "Diyarbakır";
            musteri3.KrediAlıyorMu = "Evet";

            Musteri musteri4 = new Musteri();
            musteri4.TC = 84625184034;
            musteri4.Adi = "Mehmet";
            musteri4.Soyadi = "Gül";
            musteri4.Yas = 39;
            musteri4.Sehir = "İstanbul";
            musteri4.KrediAlıyorMu = "Evet";


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            Console.WriteLine("*******************Kredi Almayanı Sil**********************");
            musterimanager.Sil(musteri2);
            Console.WriteLine("****************Kredi Alanları Listele*********************");
            musterimanager.Listele(musteri4);
            Console.WriteLine("\n");
            musterimanager.Listele(musteri4);
            Console.WriteLine("\n");
            musterimanager.Listele(musteri4);

        }
    }
}
