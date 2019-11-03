using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSTOCK
{
    public partial class Ajouter_liste_articles_exportes : Form
    {
        public Ajouter_liste_articles_exportes()
        {
            InitializeComponent();
        }

        public void ChargerComboArticles() {
            Program.ArticleTa.Fill(Program.mesTables.Articles);
            comboBox_Article.DataSource = Program.mesTables.Articles;
            comboBox_Article.DisplayMember = "Designation";
            comboBox_Article.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        public void RaffraichirLabel_nbArticles() {
            Program.mesTables.ListeDesArticlesExportés.DefaultView.RowFilter = string.Format("Exportations = '{0}'", Program.numExportation);
            label_nbArticles.Text = Program.mesTables.ListeDesArticlesExportés.DefaultView.Count.ToString();  
        }
        DataRow liste;
        public bool ExistsArticle(string exportation, string article)
        {
            foreach (DataRow r in Program.mesTables.ListeDesArticlesExportés)
            {
                if (r["Exportations"].ToString().ToUpper() == exportation.ToUpper() && r["ArticleExporté"].ToString().ToUpper() == article.ToUpper()) return true;
            }
            return false;
        }
        public void AjouterArticle()
        {
            liste = Program.mesTables.ListeDesArticlesExportés.NewRow();
            liste["Exportations"] = Program.numExportation;
            liste["ArticleExporté"] = comboBox_Article.Text;
            liste["Qte"] = numericUpDown_qte.Value;
            Program.mesTables.ListeDesArticlesExportés.Rows.Add(liste);
            RaffraichirLabel_nbArticles();
        }
        public bool VerifierEtatStock(string designation, string qte)
        {
            foreach (DataRow article in Program.mesTables.v_ArticlesEnStock)
            {
                if (designation.ToUpper() == article["Designation"].ToString().ToUpper() && Convert.ToInt32(qte) <= Convert.ToInt32(article["Disponible en stock"]))
                {
                    return true;
                }
            }
            return false;
        }

        private void Ajouter_liste_articles_exportes_Load(object sender, EventArgs e)
        {
            Program.ListeArticlesExportésTa.Fill(Program.mesTables.ListeDesArticlesExportés);
            Program.v_ArticlesEnStockTa.Fill(Program.mesTables.v_ArticlesEnStock);
            ChargerComboArticles();
            RaffraichirLabel_nbArticles();            
        }

        
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ExistsArticle(Program.numExportation, comboBox_Article.Text))
                {
                    AjouterArticle();
                }
                else
                {
                    MessageBox.Show("Cet article éxiste déja veuillez le supprimer puis l'ajouter à nouveau", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }
        
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.nomCheckedRadio == "radioButton_modifier")
                {
                    foreach (DataRow r in Program.mesTables.ListeDesArticlesExportés)
                    {
                        if (r["Exportations"].ToString() == Program.numExportation && r["ArticleExporté"].ToString() == comboBox_Article.Text)
                        {
                            r.Delete();
                        }
                    }
                    RaffraichirLabel_nbArticles();
                }
                else if (Program.nomCheckedRadio == "radioButton_ajouter")
                {
                    RaffraichirLabel_nbArticles();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment valider l'opértaion ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Program.nomCheckedRadio == "radioButton_modifier")
                        Program.ListeArticlesExportésTa.Update(Program.mesTables.ListeDesArticlesExportés);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler l'opértaion ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();            
        }

        private void numericUpDown_qte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!VerifierEtatStock(comboBox_Article.Text, numericUpDown_qte.Value.ToString()))
                {
                    button_ajouter.Enabled = false;
                    label_Attention.Text = "ATTENTION ";
                    label_stockCritique.Text = "le stock est critique";
                }
                else
                {
                    button_ajouter.Enabled = true;
                    label_Attention.Text = "- ";
                    label_stockCritique.Text = "-";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void comboBox_Article_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow Article in Program.mesTables.v_ArticlesEnStock)
                {
                    if (Article["Designation"].ToString().ToUpper() == comboBox_Article.Text.ToUpper())
                    {
                        label_qteStock.Text = Article["Disponible en stock"].ToString();
                        break;
                    }
                    else
                    {
                        label_qteStock.Text = "0";
                    }
                }
                numericUpDown_qte.Value = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void button_annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_nbBeneficiaire_Click(object sender, EventArgs e)
        {
            new Articles().Show();
        }        
    }
}
