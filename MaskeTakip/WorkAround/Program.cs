﻿using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();

            SelamVer("Hakan");
            SelamVer("Ayşe");
            SelamVer();
            int sonuc = Topla(3,5);

            //Diziler- Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Fatma";
            ogrenciler[1] = "Mahmut";
            ogrenciler[2] = "Özge";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            
            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add("Eskişehir");

            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Hakan";
            person1.LastName = "Ocak";
            person1.DateofBirthYear = 1988;
            person1.NationalIdentity = 12345678910;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000.5;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Hakan";
            string soyad = "Ocak";
            int dogumYili = 1988;
            long tcNo = 12345678910;
            Console.WriteLine(10000 * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
