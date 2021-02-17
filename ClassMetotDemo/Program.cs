using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.ID = 10001;
            musteri1.Name = "ibrahim";
            musteri1.LastName = "alzamel";
            musteri1.TelNamber = "5522452556";
            musteri1.Address = "meram/konya";
            musteriManager.Add(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.ID = 10002;
            musteri2.Name = "abdullah";
            musteri2.LastName = "alikaj";
            musteri2.TelNamber = "5352452363";
            musteri2.Address = "karatay/konya";
            musteriManager.Add(musteri2);

            Musteri musteri3 = new Musteri();
            musteri3.ID = 10003;
            musteri3.Name = "bashir";
            musteri3.LastName = "manafihi";
            musteri3.TelNamber = "5352486563";
            musteri3.Address = "selcuklu/konya";
            musteriManager.Add(musteri3);
            musteriManager.Listele();
            musteriManager.Delet(musteri1);
            musteriManager.Listele();
        }
    }
}
