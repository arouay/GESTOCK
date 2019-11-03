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
    public partial class Beneficiaires : Form
    {
        public Beneficiaires()
        {
            InitializeComponent();
        }

        public bool ifExists(string nom) {
            foreach (DataRow b in Program.mesTables.Beneficiaires)
            {
                if (b["Etablissement_bureau"].ToString().ToUpper() == nom.ToUpper()) return true;
            }
            return false;
        }

        public void AjouterBeneficiaires()
        {
            DataRow b = Program.mesTables.Beneficiaires.NewRow();
            b["TypeBeneficiaire"] = comboBox1.Text;
            b["Etablissement_Bureau"] = textBox1.Text;

            if (MessageBox.Show("Etes-vous sur de vouloir ajouter ce bénèficiaire ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.mesTables.Beneficiaires.Rows.Add(b);
                Program.BeneficiairesTa.Update(Program.mesTables.Beneficiaires);
                MessageBox.Show("Bénèficiare bien ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Beneficiaires_Load(object sender, EventArgs e)
        {
            Program.BeneficiairesTa.Fill(Program.mesTables.Beneficiaires);
            comboBox1.Items.Add("Etablissement");
            comboBox1.Items.Add("DPMEN");
            comboBox1.Items.Add("Autre");
            comboBox1.Text = "Etablissement";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Etablissement") label2.Text = "Etablissement :";
            else if (comboBox1.Text == "DPMEN") label2.Text = "Bureau :";
            else label2.Text = "Nom :";
        }

        private void buttonX_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == string.Empty) MessageBox.Show("Les champs '*' sont nécessaires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ifExists(textBox1.Text)) MessageBox.Show("Ce bénèficiaire existe déja !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else AjouterBeneficiaires();
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème est survenue lors de l'ajout veuillez réessayer ultérieurement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
