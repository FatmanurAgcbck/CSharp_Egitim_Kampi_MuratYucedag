using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net --> SQL yapılarını kullanabilmemizi olanak sağlayan çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------");




            SqlConnection connection = new SqlConnection("Data Source=NUR;initial Catalog=EgitimKampiDb;integrated security=true"); //bağlantı oluşturma
            connection.Open(); //bağlantıyı açma
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //sorguyu yazdırırız 
            SqlDataAdapter adapter = new SqlDataAdapter(command); //c# tarafındaki kodlarla sql sunucu arasıdan köprü görevi görür
            DataTable dataTable = new DataTable(); //verileri geçici belleğe alır
            adapter.Fill(dataTable); 
            connection.Close();


            foreach(DataRow row in dataTable.Rows)   //DataRow --> DataTable dan gelen bir sınıf türü
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

            }



            Console.Read();
        }
    }
}
