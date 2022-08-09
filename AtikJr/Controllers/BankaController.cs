using System.Data.SqlClient;
using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
            BankaGetir();
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<BankaModel> bankaListesi = new List<BankaModel>();

        /// <summary>
        /// Veritabanından tüm banka kayıtlarını getirir.
        /// </summary>
        public void BankaGetir()
        {
            bankaListesi.Clear();

            try
            {
                String connectionString = Models.SQLqueries.ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sqlQuery = Models.SQLqueries.tumBankalar;

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BankaModel banka = new BankaModel();

                                banka.REC_NO = reader.GetInt32(0);
                                banka.REC_DATE = reader.GetDateTime(1);
                                banka.REC_UPUSERNAME = reader.GetString(5);
                                banka.BANKA_HESAP_KODU = reader.GetString(10);
                                banka.IBAN_NO = reader.GetString(12);
                                banka.BANKA_TELEFON = reader.GetString(29);

                                bankaListesi.Add(banka);
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
        /// Veritabanında banka tablosuna bir kayıt ekler.
        /// </summary>
        public void BankaKaydet()
        {


        }

        /// <summary>
        /// Veritabanında banka tablosundan bir kayıt siler.
        /// </summary>
        public void BankaSil()
        {

        }

        /// <summary>
        /// Veritabanında banka tablosundan bir kaydı günceller.
        /// </summary>
        public void BankaGuncelle()
        {

        }



    }
}
