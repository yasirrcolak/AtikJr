namespace AtikJr.Models
{
    public class MuhasebeModel
    {
        /// <summary>
        /// muhasebe işlem sırası
       /// </summary>
        public int MUHASEBE_ID { get; set; }

        /// <summary>
        /// 
        /// </summhesap ismiary>
        public string MUHASEBE_HESAP_ADI { get; set; }

        /// <summary>
        /// hesap türü açıklama (bireysel, kurumsal vb)
        /// </summary>
        public string MUHASEBE_HESAP_TURU { get; set; }

        /// <summary>
        /// borç miktarı
        /// </summary>
        public float MUHASEBE_TOPLAM_BORC { get; set; }

        /// <summary>
        /// muhasebe işlem tarihi
        /// </summary>
        public DateTime MUHASEBE_TARIH { get; set; }

        /// <summary>
        /// kontrol etmek için kullanılan kod
        /// </summary>
        public int MUHASEBE_KONTROL_KODU { get; set; }













    }
}
