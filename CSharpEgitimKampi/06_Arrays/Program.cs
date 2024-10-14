using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            // 2 4 6 8 ... çift sayılar bir dizidir
            //mor sarı kırmızı mavi turuncu renkler bir dizidir
            //İstanbul Ankara Adana Bursa şehirler bir dizidir
            //indexler 0 dan başlar 
            //DeğişkenTürü [] diziAdı = new DeğişkenTürü[elemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";       //colors dizisinin 0. indexindeki elemanı kırmızı olarak eklenir 
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]); //colors dizisinin 2 numaralı indexindeki değeri yazdırır

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lİon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";


            //Console.WriteLine(cities[4]);
            //dizi boyutunu geçerse hata veriri

            //int[] numbers = new int[10]; 

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]); //dizinin boyutunda olup ama dizinin içinde tanımlı olmayan eleman çağırıldığında 0 değerini döndürür. Tam sayı formatında bir dizi tanımlanıldığı zaman index e değer ataması yapılmazsa o indexin default değeri 0 olur

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) //-> colors.Length dizinin uzunluğunu belirtir
            //{

            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0]; //dizinin 0.indexindeki sayının en büyük değeri olarak atadık

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber) //dizideki değerlerden biri atadığımız değerden büyük ise
            //    {
            //        maxNumber = myArray[i]; //oluşturduğumuz değişkene dizinin i. elemanını atar
            //    }
            //}
            //Console.WriteLine(maxNumber);


            #endregion

            #region Dizi Metotları

            //LENGTH --> dizinin uzunluğunu yazdırır
            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);  

            //SORT --> küçükten büyüğe doğru sıralar
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); 

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //REVERSE --> diziyi tersen sıralar 35, 22 ,10 ... şeklinde
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); 

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //INDEXOF --> kaçıncı indexte olduğunu yazdırır
            //string[] customers = { "Ali", "Ayşe", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve"); 
            //Console.WriteLine(index); 


            //MAX-MIN --> dizinin en büyük ve en küçük elemanını yazdırır
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " +  numbers.Min()); 




            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion



            Console.Read();

        }
    }
}
