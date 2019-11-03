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
    public partial class Fournisseurs : Form
    {
        public Fournisseurs()
        {
            InitializeComponent();
        }

        public bool ifExists(string nomprenom) {
            foreach (DataRow f in Program.mesTables.Fournisseurs)
            {
                if (f["nomprenom"].ToString().ToUpper() == nomprenom.ToUpper()) return true;
            }
            return false;
        }

        public void AjouterFournisseurs() {
            DataRow f = Program.mesTables.Fournisseurs.NewRow();
            f["nomprenom"] = textBox1.Text;
            f["adresse"] = textBox2.Text;
            f["patente"] = textBox3.Text;
            f["cnss"] = textBox4.Text;
            f["i_f"] = textBox5.Text;
            f["tel"] = textBox6.Text;
            f["fax"] = textBox7.Text;
            if (MessageBox.Show("Etes-vous sur de vouloir ajouter ce fournisseur ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.mesTables.Fournisseurs.Rows.Add(f);
                Program.FournisseursTa.Update(Program.mesTables.Fournisseurs);
                MessageBox.Show("Fournisseur bien ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            Program.FournisseursTa.Fill(Program.mesTables.Fournisseurs);
        }

        private void buttonX_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim().ToString() == string.Empty) MessageBox.Show("Les champs '*' sont nécessaires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ifExists(textBox1.Text)) MessageBox.Show("Ce fournisseur existe déja !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else AjouterFournisseurs();
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème est survenue lors de l'ajout veuillez réessayer ultérieurement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
