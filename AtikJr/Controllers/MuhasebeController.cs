using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class MuhasebeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public static List<MuhasebeModel> muhasebeListesi = new List<MuhasebeModel>();

        /// <summary>
        /// Veritabanından tüm muhasebe kayıtlarını getirir.
        /// </summary>
        public void MuhasebeGetir()
        {

        }


        /// <summary>
        /// Veritabanında muhasebe tablosuna bir kayıt ekler.
        /// </summary>
        public void MuhasebeKaydet()
        {

        }



        /// <summary>
        /// Veritabanında muhasebe tablosundan bir kayıt siler.
        /// </summary>
        public void MuhasebeSil()
        {

        }

        /// <summary>
        /// Veritabanında muhasebe tablosundan bir kaydı günceller.
        /// </summary>
        public void MuhasebeGuncelle()
        {

        }
    }
}
