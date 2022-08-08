using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class BesiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public List<BesiModel> besiListesi = new List<BesiModel>();

        /// <summary>
        /// Veritabanından tüm besi kayıtlarını getirir.
        /// </summary>
        public void BesiGetir()
        {

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
