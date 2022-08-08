using System.Data.SqlClient;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class CariController : Controller
    {
        public IActionResult Index()
        {
            CariGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<CariModel> cariListesi = new List<CariModel>();

        /// <summary>
        /// Veritabanından tüm cari kayıtlarını getirir.
        /// </summary>
        public void CariGetir()
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
                                CariModel cari = new CariModel();

                                cari.CARI_ID = reader.GetInt32(0);
                                cari.CARI_TARIH = reader.GetDateTime(1);
                                cari.CARI_BORC = reader.GetInt32(2);
                                cari.CARI_KOD = reader.GetInt32(3);
                                cari.CARI_ADRES = reader.GetString(4);
                                cari.CARI_TELEFON = reader.GetString(5);

                                cariListesi.Add(cari);
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
        /// Veritabanında cari tablosuna bir kayıt ekler.
        /// </summary>
        public void CariKaydet()
        {

        }

        /// <summary>
        /// Veritabanında cari tablosundan bir kayıt siler.
        /// </summary>
        public void CariSil()
        {

        }

        /// <summary>
        /// Veritabanında cari tablosundan bir kaydı günceller.
        /// </summary>
        public void CariGuncelle()
        {

        }

    }
}
