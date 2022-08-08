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
                                BankaModel banka = new BankaModel();

                                banka.BANKA_ID = reader.GetInt32(0);
                                banka.BANKA_IBAN_NO = reader.GetString(1);
                                banka.BANKA_HESAP_ISIM = reader.GetString(2);
                                banka.BANKA_IL = reader.GetString(3);
                                banka.BANKA_TELEFON = reader.GetString(4);
                                banka.BANKA_YEKILI_ADI = reader.GetInt32(5);

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
