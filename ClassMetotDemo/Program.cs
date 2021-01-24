using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.Adınız = "Durmuş";
            musteri1.Soyadınız = "SAVAŞ";
            musteri1.Yaşınız = 29;
            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.Adınız = "Edanur";
            musteri2.Soyadınız = "SAVAŞ";
            musteri2.Yaşınız = 25;
            Musteri[] urunler = new Musteri[] { musteri1, musteri2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.MusteriId);
                Console.WriteLine(urun.Adınız);
                Console.WriteLine(urun.Soyadınız);
                Console.WriteLine(urun.Yaşınız);
                Console.WriteLine("--------------------");
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);


            
        }
    }
}
