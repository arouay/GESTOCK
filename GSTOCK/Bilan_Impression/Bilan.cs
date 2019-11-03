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
    public partial class Bilan : Form
    {
        public Bilan()
        {
            InitializeComponent();
        }

        public void ChargerDonnées() {
            Program.ExportationsTa.Fill(Program.mesTables.Exportations);
            Program.AchatsTa.Fill(Program.mesTables.Achats);
            Program.v_ArticleDebutMoisTa.Fill(Program.mesTables.v_ArticlesDebutMois);
            Program.v_ArticlesEnStockTa.Fill(Program.mesTables.v_ArticlesEnStock);
            try
            {
                Program.v_BilanTa.Fill(Program.mesTables.v_Bilan);
            }
            catch (Exception)
            {
                
            }
        }

        public void ChargerLesCombos() {
            Program.ArticleTa.Fill(Program.mesTables.Articles);
            Program.BeneficiairesTa.Fill(Program.mesTables.Beneficiaires);
            Program.FournisseursTa.Fill(Program.mesTables.Fournisseurs);

            comboBox_article.DataSource = Program.mesTables.Articles;
            comboBox_beneficiaire.DataSource = Program.mesTables.Beneficiaires;
            comboBox_fournisseur.DataSource = Program.mesTables.Fournisseurs;

            comboBox_article.DisplayMember = "Designation";
            comboBox_article.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_beneficiaire.DisplayMember = "Etablissement_Bureau";
            comboBox_beneficiaire.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fournisseur.DisplayMember = "nomPrenom";
            comboBox_fournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Bilan_Load(object sender, EventArgs e)
        {            
            ChargerLesCombos();
            ChargerDonnées();
            radioButton_importations.Checked = true;
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton1.Value)
            {
                comboBox_article.Visible = false;                
                if (radioButton_stockInitial.Checked) Program.mesTables.v_ArticlesDebutMois.DefaultView.RowFilter = "1=1";
                else if (radioButton_Bilan.Checked) Program.mesTables.v_Bilan.DefaultView.RowFilter = "1=1";                
            }
            else
            {
                comboBox_article.Visible = true;
                comboBox_article_SelectedIndexChanged(sender,e);
            }

            if (radioButton_exportations.Checked || radioButton_importations.Checked) switchButton1.Value = false;
        }

        private void switchButton2_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton2.Value)
            {
                comboBox_beneficiaire.Visible = false;
                Program.mesTables.Exportations.DefaultView.RowFilter = "1=1";
            }
            else { 
                comboBox_beneficiaire.Visible = true;
                comboBox_beneficiaire_SelectedIndexChanged(sender, e);
            }

            if (radioButton_importations.Checked || radioButton_stockInitial.Checked ||radioButton_Bilan.Checked) switchButton2.Value = false;
        }

        private void switchButton3_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton3.Value)
            {
                comboBox_fournisseur.Visible = false;
                Program.mesTables.Achats.DefaultView.RowFilter = "1=1";
            }
            else { 
                comboBox_fournisseur.Visible = true;
                comboBox_fournisseur_SelectedIndexChanged(sender,e);
            }

            if (radioButton_exportations.Checked || radioButton_stockInitial.Checked || radioButton_Bilan.Checked) switchButton3.Value = false;
        }

        private void switchButton6_ValueChanged(object sender, EventArgs e)
        {
            
                if (!switchButton6.Value)
                {
                    dateTimePicker_debut.Visible = false;
                    dateTimePicker_fin.Visible = false;
                    label7.Visible = !Visible;
                    if (radioButton_exportations.Checked) Program.mesTables.Exportations.DefaultView.RowFilter = "1=1";
                    else if (radioButton_Bilan.Checked) Program.mesTables.v_Bilan.DefaultView.RowFilter = "1=1";
                    else if (radioButton_importations.Checked) Program.mesTables.Achats.DefaultView.RowFilter = "1=1";
                }
                else
                {
                    dateTimePicker_debut.Visible = true;
                    dateTimePicker_fin.Visible = true;
                    label7.Visible = Visible;
                    dateTimePicker_fin_ValueChanged(sender,e);
                }
                if (radioButton_stockInitial.Checked) switchButton6.Value = false;
            
        }

        private void radioButton_stockInitial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_stockInitial.Checked)
            {
                dataGridView1.DataSource = Program.mesTables.v_ArticlesDebutMois.DefaultView;
                switchButton2.Value = false;
                comboBox_beneficiaire.Visible = false;
                switchButton3.Value = false;
                comboBox_fournisseur.Visible = false;
                switchButton6.Value = false;
                dateTimePicker_debut.Visible = false;
                dateTimePicker_fin.Visible = false;
                label7.Visible = false;
            }
        }

        private void comboBox_article_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (radioButton_stockInitial.Checked) Program.mesTables.v_ArticlesDebutMois.DefaultView.RowFilter = string.Format("ArticleAchetés = '{0}'", comboBox_article.Text);
            else if (radioButton_Bilan.Checked) Program.mesTables.v_Bilan.DefaultView.RowFilter = string.Format("Article = '{0}'", comboBox_article.Text);
        }

        private void radioButton_exportations_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_exportations.Checked)
            {
                dataGridView1.DataSource = Program.mesTables.Exportations.DefaultView;
                switchButton1.Value = false;
                comboBox_article.Visible = false;
                switchButton3.Value = false;
                comboBox_fournisseur.Visible = false;
            }
        }

        private void radioButton_importations_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_importations.Checked)
            {
                dataGridView1.DataSource = Program.mesTables.Achats.DefaultView;
                switchButton1.Value = false;
                comboBox_article.Visible = false;
                switchButton2.Value = false;
                comboBox_beneficiaire.Visible = false;
            }
        }

        

        private void radioButton_Bilan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Bilan.Checked)
                dataGridView1.DataSource = Program.mesTables.v_Bilan.DefaultView;
        }

        private void comboBox_beneficiaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_exportations.Checked) Program.mesTables.Exportations.DefaultView.RowFilter = string.Format("Beneficiaire = '{0}'",comboBox_beneficiaire.Text);
        }

        private void comboBox_fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_importations.Checked) Program.mesTables.Achats.DefaultView.RowFilter = string.Format("Fournisseur = '{0}'",comboBox_fournisseur.Text);
        }

        private void dateTimePicker_fin_ValueChanged(object sender, EventArgs e)
        {
            string dateDebut = dateTimePicker_debut.Value.ToShortDateString();
            string dateFin = dateTimePicker_fin.Value.ToShortDateString();
            if (radioButton_Bilan.Checked) Program.mesTables.v_Bilan.DefaultView.RowFilter = string.Format("([Date de l'achat] >= '{0}' and [Date de l'achat] <= '{1}') or ([Date de l'exportation] <= '{2}' and [Date de l'exportation] >= '{3}')", dateDebut, dateFin, dateDebut, dateFin);
            else if (radioButton_exportations.Checked) Program.mesTables.Exportations.DefaultView.RowFilter = string.Format("DateExportation >= '{0}' and DateExportation <= '{1}'", dateDebut, dateFin);
            else if (radioButton_importations.Checked) Program.mesTables.Achats.DefaultView.RowFilter = string.Format("DateAchat >= '{0}' and DateAchat <= '{1}'", dateDebut, dateFin);
        }

        private void buttonX_imprimer_Click(object sender, EventArgs e)
        {
            new Impression().Show();
        }
    }
}
