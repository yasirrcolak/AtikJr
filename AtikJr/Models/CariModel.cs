namespace AtikJr.Models
{
    public class CariModel
    {
        /// <summary>
        /// id sıra
        /// </summary>
        public int CARI_ID { get; set; }

        /// <summary>
        /// cari tarih bilgileri
        /// </summary>
        public DateTime CARI_TARIH { get; set; }

        /// <summary>
        /// cari borç tutarı
        /// </summary>
        public int CARI_BORC { get; set; }

        /// <summary>
        /// cari kodu
        /// </summary>
        public int CARI_KOD { get; set; }

        /// <summary>
        /// cari adresi bilgileri
        /// </summary>
        public string CARI_ADRES { get; set; }

        /// <summary>
        /// cari telefon numarası
        /// </summary>
        public string CARI_TELEFON { get; set; }
    }
}
