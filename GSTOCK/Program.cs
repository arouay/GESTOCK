using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using GSTOCK.Mes_TablesTableAdapters;

namespace GSTOCK
{
    static class Program
    {
        public static Mes_Tables mesTables = new Mes_Tables();

        public static ArticlesTableAdapter ArticleTa = new ArticlesTableAdapter();
        public static ArticlesDebutMoisTableAdapter ArticlesDebutMoisTa = new ArticlesDebutMoisTableAdapter();
        public static EtatStockTableAdapter EtatStockTa = new EtatStockTableAdapter();
        public static ListeDesArticlesAchetésTableAdapter ListeArticlesAchetésTa = new ListeDesArticlesAchetésTableAdapter();
        public static ListeDesArticlesExportésTableAdapter ListeArticlesExportésTa = new ListeDesArticlesExportésTableAdapter();
        public static BeneficiairesTableAdapter BeneficiairesTa = new BeneficiairesTableAdapter();
        public static FournisseursTableAdapter FournisseursTa = new FournisseursTableAdapter();
        public static AchatsTableAdapter AchatsTa = new AchatsTableAdapter();
        public static ExportationsTableAdapter ExportationsTa = new ExportationsTableAdapter();
        public static UtilisateursTableAdapter UtilisateursTa = new UtilisateursTableAdapter();
        public static v_ArticlesExportesTableAdapter v_ArticlesExportesTa = new v_ArticlesExportesTableAdapter();
        public static v_ArticlesImportesTableAdapter v_ArticlesImportesTa = new v_ArticlesImportesTableAdapter();        
        public static v_listeDechargesTableAdapter v_listeDechargesTa = new v_listeDechargesTableAdapter();
        public static v_listeAchatsTableAdapter v_listeAchatsTa = new v_listeAchatsTableAdapter();
        public static v_ArticlesEnStockTableAdapter v_ArticlesEnStockTa = new v_ArticlesEnStockTableAdapter();
        public static v_ArticlesDebutMoisTableAdapter v_ArticleDebutMoisTa = new v_ArticlesDebutMoisTableAdapter();
        public static v_BilanTableAdapter v_BilanTa = new v_BilanTableAdapter();



        public static string numExportation = string.Empty;        
        public static string numAchat = string.Empty;
        public static string nomCheckedRadio = string.Empty;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authentification());
        }
    }
}
