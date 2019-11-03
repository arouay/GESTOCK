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
    public partial class Les_Achats : Form
    {
        public Les_Achats()
        {
            InitializeComponent();
        }

        public void ChargerComboFournisseurs() {
            comboBox_fournisseurs.DataSource = Program.mesTables.Fournisseurs;
            comboBox_fournisseurs.DisplayMember = "nomPrenom";
            comboBox_fournisseurs.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ChargerComboNatures() {
            comboBox_nature.Items.Add("Materiel de bureau");
            comboBox_nature.Items.Add("Produit alimentaire");
            comboBox_nature.Items.Add("Equipement");
            comboBox_nature.SelectedItem = "Materiel de bureau";
            comboBox_nature.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ChargerComboTypes()
        {
            comboBox_typeAchat.Items.Add("Bon de commande");
            comboBox_typeAchat.Items.Add("Marché");
            comboBox_typeAchat.SelectedItem = "Bon de commande";
            comboBox_typeAchat.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public bool ifExistsAchat(string numAchat) { 
            foreach(DataRow a in Program.mesTables.Achats){
                if (a["numAchat"].ToString() == numAchat) return true;
            }
            return false;
        }
        public void AfficherAchat(DataRow a) {
            textBox_numAchat.Text = a["numAchat"].ToString();
            foreach(DataRow f in Program.mesTables.Fournisseurs){
                if (f["nomPrenom"].ToString() == a["Fournisseur"].ToString()) {
                    comboBox_fournisseurs.Text = f["nomPrenom"].ToString();
                    break;
                }
            }
            dateTimePicker_DateAchat.Text = a["DateAchat"].ToString();
            textBox_Objet.Text = a["Objet"].ToString();
            comboBox_nature.Text = a["Nature"].ToString();
            comboBox_typeAchat.Text = a["TypeAchat"].ToString();            
        }

        private void button_ajouterListe_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                foreach (DataRow r in Program.mesTables.Achats)
                {
                    if (textBox_numAchat.Text.ToUpper() == r["numAchat"].ToString().ToUpper()) flag = true;
                }
                if (textBox_numAchat.Text.Trim() == string.Empty) MessageBox.Show("Veuillez entrer tout d'abord le numéro d'achat à modifiée (ajoutée)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!flag && radioButton_modifier.Checked) MessageBox.Show("Impossible d'ajouter une liste d'articles à un achat inexistant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (flag && radioButton_ajouter.Checked) MessageBox.Show("Impossible d'ajouter une nouvelle liste d'articles à un achat déja éxitant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (radioButton_ajouter.Checked) Program.nomCheckedRadio = radioButton_ajouter.Name;
                    else if (radioButton_modifier.Checked) Program.nomCheckedRadio = radioButton_modifier.Name;
                    Program.numAchat = textBox_numAchat.Text;
                    new AjoutListeArticlesImportes().Show();
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
                if (textBox_numAchat.Text.Trim() == string.Empty) MessageBox.Show("Veuillez entrer le numéro d'achat concernée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Program.numAchat = textBox_numAchat.Text;
                    new consultation_liste_importes().Show();
                }
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

        private void Les_Achats_Load(object sender, EventArgs e)
        {
            radioButton_rechercher.Checked = true;
            Program.FournisseursTa.Fill(Program.mesTables.Fournisseurs);
            Program.AchatsTa.Fill(Program.mesTables.Achats);
            Program.ListeArticlesAchetésTa.Fill(Program.mesTables.ListeDesArticlesAchetés);
            ChargerComboFournisseurs();
            ChargerComboNatures();
            ChargerComboTypes();
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

        private void buttonX_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_numAchat.Text.Trim() == string.Empty) MessageBox.Show("Le champ numero d'achat est necessaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!ifExistsAchat(textBox_numAchat.Text)) MessageBox.Show("Achat innexistant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    foreach (DataRow r in Program.mesTables.Achats)
                    {
                        if (textBox_numAchat.Text == r["numAchat"].ToString())
                        {
                            AfficherAchat(r);
                            break;
                        }
                    }
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
                //on doit tout dabord supprimer tous les aticles appartenant a cet achat            
                foreach (DataRow article in Program.mesTables.ListeDesArticlesAchetés)
                {
                    if (article["Achat"].ToString().ToUpper() == textBox_numAchat.Text.ToUpper()) article.Delete();
                }
                //Puis on supprime l'achat
                bool flag = true;
                foreach (DataRow ac in Program.mesTables.Achats)
                {
                    if (ac["numAchat"].ToString().ToUpper() == textBox_numAchat.Text.ToUpper())
                    {
                        flag = false;
                        if (MessageBox.Show("Voulez-vous vraiment supprimer cet achat ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ac.Delete();
                            Program.ListeArticlesAchetésTa.Update(Program.mesTables.ListeDesArticlesAchetés);
                            Program.AchatsTa.Update(Program.mesTables.Achats);
                            MessageBox.Show("Achat bien supprimé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                }
                if (flag) MessageBox.Show("Achat introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }

        private void label_nbFournisseur_Click(object sender, EventArgs e)
        {
            new Fournisseurs().Show();
        }

        private void buttonX_listeAchats_Click(object sender, EventArgs e)
        {
            Program.v_listeAchatsTa.Fill(Program.mesTables.v_listeAchats);
            new Liste_des_achats().Show();
        }

        private void buttonX_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                foreach (DataRow r in Program.mesTables.Achats)
                {
                    if (r["numAchat"].ToString().ToUpper() == textBox_numAchat.Text.ToUpper()) flag = false;
                }
                if (flag && textBox_numAchat.Text.Trim() != string.Empty)
                {
                    DataRow achat = Program.mesTables.Achats.NewRow();
                    achat["numAchat"] = textBox_numAchat.Text;
                    achat["Fournisseur"] = comboBox_fournisseurs.Text;
                    achat["dateAchat"] = dateTimePicker_DateAchat.Text;
                    achat["objet"] = textBox_Objet.Text;
                    achat["nature"] = comboBox_nature.Text;
                    achat["typeAchat"] = comboBox_typeAchat.Text;
                    if (MessageBox.Show("Voulez-vous vraiment valider l'opération ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Program.mesTables.Achats.Rows.Add(achat);
                        Program.AchatsTa.Update(Program.mesTables.Achats);
                        MessageBox.Show("Achat ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Program.ListeArticlesAchetésTa.Update(Program.mesTables.ListeDesArticlesAchetés);
                }
                else if (textBox_numAchat.Text.Trim() == string.Empty) MessageBox.Show("Le champ <<numéro Achat>> est necessaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Il éxiste déja un achat avec ce numéro !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                foreach (DataRow article in Program.mesTables.Achats)
                {
                    if (article["numAchat"].ToString().ToUpper() == textBox_numAchat.Text.ToUpper())
                    {
                        flag = false;
                        article["Fournisseur"] = comboBox_fournisseurs.Text;
                        article["DateAchat"] = dateTimePicker_DateAchat.Text;
                        article["Objet"] = textBox_Objet.Text;
                        article["Nature"] = comboBox_nature.Text;
                        article["TypeAchat"] = comboBox_typeAchat.Text;
                        //Modification de la liste des articles est faite automatiquement vue elle est au niveau d'autre table                    
                    }
                }
                if (flag) MessageBox.Show("L'achat n'éxiste pas !");
                else if (MessageBox.Show("Voulez-vous vraiment modifier cet achat ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.ListeArticlesAchetésTa.Update(Program.mesTables.ListeDesArticlesAchetés);
                    Program.AchatsTa.Update(Program.mesTables.Achats);
                    MessageBox.Show("Modification faite avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur est survenue quelque part, veuillez vérifier vos données puis ressayer !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);                                
            }
        }    
    }
}
