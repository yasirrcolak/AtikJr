namespace AtikJr.Models
{
    public class BankaModel
    {
        /// <summary>
        /// banka kayıt numarası
        /// </summary>
        public int REC_NO { get; set; }

        /// <summary>
        /// banka kayıt tarihi
        /// </summary>
        public DateTime REC_DATE { get; set; }

        /// <summary>
        /// banka kaydeden kullanıcı ismi
        /// </summary>
        public string REC_UPUSERNAME { get; set; }

        /// <summary>
        /// Banka hesap kodu
        /// </summary>
        public string BANKA_HESAP_KODU { get; set; }

        /// <summary>
        /// banka iban no
        /// </summary>
        public string IBAN_NO { get; set; }

        /// <summary>
        /// yetkili ismi
        /// </summary>
        public string BANKA_TELEFON { get; set; }





    }
}
