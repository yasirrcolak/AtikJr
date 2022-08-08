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
            return View();
        }

        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public List<AracModel> aracListesi = new List<AracModel>();

        /// <summary>
        /// Veritabanından tüm araç kayıtlarını getirir.
        /// </summary>
        public void AracGetir()
        {

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
