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
    public partial class Etat_du_stock : Form
    {
        public Etat_du_stock()
        {
            InitializeComponent();
        }
        public void chargerCombo() {
            Program.ArticleTa.Fill(Program.mesTables.Articles);
            comboBox_designation.DataSource = Program.mesTables.Articles;
            comboBox_designation.DisplayMember = "Designation";
            comboBox_designation.DropDownStyle = ComboBoxStyle.DropDownList;
        }        
        private void Etat_du_stock_Load(object sender, EventArgs e)
        {
            Program.v_ArticlesExportesTa.Fill(Program.mesTables.v_ArticlesExportes);
            Program.v_ArticlesImportesTa.Fill(Program.mesTables.v_ArticlesImportes);
            chargerCombo();            
        }

        private void comboBox_designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton_exportes.Checked)
            {
                Program.mesTables.v_ArticlesExportes.DefaultView.RowFilter = string.Format("Désignation = '{0}'", comboBox_designation.Text);
                dataGridView1.DataSource = Program.mesTables.v_ArticlesExportes.DefaultView;
            }
            else {
                Program.mesTables.v_ArticlesImportes.DefaultView.RowFilter = string.Format("Désignation = '{0}'", comboBox_designation.Text);
                dataGridView1.DataSource = Program.mesTables.v_ArticlesImportes.DefaultView;                
            }
        }

        private void checkBox_tousArticles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tousArticles.Checked && radioButton_exportes.Checked)
            {
                comboBox_designation.Enabled = false;
                Program.mesTables.v_ArticlesExportes.DefaultView.RowFilter = "1=1";
                dataGridView1.DataSource = Program.mesTables.v_ArticlesExportes.DefaultView;
            }
            else if (checkBox_tousArticles.Checked && radioButton_importes.Checked) {
                comboBox_designation.Enabled = false;
                Program.mesTables.v_ArticlesImportes.DefaultView.RowFilter = "1=1";
                dataGridView1.DataSource = Program.mesTables.v_ArticlesImportes.DefaultView;
            }
            else
            {
                comboBox_designation.Enabled = true;
                comboBox_designation_SelectedIndexChanged(sender, e);
            }
        }

        private void radioButton_exportes_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_designation_SelectedIndexChanged(sender,e);
        }

        private void radioButton_importes_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_designation_SelectedIndexChanged(sender,e);
        }
    }
}
