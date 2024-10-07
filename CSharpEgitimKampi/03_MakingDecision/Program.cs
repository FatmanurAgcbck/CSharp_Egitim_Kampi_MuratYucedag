using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")    //ampersand (ve) sembolü and olarak kullanmak için iki tane koymak gerekiyordu yeni sürümlerde değişti 
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı Bilgi");

            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //} 



            //int exam1, exam2, exam3, average;
            //string result = "Hata!"; //ilk değer ataması yapıldı

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);  //result a değer ataması yapılması gerekir ya else içinde ya da ilk değer ataması yapılmalı (0165 hatası)


            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}



            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");

            //}
            //else

            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}


            #endregion

            #region Mod İşlemleri


            //int number;
            //number = 6;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());    

            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("Birinci Sayının İkinci Sayıya Bölümünden Kalan: " + result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembölünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("BEŞİKTAŞ");
            //}
            //else 
            //{
            //    Console.WriteLine("Hatalı Karakter");
            //}




            #endregion

            #region Menü Projesi 

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();



            //string menuItem;
            //Console.WriteLine("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();


            //if (menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("4-Patlıcan Musakka");
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------ Çorbalar ------------");


            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar ------------");


            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------ İçecekler ------------");


            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------ Tatlılar ------------");


            //    Console.WriteLine();

            //}








            #endregion

            #region Switch-Case

            //switch kod bloğunun anahtar kısmı 
            //case anahtarın durumları

            //Console.Write("Lütfen Ay Girişi Yapın: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("OCAK"); break;
            //    case 2: Console.WriteLine("ŞUBAT"); break;
            //    case 3: Console.WriteLine("MART"); break;
            //    case 4: Console.WriteLine("NİSAN"); break;
            //    case 5: Console.WriteLine("MAYIS"); break;
            //    case 6: Console.WriteLine("HAZİRAN"); break;
            //    case 7: Console.WriteLine("TEMMUZ"); break;
            //    case 8: Console.WriteLine("AĞUSTOS"); break;
            //    case 9: Console.WriteLine("EYLÜL"); break;
            //    case 10: Console.WriteLine("EKİM"); break;
            //    case 11: Console.WriteLine("KASIM"); break;
            //    case 12: Console.WriteLine("ARALIK"); break;
            //    default: Console.WriteLine("HATALI GİRİŞ"); break;

            //}



            #endregion

            #region Hesap Makinesi (switch-case)

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçin");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);

            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
                

            //}


            #endregion

            Console.Read();
        }
    }
}
