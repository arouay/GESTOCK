using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace GSTOCK
{
    public partial class consultation_liste_importes : Form
    {
        public consultation_liste_importes()
        {
            InitializeComponent();
        }

        private void consultation_liste_importes_Load(object sender, EventArgs e)
        {
            Program.ListeArticlesAchetésTa.Fill(Program.mesTables.ListeDesArticlesAchetés);
            Program.mesTables.ListeDesArticlesAchetés.DefaultView.RowFilter = string.Format("Achat = '{0}'", Program.numAchat);
            dataGridView1.DataSource = Program.mesTables.ListeDesArticlesAchetés.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
