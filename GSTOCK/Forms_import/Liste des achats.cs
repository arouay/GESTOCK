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
    public partial class Liste_des_achats : Form
    {
        public Liste_des_achats()
        {
            InitializeComponent();
        }

        private void Liste_des_achats_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.mesTables.v_listeAchats;
        }
    }
}
