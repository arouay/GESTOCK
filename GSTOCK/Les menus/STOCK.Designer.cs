namespace GSTOCK
{
    partial class STOCK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOCK));
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton_Exportations = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_achats = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_etatStock = new DevComponents.DotNetBar.BubbleButton();
            this.reflectionLabel_Annee = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel_mois = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            // 
            // 
            // 
            this.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(24, 24);
            this.bubbleBar1.Location = new System.Drawing.Point(-4, 114);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(383, 61);
            this.bubbleBar1.TabIndex = 0;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            this.bubbleBar1.Text = "bubbleBar1";
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton_Exportations,
            this.bubbleButton_achats,
            this.bubbleButton_etatStock});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "Mon stock";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton_Exportations
            // 
            this.bubbleButton_Exportations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bubbleButton_Exportations.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_Exportations.Image")));
            this.bubbleButton_Exportations.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_Exportations.ImageLarge")));
            this.bubbleButton_Exportations.Name = "bubbleButton_Exportations";
            this.bubbleButton_Exportations.TooltipText = "Les exportations";
            this.bubbleButton_Exportations.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Exportations_Click);
            // 
            // bubbleButton_achats
            // 
            this.bubbleButton_achats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bubbleButton_achats.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_achats.Image")));
            this.bubbleButton_achats.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_achats.ImageLarge")));
            this.bubbleButton_achats.Name = "bubbleButton_achats";
            this.bubbleButton_achats.TooltipText = "Les achats";
            this.bubbleButton_achats.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Importations_Click);
            // 
            // bubbleButton_etatStock
            // 
            this.bubbleButton_etatStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bubbleButton_etatStock.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_etatStock.Image")));
            this.bubbleButton_etatStock.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_etatStock.ImageLarge")));
            this.bubbleButton_etatStock.Name = "bubbleButton_etatStock";
            this.bubbleButton_etatStock.TooltipText = "l\'état du stock";
            this.bubbleButton_etatStock.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_etatStock_Click);
            // 
            // reflectionLabel_Annee
            // 
            // 
            // 
            // 
            this.reflectionLabel_Annee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel_Annee.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel_Annee.Location = new System.Drawing.Point(208, 19);
            this.reflectionLabel_Annee.Name = "reflectionLabel_Annee";
            this.reflectionLabel_Annee.Size = new System.Drawing.Size(86, 70);
            this.reflectionLabel_Annee.TabIndex = 1;
            this.reflectionLabel_Annee.Text = "Test";
            // 
            // reflectionLabel2
            // 
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Location = new System.Drawing.Point(188, -35);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(14, 124);
            this.reflectionLabel2.TabIndex = 1;
            this.reflectionLabel2.Text = "<b><font size=\"+10\"><font color=\"#B02B2C\">  / </font></font></b>";
            // 
            // reflectionLabel_mois
            // 
            // 
            // 
            // 
            this.reflectionLabel_mois.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel_mois.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel_mois.Location = new System.Drawing.Point(95, 31);
            this.reflectionLabel_mois.Name = "reflectionLabel_mois";
            this.reflectionLabel_mois.Size = new System.Drawing.Size(87, 49);
            this.reflectionLabel_mois.TabIndex = 2;
            this.reflectionLabel_mois.Text = "Test";
            
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(57, 78);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(261, 23);
            this.line1.TabIndex = 3;
            this.line1.Text = "line1";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(57, 9);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(261, 23);
            this.line2.TabIndex = 3;
            this.line2.Text = "line1";
            // 
            // STOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(374, 187);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.reflectionLabel_mois);
            this.Controls.Add(this.reflectionLabel2);
            this.Controls.Add(this.reflectionLabel_Annee);
            this.Controls.Add(this.bubbleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STOCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK";
            this.Load += new System.EventHandler(this.STOCK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_Exportations;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_achats;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_etatStock;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel_Annee;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel_mois;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line2;
    }
}