using System;
using System.Collections.Generic;

namespace HomeworkMyList
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyList<string> sehirler2 = new MyList<string>();
            //sehirler2.Add("İstanbul");
            //sehirler2.Add("Sinop");
            //sehirler2.Add("İstanbul");
            //Console.WriteLine(sehirler2.Count);



            Dictionary<int, string> Ogrenci = new Dictionary<int,string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            Console.Write("Öğrenci No Giriniz:");

            int No = int.Parse(Console.ReadLine());
            string isim = " ";
            if (Ogrenci.TryGetValue(No, out isim))
                Console.WriteLine(isim);
            else
                Console.WriteLine("Öğrenci Bulunamadı.");
        }
    }

    class MyList<T>
    {
        T[] _array; //datanın kendisi
        T[] _tempArray;//geçici array


        public MyList()//new lediğimizde çalışır
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i=0; i<_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;//0dan başladığı için -1 veririz
        }
         
        public int Count
        {
            get { return _array.Length; } 
        }


    }
}
