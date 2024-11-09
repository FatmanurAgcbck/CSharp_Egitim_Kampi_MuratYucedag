using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD --> Create-Read-Update-Delete


            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=NUR;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Kategori Başarıyla Eklendi!");


            #endregion

            #region Ürün Ekleme İşlemi 

            //string productName;
            //decimal productPrice;
            ////bool productStatus;


            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NUR;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)", connection); //@p1 @p2 @p3 yerine @productName @productPrice @productStatus de yazılabilir
            //command.Parameters.AddWithValue("@p1", productName); //"@productName"
            //command.Parameters.AddWithValue("@p2", productPrice); //"@productPrice"
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=NUR;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine()); ;

            //SqlConnection connection = new SqlConnection("Data Source=NUR;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");
            #endregion




            #region Ürün Güncelleme

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NUR;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Yapıldı");
            #endregion

            Console.Read();

        }
    }
}
