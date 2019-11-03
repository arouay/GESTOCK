namespace GSTOCK
{
    partial class AjoutListeArticlesImportes
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
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_qte = new System.Windows.Forms.NumericUpDown();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.label_nbBeneficiaire = new System.Windows.Forms.Label();
            this.comboBox_articles = new System.Windows.Forms.ComboBox();
            this.label_nbArticles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qte)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(393, 12);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(55, 23);
            this.button_ajouter.TabIndex = 2;
            this.button_ajouter.Text = "+";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre d\'articles";
            // 
            // numericUpDown_qte
            // 
            this.numericUpDown_qte.Location = new System.Drawing.Point(130, 63);
            this.numericUpDown_qte.Name = "numericUpDown_qte";
            this.numericUpDown_qte.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_qte.TabIndex = 1;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(393, 72);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(55, 23);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_retour_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(393, 42);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(55, 23);
            this.button_supprimer.TabIndex = 3;
            this.button_supprimer.Text = "-";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(393, 102);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(55, 23);
            this.button_annuler.TabIndex = 17;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // label_nbBeneficiaire
            // 
            this.label_nbBeneficiaire.AutoSize = true;
            this.label_nbBeneficiaire.BackColor = System.Drawing.SystemColors.Window;
            this.label_nbBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nbBeneficiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_nbBeneficiaire.Location = new System.Drawing.Point(352, 37);
            this.label_nbBeneficiaire.Name = "label_nbBeneficiaire";
            this.label_nbBeneficiaire.Size = new System.Drawing.Size(17, 15);
            this.label_nbBeneficiaire.TabIndex = 31;
            this.label_nbBeneficiaire.Text = "+";
            this.label_nbBeneficiaire.Click += new System.EventHandler(this.label_nbBeneficiaire_Click);
            // 
            // comboBox_articles
            // 
            this.comboBox_articles.FormattingEnabled = true;
            this.comboBox_articles.Location = new System.Drawing.Point(130, 34);
            this.comboBox_articles.Name = "comboBox_articles";
            this.comboBox_articles.Size = new System.Drawing.Size(216, 21);
            this.comboBox_articles.TabIndex = 32;
            this.comboBox_articles.SelectedIndexChanged += new System.EventHandler(this.comboBox_articles_SelectedIndexChanged);
            // 
            // label_nbArticles
            // 
            this.label_nbArticles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_nbArticles.Location = new System.Drawing.Point(130, 91);
            this.label_nbArticles.Name = "label_nbArticles";
            this.label_nbArticles.Size = new System.Drawing.Size(40, 20);
            this.label_nbArticles.TabIndex = 33;
            this.label_nbArticles.Text = "0";
            this.label_nbArticles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AjoutListeArticlesImportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(460, 133);
            this.Controls.Add(this.label_nbArticles);
            this.Controls.Add(this.comboBox_articles);
            this.Controls.Add(this.label_nbBeneficiaire);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.numericUpDown_qte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjoutListeArticlesImportes";
            this.Text = "Ajouter Liste des articles";
            this.Load += new System.EventHandler(this.AjoutListeArticlesImportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_qte;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Label label_nbBeneficiaire;
        private System.Windows.Forms.ComboBox comboBox_articles;
        private System.Windows.Forms.Label label_nbArticles;
    }
}