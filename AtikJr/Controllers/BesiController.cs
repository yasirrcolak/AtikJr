using System.Data.SqlClient;
using System;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BesiController : Controller
    {
        public IActionResult Index()
        {
            BesiGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<BesiModel> besiListesi = new List<BesiModel>();

        /// <summary>
        /// Veritabanından tüm besi kayıtlarını getirir.
        /// </summary>
        public void BesiGetir()
        {
            try
            {
                String connectionString = "connection string......";

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlQuery = "Select asdasdasds.......";
                   
                    using (SqlCommand command = new SqlCommand(sqlQuery,connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BesiModel besi = new BesiModel();

                                besi.BESI_ID = reader.GetInt32(0);
                                besi.BESI_CINSI = reader.GetString(1);
                                besi.BESI_RENGI = reader.GetString(2);
                                besi.BESI_KILO = reader.GetInt32(3);
                                besi.BESI_DOGUM_TARIHI = reader.GetDateTime(4);
                                besi.BESI_YAS = reader.GetInt32(5);

                                besiListesi.Add(besi);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata!!! : " + ex.Message.ToString());
            }
        }

        /// <summary>
        /// Veritabanında besi tablosuna bir kayıt ekler.
        /// </summary>
        public void BesiKaydet()
        {
            
        }

        /// <summary>
        /// Veritabanında besi tablosundan bir kayıt siler.
        /// </summary>
        public void BesiSil()
        {

        }

        /// <summary>
        /// Veritabanında besi tablosundan bir kaydı günceller.
        /// </summary>
        public void BesiGuncelle()
        {

        }

    }
}
