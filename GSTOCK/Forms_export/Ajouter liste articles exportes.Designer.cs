namespace GSTOCK
{
    partial class Ajouter_liste_articles_exportes
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
            this.numericUpDown_qte = new System.Windows.Forms.NumericUpDown();
            this.label_nbArticles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.comboBox_Article = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_qteStock = new System.Windows.Forms.Label();
            this.label_Attention = new System.Windows.Forms.Label();
            this.label_stockCritique = new System.Windows.Forms.Label();
            this.label_nbBeneficiaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qte)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_qte
            // 
            this.numericUpDown_qte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown_qte.Location = new System.Drawing.Point(115, 52);
            this.numericUpDown_qte.Name = "numericUpDown_qte";
            this.numericUpDown_qte.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_qte.TabIndex = 8;
            this.numericUpDown_qte.ValueChanged += new System.EventHandler(this.numericUpDown_qte_ValueChanged);
            // 
            // label_nbArticles
            // 
            this.label_nbArticles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_nbArticles.Location = new System.Drawing.Point(115, 82);
            this.label_nbArticles.Name = "label_nbArticles";
            this.label_nbArticles.Size = new System.Drawing.Size(40, 20);
            this.label_nbArticles.TabIndex = 12;
            this.label_nbArticles.Text = "0";
            this.label_nbArticles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre d\'articles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Article";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(394, 70);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(55, 23);
            this.button_Ok.TabIndex = 13;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(394, 44);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(55, 23);
            this.button_supprimer.TabIndex = 10;
            this.button_supprimer.Text = "-";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(394, 18);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(55, 23);
            this.button_ajouter.TabIndex = 9;
            this.button_ajouter.Text = "+";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(394, 96);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(55, 23);
            this.button_annuler.TabIndex = 15;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click_1);
            // 
            // comboBox_Article
            // 
            this.comboBox_Article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Article.FormattingEnabled = true;
            this.comboBox_Article.Location = new System.Drawing.Point(115, 25);
            this.comboBox_Article.Name = "comboBox_Article";
            this.comboBox_Article.Size = new System.Drawing.Size(237, 21);
            this.comboBox_Article.TabIndex = 16;
            this.comboBox_Article.SelectedIndexChanged += new System.EventHandler(this.comboBox_Article_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantité en stock";
            // 
            // label_qteStock
            // 
            this.label_qteStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_qteStock.Location = new System.Drawing.Point(115, 112);
            this.label_qteStock.Name = "label_qteStock";
            this.label_qteStock.Size = new System.Drawing.Size(40, 20);
            this.label_qteStock.TabIndex = 12;
            this.label_qteStock.Text = "0";
            this.label_qteStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Attention
            // 
            this.label_Attention.AutoSize = true;
            this.label_Attention.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attention.ForeColor = System.Drawing.Color.Red;
            this.label_Attention.Location = new System.Drawing.Point(201, 99);
            this.label_Attention.Name = "label_Attention";
            this.label_Attention.Size = new System.Drawing.Size(14, 16);
            this.label_Attention.TabIndex = 11;
            this.label_Attention.Text = "-";
            // 
            // label_stockCritique
            // 
            this.label_stockCritique.AutoSize = true;
            this.label_stockCritique.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stockCritique.ForeColor = System.Drawing.Color.Red;
            this.label_stockCritique.Location = new System.Drawing.Point(175, 116);
            this.label_stockCritique.Name = "label_stockCritique";
            this.label_stockCritique.Size = new System.Drawing.Size(14, 16);
            this.label_stockCritique.TabIndex = 11;
            this.label_stockCritique.Text = "-";
            // 
            // label_nbBeneficiaire
            // 
            this.label_nbBeneficiaire.AutoSize = true;
            this.label_nbBeneficiaire.BackColor = System.Drawing.SystemColors.Window;
            this.label_nbBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nbBeneficiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_nbBeneficiaire.Location = new System.Drawing.Point(356, 28);
            this.label_nbBeneficiaire.Name = "label_nbBeneficiaire";
            this.label_nbBeneficiaire.Size = new System.Drawing.Size(17, 15);
            this.label_nbBeneficiaire.TabIndex = 31;
            this.label_nbBeneficiaire.Text = "+";
            this.label_nbBeneficiaire.Click += new System.EventHandler(this.label_nbBeneficiaire_Click);
            // 
            // Ajouter_liste_articles_exportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(469, 141);
            this.Controls.Add(this.label_nbBeneficiaire);
            this.Controls.Add(this.comboBox_Article);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.numericUpDown_qte);
            this.Controls.Add(this.label_qteStock);
            this.Controls.Add(this.label_stockCritique);
            this.Controls.Add(this.label_Attention);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_nbArticles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_liste_articles_exportes";
            this.Text = "Ajouter_liste_articles_exportes";
            this.Load += new System.EventHandler(this.Ajouter_liste_articles_exportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_qte;
        private System.Windows.Forms.Label label_nbArticles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.ComboBox comboBox_Article;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_qteStock;
        private System.Windows.Forms.Label label_Attention;
        private System.Windows.Forms.Label label_stockCritique;
        private System.Windows.Forms.Label label_nbBeneficiaire;
    }
}