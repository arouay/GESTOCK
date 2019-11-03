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
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        public bool ifExists(string desgination) {
            foreach(DataRow r in Program.mesTables.Articles){
                if (r["Designation"].ToString().ToUpper() == desgination.ToUpper()) return true;
            }
            return false;
        }

        public void AjouterArticle(string designation) {
            DataRow article = Program.mesTables.Articles.NewRow();
            article["designation"] = designation;
            if (MessageBox.Show("Etes-vous sur de vouloir ajouter cet article ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.mesTables.Articles.Rows.Add(article);
                Program.ArticleTa.Update(Program.mesTables.Articles);
                MessageBox.Show("Article bien ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
        public void supprimerArticle(string designation) { 
            foreach(DataRow r in Program.mesTables.Articles){
                if (r["designation"].ToString().ToUpper() == textBox1.Text.ToUpper()) r.Delete();
            }
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            Program.ArticleTa.Fill(Program.mesTables.Articles);          
        }

        private void buttonX_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == string.Empty) MessageBox.Show("Les champs '*' sont nécessaires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ifExists(textBox1.Text)) MessageBox.Show("Cet articles existe déja !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else AjouterArticle(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème est survenue lors de l'ajout veuillez réessayer ultérieurement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
