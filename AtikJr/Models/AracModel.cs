namespace AtikJr.Models
{
    public class AracModel
    {
        /// <summary>
        /// araç kullanım tarihi
        /// </summary>
        public DateTime REC_DATE { get; set; }

        /// <summary>
        /// araç kullanıcı adı soyadı
        /// </summary>
        public string REC_UPUSERNAME {get; set; }

        /// <summary>
        /// araç plakası
        /// </summary>
        public string ARAC_PLAKA { get; set; }

        /// <summary>
        /// araç modeli
        /// </summary>
        public string ARAC_MODEL{ get; set; }

        /// <summary>
        /// araç markası
        /// </summary>
        public string ARAC_MARKA { get; set; }

        
    }
}
