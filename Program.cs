using System;
using System.Collections.Generic;

namespace koleksiyonlar_genericlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar generic list
            //List<T> class
            //System.Collections.Generic
            //T=> object türündedir
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(25);
            sayiListesi.Add(20);
            sayiListesi.Add(10);
            sayiListesi.Add(41);
            sayiListesi.Add(47);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Mavi");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Pembe");
            renkListesi.Add("Siyah");
            renkListesi.Add("Beyaz");

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //foreach ve list foreach ile liste elemanlarını yazdırma
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste elemanlarını silme
            sayiListesi.Remove(20);
            renkListesi.Remove("Kırmızı");

            sayiListesi.RemoveAt(3);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(41))
            {
                Console.WriteLine("Sayı listesinde 41 elemanı bulundu");
            }

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Siyah"));

            //Diziyi List e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "İnek", "At" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?

            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Name = "Elvan";
            kullanici1.Surname = "Tektaş";
            kullanici1.Age = 25;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Name = "Zeynep";
            kullanici2.Surname = "Tektaş";
            kullanici2.Age = 13;

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Name = "Ali",
                Surname = "Tektaş",
                Age = 27

            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Name);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Surname);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Age);
            }

            yeniListe.Clear();
        }
    }
    public class Kullanıcılar
    {
        private string name;
        private string surname;
        private int age;

        public int Age { get => age; set => age = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
    }
}
