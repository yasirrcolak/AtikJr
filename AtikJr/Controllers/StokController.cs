using System.Data.SqlClient;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class StokController : Controller
    {
        public IActionResult Index()
        {
            StokGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<StokModel> stokListesi = new List<StokModel>();

        /// <summary>
        /// Veritabanından tüm stok kayıtlarını getirir.
        /// </summary>
        public void StokGetir()
        {
            try
            {
                String connectionString = Models.SQLqueries.ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlQuery = Models.SQLqueries.tumStoklar;

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StokModel stok = new StokModel();

                                stok.STOK_ID = reader.GetInt32(0);
                                /*
                                stok.STOK_KATEGORİ = reader.GetString(1);
                                stok.STOK_MARKA_ = reader.GetString(2);
                                stok.STOK_URUN_ADI = reader.GetString(3);
                                stok.STOK_TARIH = reader.GetDateTime(4);
                                stok.STOK_MİKTAR = reader.GetInt32(5);
                                */
                                stokListesi.Add(stok);
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
        /// Veritabanında stok tablosuna bir kayıt ekler.
        /// </summary>
        public void StokKaydet(int id, string stokadi)
        {
            string sorgu = "INSERT INTO `kullanici`(`kullanici_id`, `kullanici_adi`, `sifre`, `tip`) VALUES ('" + id.ToString() + "','[value-2]','[value-3]','[value-4]')";
        }



        /// <summary>
        /// Veritabanında stok tablosundan bir kayıt siler.
        /// </summary>
        public void StokSil(int id)
        {

        }

        /// <summary>
        /// Veritabanında stok tablosundan bir kaydı günceller.
        /// </summary>
        public void StokGuncelle()
        {

        }
    }
}
