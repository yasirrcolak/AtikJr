namespace AtikJr.Models
{
    public class StokModel
    {
        /// <summary>
        /// stok sıra 
        /// </summary>
        public int STOK_ID { get; set; }

        /// <summary>
        /// stok kategori
        /// </summary>
        public string STOK_KATEGORİ { get; set; }

        /// <summary>
        /// stok markamadı
        /// </summary>
        public string STOK_MARKA_{ get; set; }

        /// <summary>
        /// ürün adı
        /// </summary>
        public string STOK_URUN_ADI { get; set; }

        /// <summary>
        /// stok tarihi
        /// </summary>
        public DateTime STOK_TARIH { get; set; }

        /// <summary>
        /// stok sayısı
        /// </summary>
        public int STOK_MİKTAR { get; set; }
    }
}
