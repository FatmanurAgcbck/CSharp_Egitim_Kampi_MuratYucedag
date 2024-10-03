using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya"); --imleci bir alt satıra atar eklenen başka yazı bir alt satırda yazar
            //Console.Write("Selam"); -- imleci satır sonuna atar yazdırılacak başka yazı bitişiğine yazdırır

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            //variable değişken 
            #region String Değişkenler 


            /*isimlendirme standartları
            camelCase => customerName
            PascalCasing => CustomerName
            
                */

            //int -- tam sayı türündeki değişkenler
            //string -- "" arasına yazılır yazılanlar kelime sayılır. karakter sayı kelime vs de yazılabilir
            //boolean --true false değerlers
            //double -- ondalıklı sayılar
            //char --karakter

            // değişken_türü değişken_adı;
            //string name;
            //name = "Nur";
            //Console.WriteLine(name); //tırnak içinde yazılırsa ekrana name yazar tırnak içinde yazılmadığında Nur olarak yazar

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadiköy";
            //city = "İstanbul";


            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone );
            //Console.WriteLine("Email Adresi: " + customerEmail );
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine();

            ////customerName = "Ayşegül";
            ////Console.WriteLine(customerName); // hiyerarşik atama sıralaması var yukarıdan aşağıya doğru okuma yapar bu şekilde çağırdığımız zaman ilk Ali yi sonra Ayşegülü yazacaktır


            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");







            #endregion


            #region İnt Değişkenler

            ////int number = 24;
            ////Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***** Restoran Menü Fiyatı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger:  " + hamburgerPrice + " TL");
            //Console.WriteLine("-----Pizza:  " + pizzaPrice + " TL");
            //Console.WriteLine("-----Kola:  " + cokePrice + " TL");
            //Console.WriteLine("-----Limonata:  " + lemonadePrice + " TL");
            //Console.WriteLine("-----Kızartma:  " + friesPrice + " TL");
            //Console.WriteLine("-----Su:  " + waterPrice + " TL");
            //Console.WriteLine("***** Restoran Menü Fiyatı *****");
            //Console.WriteLine();


            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice = 0;
            //int totalCokePrice = 0;
            //int totalWaterPrice = 0;
            //int totalFriesPrice = 0;
            //int totalPizzaPrice = 0;
            //int totalLemonadePrice = 0;
            //int totalPrice = 0;


            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //totalPrice = totalWaterPrice + totalLemonadePrice + totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice;


            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");



            #endregion


            




            Console.Read(); //enter tuşuna basana kadar ekrana yazdırılanların açık kalmasını sağlar
        }
    }
}
