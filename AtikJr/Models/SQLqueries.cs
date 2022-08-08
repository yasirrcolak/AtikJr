namespace AtikJr.Models
{
    /// <summary>
    /// Sql sorguları için gerekli olan tüm sorguları barındırır.
    /// </summary>
    public class SQLqueries
    {
        /// <summary>
        /// cari tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumCariler = " select * from TBL_CARI ";

        /// <summary>
        /// kasa tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumKasalar = " select * from TBL_KASA ";

        /// <summary>
        /// stok tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumStoklar = " select * from TBL_STOK ";

        /// <summary>
        /// muhasebe tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumMuhasebeler = " select * from TBL_MUHASEBE ";

        /// <summary>
        /// banka tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumBankalar = " select * from TBL_BANKA ";

        /// <summary>
        /// proje tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumProjeler = " select * from TBL_PROJE ";

        /// <summary>
        /// araç tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumAraclar = " select * from TBL_ARACC ";

        /// <summary>
        /// besi tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumBesiler = " select * from TBL_BESI ";

    }
}
