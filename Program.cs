using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
namespace GenericList{
    class Program{
        public static void Main(string[] args){
            List <int> sayiList = new List<int>();
            sayiList.Add(12);
            sayiList.Add(14);
            sayiList.Add(18);
            sayiList.Add(42);
            sayiList.Add(182);
            List <string> renkList = new List<string>();

            renkList.Add("Mavi");
            renkList.Add("Sari");
            renkList.Add("Mor");

            Console.WriteLine(renkList.Count);
            Console.WriteLine(sayiList.Count);

            foreach(var sayi in sayiList){
                Console.WriteLine(sayi.ToString());
            }
            foreach(var renk in renkList){
                Console.WriteLine(renk);
            }

            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(sayi => Console.WriteLine(sayi));

            //listeden eleman cikarma

            sayiList.Remove(4);
            renkList.Remove("Yesil");

            sayiList.RemoveAt(0);
            renkList.RemoveAt(1);

            //Listede arama

            if(sayiList.Contains(10)){
                Console.WriteLine("Listede bulundu!");
            }

            //elemen ile index'e erisme

            renkList.BinarySearch("Sari");


            //Diziyi listeye cevirme

            string[] hayvanlar = {"Kedi","Kopek","Kus"};

            List<string> hayvanlarList = new List<string>(hayvanlar);
            hayvanlarList.Clear();


            //liste icersinde nesne tutma

            List<Kullanicalar> kullanicalarList = new List<Kullanicalar>();
            Kullanicalar kullanicalar1 = new Kullanicalar();
            kullanicalar1.Isim="yalcin";
            kullanicalar1.SoyIsim = "mrl";
            kullanicalar1.Yas = 26;

            kullanicalarList.Add(kullanicalar1);


            foreach(var kullanici in kullanicalarList){
                Console.WriteLine(kullanici.Isim);
            }

        }
    }
    public class Kullanicalar{
                string isim;
                string soyisim;
                int yas;

                public string Isim{
                    get=>isim;
                    set =>isim=value;
                }
                public string SoyIsim{
                    get{
                        return soyisim;
                    }
                    set{
                        soyisim = value;
                    }
                }
                public int Yas{get=>yas;set=>yas=value;}

            }
}