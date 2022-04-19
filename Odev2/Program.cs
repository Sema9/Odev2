using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class Çağırma
            Urun urun1 = new Urun();
            urun1.Cinsiyet = "Kadın";
            urun1.Marka = "Zara";
            urun1.Kategori = "Gömlek";
            urun1.Beden = "S";
            urun1.Fiyat = 499.99;

            Urun urun2 = new Urun();
            urun2.Cinsiyet = "Kadın";
            urun2.Marka = "Mango";
            urun2.Kategori = "Etek";
            urun2.Beden = "XL";
            urun2.Fiyat = 700;

            Urun urun3 = new Urun();
            urun3.Cinsiyet = "Erkek";
            urun3.Marka = "Mavi";
            urun3.Kategori = "Gömlek";
            urun3.Beden = "L";
            urun3.Fiyat = 599.98;

            Urun[] urunler = new Urun[]
            {
                urun1,
                urun2,
                urun3
            };

            /*
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Cinsiyet + " " + urun.Marka + " " + urun.Kategori + " " + urun.Beden + " Beden " + urun.Fiyat + " TL ");
            }
            */

            /*
            for (int i = 0; i < urunler.Length; i++)
            {
               
                Console.WriteLine(urunler[i].Cinsiyet + " " + urunler[i].Marka + " " + urunler[i].Kategori + " " + urunler[i].Beden + " Beden " + urunler[i].Fiyat + " TL ");
            }
            */

            
           int i = 0;
           while(i<=urunler.Length)
            {
                Console.WriteLine(urunler[i].Cinsiyet /*+ " " + urunler[i].Marka + " " + urunler[i].Kategori + " " + urunler[i].Beden + " Beden " + urunler[i].Fiyat + " TL "*/);
                i++;
            }
            

            Console.ReadLine();

        }
        class Urun
        {
            public string Cinsiyet { get; set; }    
            public string Marka { get; set; }
            public string Kategori { get; set; }
            public string Beden { get; set; }   
            public  double Fiyat { get; set; } 
        }
    }
}
