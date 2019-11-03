namespace GSTOCK
{
    partial class Bilan
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.radioButton_Bilan = new System.Windows.Forms.RadioButton();
            this.radioButton_exportations = new System.Windows.Forms.RadioButton();
            this.radioButton_importations = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_article = new System.Windows.Forms.ComboBox();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton2 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.comboBox_fournisseur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.switchButton3 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.comboBox_beneficiaire = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_stockInitial = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.switchButton6 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonX_imprimer = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.radioButton_Bilan);
            this.groupPanel1.Controls.Add(this.radioButton_exportations);
            this.groupPanel1.Controls.Add(this.radioButton_importations);
            this.groupPanel1.Controls.Add(this.groupBox2);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.radioButton_stockInitial);
            this.groupPanel1.Controls.Add(this.dateTimePicker_fin);
            this.groupPanel1.Controls.Add(this.dateTimePicker_debut);
            this.groupPanel1.Controls.Add(this.switchButton6);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(11, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1156, 172);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Les filtres";
            // 
            // radioButton_Bilan
            // 
            this.radioButton_Bilan.AutoSize = true;
            this.radioButton_Bilan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton_Bilan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Bilan.Location = new System.Drawing.Point(35, 114);
            this.radioButton_Bilan.Name = "radioButton_Bilan";
            this.radioButton_Bilan.Size = new System.Drawing.Size(110, 20);
            this.radioButton_Bilan.TabIndex = 13;
            this.radioButton_Bilan.Text = "Bilan global";
            this.radioButton_Bilan.UseVisualStyleBackColor = false;
            this.radioButton_Bilan.CheckedChanged += new System.EventHandler(this.radioButton_Bilan_CheckedChanged);
            // 
            // radioButton_exportations
            // 
            this.radioButton_exportations.AutoSize = true;
            this.radioButton_exportations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton_exportations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_exportations.Location = new System.Drawing.Point(35, 48);
            this.radioButton_exportations.Name = "radioButton_exportations";
            this.radioButton_exportations.Size = new System.Drawing.Size(119, 20);
            this.radioButton_exportations.TabIndex = 7;
            this.radioButton_exportations.Text = "Exportations";
            this.radioButton_exportations.UseVisualStyleBackColor = false;
            this.radioButton_exportations.CheckedChanged += new System.EventHandler(this.radioButton_exportations_CheckedChanged);
            // 
            // radioButton_importations
            // 
            this.radioButton_importations.AutoSize = true;
            this.radioButton_importations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton_importations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_importations.Location = new System.Drawing.Point(35, 15);
            this.radioButton_importations.Name = "radioButton_importations";
            this.radioButton_importations.Size = new System.Drawing.Size(121, 20);
            this.radioButton_importations.TabIndex = 7;
            this.radioButton_importations.Text = "Importations";
            this.radioButton_importations.UseVisualStyleBackColor = false;
            this.radioButton_importations.CheckedChanged += new System.EventHandler(this.radioButton_importations_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.comboBox_article);
            this.groupBox2.Controls.Add(this.switchButton1);
            this.groupBox2.Controls.Add(this.switchButton2);
            this.groupBox2.Controls.Add(this.comboBox_fournisseur);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.switchButton3);
            this.groupBox2.Controls.Add(this.comboBox_beneficiaire);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(276, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 132);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_article
            // 
            this.comboBox_article.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_article.FormattingEnabled = true;
            this.comboBox_article.Location = new System.Drawing.Point(112, 20);
            this.comboBox_article.Name = "comboBox_article";
            this.comboBox_article.Size = new System.Drawing.Size(242, 24);
            this.comboBox_article.TabIndex = 8;
            this.comboBox_article.Visible = false;
            this.comboBox_article.SelectedIndexChanged += new System.EventHandler(this.comboBox_article_SelectedIndexChanged);
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton1.Location = new System.Drawing.Point(376, 21);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Size = new System.Drawing.Size(66, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 2;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // switchButton2
            // 
            // 
            // 
            // 
            this.switchButton2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton2.Location = new System.Drawing.Point(376, 59);
            this.switchButton2.Name = "switchButton2";
            this.switchButton2.Size = new System.Drawing.Size(66, 22);
            this.switchButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton2.TabIndex = 2;
            this.switchButton2.ValueChanged += new System.EventHandler(this.switchButton2_ValueChanged);
            // 
            // comboBox_fournisseur
            // 
            this.comboBox_fournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_fournisseur.FormattingEnabled = true;
            this.comboBox_fournisseur.Location = new System.Drawing.Point(112, 96);
            this.comboBox_fournisseur.Name = "comboBox_fournisseur";
            this.comboBox_fournisseur.Size = new System.Drawing.Size(242, 24);
            this.comboBox_fournisseur.TabIndex = 8;
            this.comboBox_fournisseur.Visible = false;
            this.comboBox_fournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBox_fournisseur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Article";
            // 
            // switchButton3
            // 
            // 
            // 
            // 
            this.switchButton3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton3.Location = new System.Drawing.Point(376, 97);
            this.switchButton3.Name = "switchButton3";
            this.switchButton3.Size = new System.Drawing.Size(66, 22);
            this.switchButton3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton3.TabIndex = 2;
            this.switchButton3.ValueChanged += new System.EventHandler(this.switchButton3_ValueChanged);
            // 
            // comboBox_beneficiaire
            // 
            this.comboBox_beneficiaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_beneficiaire.FormattingEnabled = true;
            this.comboBox_beneficiaire.Location = new System.Drawing.Point(112, 58);
            this.comboBox_beneficiaire.Name = "comboBox_beneficiaire";
            this.comboBox_beneficiaire.Size = new System.Drawing.Size(242, 24);
            this.comboBox_beneficiaire.TabIndex = 8;
            this.comboBox_beneficiaire.Visible = false;
            this.comboBox_beneficiaire.SelectedIndexChanged += new System.EventHandler(this.comboBox_beneficiaire_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bénèficiaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fournisseur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(933, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jusqu\'a\r\n";
            this.label7.Visible = false;
            // 
            // radioButton_stockInitial
            // 
            this.radioButton_stockInitial.AutoSize = true;
            this.radioButton_stockInitial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton_stockInitial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_stockInitial.Location = new System.Drawing.Point(35, 81);
            this.radioButton_stockInitial.Name = "radioButton_stockInitial";
            this.radioButton_stockInitial.Size = new System.Drawing.Size(231, 20);
            this.radioButton_stockInitial.TabIndex = 7;
            this.radioButton_stockInitial.Text = "Stock initial du mois courant";
            this.radioButton_stockInitial.UseVisualStyleBackColor = false;
            this.radioButton_stockInitial.CheckedChanged += new System.EventHandler(this.radioButton_stockInitial_CheckedChanged);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(901, 96);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(127, 23);
            this.dateTimePicker_fin.TabIndex = 9;
            this.dateTimePicker_fin.Visible = false;
            this.dateTimePicker_fin.ValueChanged += new System.EventHandler(this.dateTimePicker_fin_ValueChanged);
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_debut.Location = new System.Drawing.Point(901, 27);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(127, 23);
            this.dateTimePicker_debut.TabIndex = 9;
            this.dateTimePicker_debut.Visible = false;
            // 
            // switchButton6
            // 
            // 
            // 
            // 
            this.switchButton6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton6.Location = new System.Drawing.Point(1051, 59);
            this.switchButton6.Name = "switchButton6";
            this.switchButton6.Size = new System.Drawing.Size(66, 22);
            this.switchButton6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton6.TabIndex = 2;
            this.switchButton6.ValueChanged += new System.EventHandler(this.switchButton6_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(762, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Entre deux dates";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonX_imprimer
            // 
            this.buttonX_imprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_imprimer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_imprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonX_imprimer.Location = new System.Drawing.Point(439, 15);
            this.buttonX_imprimer.Name = "buttonX_imprimer";
            this.buttonX_imprimer.Size = new System.Drawing.Size(270, 23);
            this.buttonX_imprimer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_imprimer.TabIndex = 3;
            this.buttonX_imprimer.Text = "Imprimer le bilan global";
            this.buttonX_imprimer.Click += new System.EventHandler(this.buttonX_imprimer_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.buttonX_imprimer);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 560);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1155, 58);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 4;
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1179, 630);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilan";
            this.Load += new System.EventHandler(this.Bilan_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.ButtonX buttonX_imprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton6;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton3;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton2;
        private System.Windows.Forms.RadioButton radioButton_importations;
        private System.Windows.Forms.RadioButton radioButton_exportations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_debut;
        private System.Windows.Forms.ComboBox comboBox_fournisseur;
        private System.Windows.Forms.ComboBox comboBox_beneficiaire;
        private System.Windows.Forms.ComboBox comboBox_article;
        private System.Windows.Forms.RadioButton radioButton_stockInitial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Bilan;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    }
}