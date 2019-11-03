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
    public partial class Impression : Form
    {
        public Impression()
        {
            InitializeComponent();
        }

        private void Impression_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();            
            cr.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;            
            cr.SetDataSource(Program.mesTables);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
