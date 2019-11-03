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
    public partial class Liste_decharges : Form
    {
        public Liste_decharges()
        {
            InitializeComponent();
        }

        private void Liste_decharges_Load(object sender, EventArgs e)
        {
            Program.v_listeDechargesTa.Fill(Program.mesTables.v_listeDecharges);
            dataGridView1.DataSource = Program.mesTables.v_listeDecharges;
            dataGridView1.Columns[0].HeaderText = "Décharges";
        }
    }
}
