namespace AtikJr.Models
{
    /// <summary>
    /// Sql sorguları için gerekli olan tüm sorguları barındırır.
    /// </summary>
    public class SQLqueries
    {
        /// <summary>
        /// Connection string
        /// </summary>
        public static string ConnectionString = @"Data Source=DESKTOP-0JBLED4;Initial Catalog=ATIKER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region Select Sorgulari 

        /// <summary>
        /// cari tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumCariler = "SELECT * from TBLCARISB";

        /// <summary>
        /// kasa tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumKasalar = "SELECT * FROM TBLKASASB";

        /// <summary>
        /// stok tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumStoklar = "SELECT * FROM TBLSTOKSB";

        /// <summary>
        /// muhasebe tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumMuhasebeler = "SELECT * FROM TBLMUHSB";

        /// <summary>
        /// banka tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumBankalar = "SELECT * FROM TBLBANKASB";

        /// <summary>
        /// proje tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumProjeler = "SELECT * FROM TBL_PROJE";

        /// <summary>
        /// araç tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumAraclar = "SELECT * FROM TBLARACSB";

        /// <summary>
        /// besi tablosundan tüm veriler çekildi.
        /// </summary>
        public static string tumBesiler = "SELECT * FROM TBLBESISB";

        #endregion

        #region Delete Sorguları

        /// <summary>
        /// 
        /// </summary>
        public static string CariSil = "DELETE tablo adı where ID=";

        #endregion

    }
}
