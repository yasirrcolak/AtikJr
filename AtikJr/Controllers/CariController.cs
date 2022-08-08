using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class CariController : Controller
    {
        public IActionResult Index()
        {
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
