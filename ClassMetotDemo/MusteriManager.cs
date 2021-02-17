using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

         List<Musteri> musteris = new List<Musteri>();
        public void Add(Musteri musteri)
        {
            musteris.Add(musteri);
        }
        public void Listele()
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("Musteri ID : " + musteri.ID);
                Console.WriteLine("Musteri Adi: " + musteri.Name);
                Console.WriteLine("Musteri Soyadi : " + musteri.LastName);
                Console.WriteLine("Musteri Tel : " + musteri.TelNamber);
                Console.WriteLine("Musteri Address : " + musteri.Address);
                Console.WriteLine("--------------------------------");
            }
        }
        public void Delet(Musteri musteri1)
        {
            musteris.Remove(musteri1);
            Console.WriteLine("=============== Musteri " + musteri1.Name + " Deleted =================");
        }
    }
}
