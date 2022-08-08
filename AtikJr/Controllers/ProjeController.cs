using AtikJr.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtikJr.Controllers
{
    public class ProjeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Veritabanındaki tüm kayıtlı verileri içinde barındıran nesneleri tutan liste.
        /// </summary>
        public List<ProjeModel> projeListesi = new List<ProjeModel>();

        /// <summary>
        /// Veritabanından tüm proje kayıtlarını getirir.
        /// </summary>
        public void ProjeGetir()
        {

        }


        /// <summary>
        /// Veritabanında proje tablosuna bir kayıt ekler.
        /// </summary>
        public void ProjeKaydet()
        {

        }



        /// <summary>
        /// Veritabanında proje tablosundan bir kayıt siler.
        /// </summary>
        public void ProjeSil()
        {

        }

        /// <summary>
        /// Veritabanında proje tablosundan bir kaydı günceller.
        /// </summary>
        public void ProjeGuncelle()
        {

        }
    }
}
