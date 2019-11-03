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
    public partial class AjoutListeArticlesImportes : Form
    {
        public AjoutListeArticlesImportes()
        {
            InitializeComponent();
        }

        public void ChargerComboArticles()
        {
            Program.ArticleTa.Fill(Program.mesTables.Articles);
            comboBox_articles.DataSource = Program.mesTables.Articles;
            comboBox_articles.DisplayMember = "Designation";
            comboBox_articles.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        public bool ExistsArticle(string importation, string article)
        {
            foreach (DataRow r in Program.mesTables.ListeDesArticlesAchetés)
            {
                if (r["achat"].ToString().ToUpper() == importation.ToUpper() && r["articleachetés"].ToString().ToUpper() == article.ToUpper()) return true;
            }
            return false;
        }
        DataRow liste;
        public void AjouterArticle()
        {
            liste = Program.mesTables.ListeDesArticlesAchetés.NewRow();
            liste["achat"] = Program.numAchat;
            liste["articleachetés"] = comboBox_articles.Text;
            liste["qte"] = numericUpDown_qte.Value;
            Program.mesTables.ListeDesArticlesAchetés.Rows.Add(liste);            
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment valider l'opértaion ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Program.nomCheckedRadio == "radioButton_modifier")
                        Program.ListeArticlesAchetésTa.Update(Program.mesTables.ListeDesArticlesAchetés);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        public void RaffraichirLabel_nbArticles()
        {
            Program.mesTables.ListeDesArticlesAchetés.DefaultView.RowFilter = string.Format("Achat = '{0}'", Program.numAchat);
            label_nbArticles.Text = Program.mesTables.ListeDesArticlesAchetés.DefaultView.Count.ToString();
        }

        private void AjoutListeArticlesImportes_Load(object sender, EventArgs e)
        {
            Program.ListeArticlesAchetésTa.Fill(Program.mesTables.ListeDesArticlesAchetés);
            ChargerComboArticles();
            RaffraichirLabel_nbArticles();
        }

        private void label_nbBeneficiaire_Click(object sender, EventArgs e)
        {
            new Articles().Show();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ExistsArticle(Program.numAchat, comboBox_articles.Text))
                {
                    AjouterArticle();
                    RaffraichirLabel_nbArticles();
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

        private void comboBox_articles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.nomCheckedRadio == "radioButton_modifier")
                {
                    foreach (DataRow r in Program.mesTables.ListeDesArticlesAchetés)
                    {
                        if (r["Achat"].ToString() == Program.numAchat && r["ArticleAchetés"].ToString() == comboBox_articles.Text)
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
    }
}
