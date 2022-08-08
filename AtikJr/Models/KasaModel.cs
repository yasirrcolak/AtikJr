namespace AtikJr.Models
{
    public class KasaModel
    {
        /// <summary>
        /// Kasa sıra numarası
        /// </summary>
        public int KASA_ID { get; set; }

        /// <summary>
        /// Ödeme tipi (TL,DOLAR vb.)
        /// </summary>
        public string ODEME_TIPI { get; set;  }

        /// <summary>
        /// Müşteri ismi
        /// </summary>
        public string KULLANICI_ADI { get; set; }

        /// <summary>
        /// İşlem Tarihi
        /// </summary>
        public DateTime KASA_TARIH { get; set; }

        /// <summary>
        /// Şube Kodu
        /// </summary>
        public int SUBE_KODU { get; set; }

        /// <summary>
        /// Kasa Kodu
        /// </summary>  
        public int KASA_KODU { get; set; }
    }
}
