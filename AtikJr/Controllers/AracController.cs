using System.Data.SqlClient;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class AracController : Controller
    {
        /// <summary>
        /// Arac sayfasını döndürür.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            AracGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<AracModel> aracListesi = new List<AracModel>();

        /// <summary>
        /// Veritabanından tüm araç kayıtlarını getirir.
        /// </summary>
        public void AracGetir()
        {
            try
            {
                String connectionString = Models.SQLqueries.ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlQuery = Models.SQLqueries.tumAraclar;

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AracModel arac = new AracModel();

                                arac.REC_DATE = reader.GetDateTime(0);
                                arac.REC_UPUSERNAME = reader.GetString(1);
                                arac.ARAC_PLAKA = reader.GetString(2);
                                arac.ARAC_MODEL = reader.GetString(3);
                                arac.ARAC_MARKA = reader.GetString(4);
                              

                                aracListesi.Add(arac);
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
        /// Veritabanında araç tablosuna bir kayıt ekler.
        /// </summary>
        public void AracKaydet()
        {
            
        }

        /// <summary>
        /// Veritabanında araç tablosundan bir kayıt siler.
        /// </summary>
        public void AracSil()
        {

        }

        /// <summary>
        /// Veritabanında araç tablosundan bir kaydı günceller.
        /// </summary>
        public void AracGuncelle()
        {

        }


    }
}
