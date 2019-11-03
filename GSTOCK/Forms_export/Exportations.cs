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
    public partial class Exportations : Form
    {                
        #region MesFonctions
        public void ChargerComboBeneficiaires() {            
            if (radioButton_Bureau.Checked)
            {
                comboBox_beneficiaires.Items.Clear();
                foreach(DataRow r in Program.mesTables.Beneficiaires.Rows){
                    if (r["TypeBeneficiaire"].ToString() == "DPMEN") {                        
                        comboBox_beneficiaires.Items.Add(r["Etablissement_Bureau"].ToString());                        
                    }
                }                
            }
            else {
                comboBox_beneficiaires.Items.Clear();
                foreach(DataRow r in Program.mesTables.Beneficiaires.Rows){
                    if (r["TypeBeneficiaire"].ToString() == "Etablissement") {                        
                        comboBox_beneficiaires.Items.Add(r["Etablissement_Bureau"].ToString()); 
                    }
                }                
            }
            comboBox_beneficiaires.DisplayMember = "Etablissement_Bureau";
            comboBox_beneficiaires.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_beneficiaires.SelectedIndex = 0;
        }
        public void AfficherExportation(DataRow r) {                                                           
            foreach(DataRow b in Program.mesTables.Beneficiaires.Rows){
                if (r["beneficiaire"].ToString() == b["Etablissement_Bureau"].ToString())
                {                   
                    if (b["TypeBeneficiaire"].ToString() == "Etablissement")
                    {
                        radioButton_etablissement.Checked = true;                        
                    }
                    else {
                        radioButton_Bureau.Checked = true;                        
                    }
                    comboBox_beneficiaires.Text = b["Etablissement_Bureau"].ToString();
                    dateTimePicker_DateExportation.Text = r["DateExportation"].ToString(); 
                    break;
                }                
            }            
        }
        public void RechercherExportation(string num) {
            bool flag = true;
            foreach(DataRow r in Program.mesTables.Exportations.Rows){                
                if (r["numExportation"].ToString().ToUpper() == num.ToUpper())
                {                    
                    flag = false;
                    AfficherExportation(r);
                    break;
                }
            }            
            if (flag) MessageBox.Show("l'éxportation demandée n'xiste pas !","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion


        public Exportations()
        {
            InitializeComponent();
        }

        private void button_ajouterListe_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                foreach (DataRow r in Program.mesTables.Exportations)
                {
                    if (textBox_numExportation.Text.ToUpper() == r["numExportation"].ToString().ToUpper()) flag = true;
                }
                if (textBox_numExportation.Text.Trim() == string.Empty) MessageBox.Show("Veuillez entrer tout d'abord le numéro d'éxportation à modifiée (ajoutée)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag && radioButton_modifier.Checked) MessageBox.Show("Impossible d'ajouter une liste d'articles à une exportation inexistante !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (flag && radioButton_ajouter.Checked) MessageBox.Show("Impossible d'ajouter une nouvelle liste d'articles à une exportation déja éxitante !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (radioButton_ajouter.Checked) Program.nomCheckedRadio = radioButton_ajouter.Name;
                    else if (radioButton_modifier.Checked) Program.nomCheckedRadio = radioButton_modifier.Name;
                    Program.numExportation = textBox_numExportation.Text;
                    new Ajouter_liste_articles_exportes().Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void button_consulterListe_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_numExportation.Text.Trim() == string.Empty) MessageBox.Show("Veuillez entrer le numéro de l'éxportation concernée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Program.numExportation = textBox_numExportation.Text;
                    new consultation_Articles_exportes().Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void Exportations_Load(object sender, EventArgs e)
        {
            Program.BeneficiairesTa.Fill(Program.mesTables.Beneficiaires);
            Program.ExportationsTa.Fill(Program.mesTables.Exportations);
            Program.ListeArticlesExportésTa.Fill(Program.mesTables.ListeDesArticlesExportés);
            radioButton_Bureau.Checked = true;
            radioButton_rechercher.Checked = true;
        }

        private void radioButton_Bureau_CheckedChanged(object sender, EventArgs e)
        {
            ChargerComboBeneficiaires();
        }

        private void radioButton_etablissement_CheckedChanged(object sender, EventArgs e)
        {
            ChargerComboBeneficiaires();
        }

        private void buttonX_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                RechercherExportation(textBox_numExportation.Text);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void radioButton_rechercher_CheckedChanged(object sender, EventArgs e)
        {
            buttonX_rechercher.Enabled = true;
            buttonX_ajouter.Enabled = false;
            buttonX_modifier.Enabled = false;
            buttonX_supprimer.Enabled = false;
            button_ajouterListe.Enabled = false;
        }

        private void radioButton_ajouter_CheckedChanged(object sender, EventArgs e)
        {
            buttonX_rechercher.Enabled = false;
            buttonX_ajouter.Enabled = true;
            buttonX_modifier.Enabled = false;
            buttonX_supprimer.Enabled = false;
            button_ajouterListe.Enabled = true;
        }

        private void radioButton_supprimer_CheckedChanged(object sender, EventArgs e)
        {
            buttonX_rechercher.Enabled = false;
            buttonX_ajouter.Enabled = false;
            buttonX_modifier.Enabled = false;
            buttonX_supprimer.Enabled = true;
            button_ajouterListe.Enabled = false;           
        }

        private void radioButton_modifier_CheckedChanged(object sender, EventArgs e)
        {
            buttonX_rechercher.Enabled = false;
            buttonX_ajouter.Enabled = false;
            buttonX_modifier.Enabled = true;
            buttonX_supprimer.Enabled = false;
            button_ajouterListe.Enabled = true;
        }

        private void buttonX_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                foreach (DataRow article in Program.mesTables.Exportations)
                {
                    if (article["numExportation"].ToString().ToUpper() == textBox_numExportation.Text.ToUpper())
                    {
                        flag = false;
                        article["Beneficiaire"] = comboBox_beneficiaires.Text;
                        article["DateExportation"] = dateTimePicker_DateExportation.Text;
                        //Modification de la liste des articles est faite automatiquement vue elle est au niveau d'autre table                    
                    }
                }
                if (flag) MessageBox.Show("L'éxportation n'éxiste pas !");
                else if (MessageBox.Show("Voulez-vous vraiment modifier cette éxportation ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.ListeArticlesExportésTa.Update(Program.mesTables.ListeDesArticlesExportés);
                    Program.ExportationsTa.Update(Program.mesTables.Exportations);
                    MessageBox.Show("Modification faite avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void buttonX_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                //on doit tout dabord supprimer tous les aticles appartenant a cette exportation
                foreach (DataRow article in Program.mesTables.ListeDesArticlesExportés)
                {
                    if (article["Exportations"].ToString().ToUpper() == textBox_numExportation.Text.ToUpper()) article.Delete();
                }
                //Puis on supprime l'exporation
                bool flag = true;
                foreach (DataRow ex in Program.mesTables.Exportations)
                {
                    if (ex["numExportation"].ToString().ToUpper() == textBox_numExportation.Text.ToUpper())
                    {
                        flag = false;
                        if (MessageBox.Show("Voulez-vous vraiment supprimer cette exportation ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ex.Delete();
                            Program.ListeArticlesExportésTa.Update(Program.mesTables.ListeDesArticlesExportés);
                            Program.ExportationsTa.Update(Program.mesTables.Exportations);
                            MessageBox.Show("Exportation bien supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                }
                if (flag) MessageBox.Show("Exportation introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {                
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void buttonX_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                foreach (DataRow r in Program.mesTables.Exportations)
                {
                    if (r["numExportation"].ToString().ToUpper() == textBox_numExportation.Text.ToUpper()) flag = false;
                }
                if (flag && textBox_numExportation.Text.Trim() != string.Empty)
                {
                    DataRow exportation = Program.mesTables.Exportations.NewRow();
                    exportation["numExportation"] = textBox_numExportation.Text;
                    exportation["Beneficiaire"] = comboBox_beneficiaires.Text;
                    exportation["DateExportation"] = dateTimePicker_DateExportation.Text;
                    
                    if (MessageBox.Show("Voulez-vous vraiment valider l'opération ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Program.mesTables.Exportations.Rows.Add(exportation);
                        Program.ExportationsTa.Update(Program.mesTables.Exportations);
                        MessageBox.Show("Exportation ajoutée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Program.ListeArticlesExportésTa.Update(Program.mesTables.ListeDesArticlesExportés);
                }
                else if (textBox_numExportation.Text.Trim() == string.Empty) MessageBox.Show("Le champ <<numéro d'éxportation>> est necessaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Il éxiste déja une éxportation avec ce numéro !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
        }

        private void label_nbBeneficiaire_Click(object sender, EventArgs e)
        {
            new Beneficiaires().Show();
        }

        private void buttonX_ListeDecharges_Click(object sender, EventArgs e)
        {
            new Liste_decharges().Show();
        }
    }
}
