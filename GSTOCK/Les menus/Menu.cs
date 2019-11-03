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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void pictureBoxStock_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = false;
        }

        private void pictureBoxFournisseurs_MouseHover(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = false;
            pictureBox_article.Visible = false;
            pictureBox_beneficiaire.Visible = false;
            pictureBox_fournisseur.Visible = true;
            pictureBox_bilan.Visible = false;
        }

        private void pictureBoxFournisseurs_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_fournisseur.Visible = false;
        }

        private void pictureBoxStock_MouseHover(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = true;
            pictureBox_article.Visible = false;
            pictureBox_beneficiaire.Visible = false;
            pictureBox_fournisseur.Visible = false;
            pictureBox_bilan.Visible = false;
            
        }

        private void pictureBoxArticles_MouseHover(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = false;
            pictureBox_article.Visible = true;
            pictureBox_beneficiaire.Visible = false;
            pictureBox_fournisseur.Visible = false;
            pictureBox_bilan.Visible = false;
        }

        private void pictureBoxArticles_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_article.Visible = false;
        }

        private void pictureBoxBilan_MouseHover(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = false;
            pictureBox_article.Visible = false;
            pictureBox_beneficiaire.Visible = false;
            pictureBox_fournisseur.Visible = false;
            pictureBox_bilan.Visible = true;
        }

        private void pictureBoxBilan_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_bilan.Visible = false;
        }        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxStock_Click(object sender, EventArgs e)
        {
            new STOCK().Show();
        }

        private void pictureBoxFournisseurs_Click(object sender, EventArgs e)
        {
            new Fournisseurs().Show();
        }

        private void pictureBoxArticles_Click(object sender, EventArgs e)
        {
            new Articles().Show();
        }

        private void pictureBoxBilan_Click(object sender, EventArgs e)
        {
            new Bilan().Show();
        }

        private void vignette41_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_beneficiaire.Visible = false;
        }

        private void line3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void reflectionLabel5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox_stock.Visible = false;
            pictureBox_article.Visible = false;
            pictureBox_beneficiaire.Visible = true;
            pictureBox_fournisseur.Visible = false;
            pictureBox_bilan.Visible = false;
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox_beneficiaire.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            new Beneficiaires().Show();
        }

        

            
    }
}
