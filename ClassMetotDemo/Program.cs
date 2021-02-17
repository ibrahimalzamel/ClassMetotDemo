using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri(); 
            musteriManager.Add(musteri); 
        }
    }
}
