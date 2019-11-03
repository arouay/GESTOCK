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
    public partial class consultation_Articles_exportes : Form
    {
        public consultation_Articles_exportes()
        {
            InitializeComponent();
        }

        private void consultation_Articles_exportes_Load(object sender, EventArgs e)
        {            
            Program.ListeArticlesExportésTa.Fill(Program.mesTables.ListeDesArticlesExportés);
            Program.mesTables.ListeDesArticlesExportés.DefaultView.RowFilter = string.Format("Exportations = '{0}'", Program.numExportation);
            dataGridView1.DataSource = Program.mesTables.ListeDesArticlesExportés.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
