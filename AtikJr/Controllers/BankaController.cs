using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BankaController : Controller
    {
        public IActionResult Index()
        {
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
