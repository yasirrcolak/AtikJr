using System.Data.SqlClient;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class KasaController : Controller
    {
        public IActionResult Index()
        {
            KasaGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<KasaModel> kasaListesi = new List<KasaModel>();

        /// <summary>
        /// Veritabanından tüm araç kayıtlarını getirir.
        /// </summary>
        public void KasaGetir()
        {
            try
            {
                String connectionString = "connection string......";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlQuery = "Select asdasdasds.......";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                KasaModel kasa = new KasaModel();

                                kasa.KASA_ID = reader.GetInt32(0);
                                kasa.ODEME_TIPI = reader.GetString(1);
                                kasa.KULLANICI_ADI = reader.GetString(2);
                                kasa.KASA_TARIH = reader.GetDateTime(3);
                                kasa.SUBE_KODU = reader.GetInt32(4);
                                kasa.KASA_KODU = reader.GetInt32(5);

                                kasaListesi.Add(kasa);
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
        /// Veritabanında kasa tablosuna bir kayıt ekler.
        /// </summary>
        public void KasaKaydet()
        {

        }

        /// <summary>
        /// Veritabanında kasa tablosundan bir kayıt siler.
        /// </summary>
        public void KasaSil()
        {

        }

        /// <summary>
        /// Veritabanında kasa tablosundan bir kaydı günceller.
        /// </summary>
        public void KasaGuncelle()
        {

        }
    }
}
