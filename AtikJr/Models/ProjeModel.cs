namespace AtikJr.Models
{
    public class ProjeModel
    {
        /// <summary>
        /// Projenin sıra numarası
        /// </summary>
        public int PROJE_ID { get; set; }

        /// <summary>
        /// Projenin adı
        /// </summary>
        public string PROJE_ADI { get; set; }

        /// <summary>
        /// Projeyi yöneten kişi
        /// </summary>
        public string PROJE_SORUMLUSU { get; set; }

        /// <summary>
        /// Projede çalışan sayısı
        /// </summary>
        public int PROJE_CALISAN_SAYISI { get; set; }

        /// <summary>
        /// Projenin teslim tarihi
        /// </summary>
        public DateTime PROJE_TESLIM_TARIHI { get; set; }

        /// <summary>
        /// Proje maliyeti
        /// </summary>
        public float PROJE_MALIYET { get; set; }


    }
}
