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
    public partial class Gestion_Utilisateurs : Form
    {
        #region MesVariables
         //La class program 
        #endregion

        #region MesFonctions

        public void ChargerUtilisateurs()
        {
            Program.UtilisateursTa.Fill(Program.mesTables.Utilisateurs);
        }
        public bool ifExist(string login) {
            foreach (DataRow r in Program.mesTables.Tables["Utilisateurs"].Rows)
            {
                if (r["Login"].ToString().ToUpper() == login.ToUpper())
                    return true;                                    
            }
            return false;
        }
        public void AjouterUtilisateur(DataRow utilisateur) {
            Program.mesTables.Utilisateurs.Rows.Add(utilisateur);
            Program.UtilisateursTa.Update(Program.mesTables.Utilisateurs);
            MessageBox.Show("Utilisateur bien ajouté","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void SupprimerUtilisateur(string login,string mdp) {
            foreach (DataRow r in Program.mesTables.Tables["Utilisateurs"].Rows)
            {
                if (r["Login"].ToString().ToUpper() == login.ToUpper() && r["mdp"].ToString().ToUpper() == mdp.ToUpper())
                {
                    r.Delete();
                    Program.UtilisateursTa.Update(Program.mesTables.Utilisateurs);
                    MessageBox.Show("Utilisateur bien supprimé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }                    
            }            
        }

        #endregion
        
        public Gestion_Utilisateurs()
        {
            InitializeComponent();
        }

        private void Gestion_Utilisateurs_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAjouter.Checked && textBoxLogin.Text.Trim() != string.Empty && textBoxMdp.Text.Trim() != string.Empty) {
                if (ifExist(textBoxLogin.Text)) MessageBox.Show("Ce Login existe déja !", "Erreure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else {
                    DataRow utilisateur = Program.mesTables.Utilisateurs.NewRow();
                    utilisateur["Login"] = textBoxLogin.Text;
                    utilisateur["mdp"] = textBoxMdp.Text;
                    AjouterUtilisateur(utilisateur);
                }                    
            }
            else if (radioButtonSupprimer.Checked && textBoxLogin.Text.Trim() != string.Empty && textBoxMdp.Text.Trim() != string.Empty)
            {
                if (!ifExist(textBoxLogin.Text)) MessageBox.Show("Ce Login n'existe pas !", "Erreure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Program.mesTables.Utilisateurs.Count == 1) MessageBox.Show("Vous ne pouvez pas supprimer le dernier utilisateur éxistant !", "Erreure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else SupprimerUtilisateur(textBoxLogin.Text,textBoxMdp.Text);
            }
            else MessageBox.Show("Tous les champs sont obligatoires !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

               
    }
}
