using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class StokController : Controller
    {
        public IActionResult Index()
        {
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

        }

        /// <summary>
        /// Veritabanında stok tablosuna bir kayıt ekler.
        /// </summary>
        public void StokKaydet()
        {

        }



        /// <summary>
        /// Veritabanında stok tablosundan bir kayıt siler.
        /// </summary>
        public void StokSil()
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
