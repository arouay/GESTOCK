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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        #region MesVariables
        //Dans la class program
        #endregion
        #region MesFonctions
        public void ChargerUtilisateurs()
        {
            Program.UtilisateursTa.Fill(Program.mesTables.Utilisateurs);
        }
        public bool VerifierUtilisateur(string login, string mdp)
        {
            bool flag = false;
            foreach (DataRow r in Program.mesTables.Tables["Utilisateurs"].Rows)
            {
                if (r["Login"].ToString().ToUpper() == login.ToUpper() && r["Mdp"].ToString().ToUpper() == mdp.ToUpper())
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        #endregion

        private void Authentification_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();            
        }

        private void buttonGestionUtilisateurs_Click(object sender, EventArgs e)
        {            
            if(VerifierUtilisateur(textBoxLogin.Text,textBoxMdp.Text))
                new Gestion_Utilisateurs().Show();            
            else
                MessageBox.Show("Login ou Mot de passe incorrect !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }        

        private void textBoxMdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonX1_Click(new object(), new EventArgs());                            
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxMdp_KeyDown(sender, e);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (VerifierUtilisateur(textBoxLogin.Text, textBoxMdp.Text))
                new Gestion_Utilisateurs().Show();
            else
                MessageBox.Show("Login ou Mot de passe incorrect !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (VerifierUtilisateur(textBoxLogin.Text, textBoxMdp.Text)) { 
                new Menu().Show();
                //this.Hide();
            }
            else MessageBox.Show("Login ou Mot de passe incorrect !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }    
    }
}