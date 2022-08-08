using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class KasaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public List<KasaModel> kasaListesi = new List<KasaModel>();

        /// <summary>
        /// Veritabanından tüm araç kayıtlarını getirir.
        /// </summary>
        public void KasaGetir()
        {

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
