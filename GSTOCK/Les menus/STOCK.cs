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
    public partial class STOCK : Form
    {
        public STOCK()
        {
            InitializeComponent();
        }
        private void bubbleButton_Exportations_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            new Exportations().Show();
        }

        private void bubbleButton_Importations_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            new Les_Achats().Show();
        }
        
        private void bubbleButton_etatStock_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            new Etat_du_stock().Show();
        }

        private void STOCK_Load(object sender, EventArgs e)
        {
           
            reflectionLabel_Annee.Text = DateTime.Now.Year.ToString();
            reflectionLabel_mois.Text = DateTime.Now.ToString("MMMM");   
            
        }        
    }
}
