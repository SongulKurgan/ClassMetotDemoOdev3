using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoOdev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + "\n" + musteri.Adi + "\n" + musteri.Soyadi + "\n" + musteri.Yas + "\n" + musteri.Sehir + "\n" + musteri.KrediAlıyorMu + "\n" + "SİSTEME EKLENDİ");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + "\n" + musteri.Adi + "\n" + musteri.Soyadi + "\n" + musteri.Yas + "\n" + musteri.Sehir + "\n" + musteri.KrediAlıyorMu + "\n" + "SİSTEMDEN SİLİNDİ");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + "\n" + musteri.Adi + "\n" + musteri.Soyadi + "\n" + musteri.Yas + "\n" + musteri.Sehir + "\n" + musteri.KrediAlıyorMu);

        }
    }
}
