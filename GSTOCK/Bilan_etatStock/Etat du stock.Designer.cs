namespace GSTOCK
{
    partial class Etat_du_stock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_exportes = new System.Windows.Forms.RadioButton();
            this.radioButton_importes = new System.Windows.Forms.RadioButton();
            this.checkBox_tousArticles = new System.Windows.Forms.CheckBox();
            this.comboBox_designation = new System.Windows.Forms.ComboBox();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBox_tousArticles);
            this.groupBox1.Controls.Add(this.comboBox_designation);
            this.groupBox1.Controls.Add(this.reflectionLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_exportes);
            this.groupBox2.Controls.Add(this.radioButton_importes);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opération";
            // 
            // radioButton_exportes
            // 
            this.radioButton_exportes.AutoSize = true;
            this.radioButton_exportes.Checked = true;
            this.radioButton_exportes.Location = new System.Drawing.Point(45, 12);
            this.radioButton_exportes.Name = "radioButton_exportes";
            this.radioButton_exportes.Size = new System.Drawing.Size(121, 17);
            this.radioButton_exportes.TabIndex = 9;
            this.radioButton_exportes.TabStop = true;
            this.radioButton_exportes.Text = "Articles exportés";
            this.radioButton_exportes.UseVisualStyleBackColor = true;
            this.radioButton_exportes.CheckedChanged += new System.EventHandler(this.radioButton_exportes_CheckedChanged);
            // 
            // radioButton_importes
            // 
            this.radioButton_importes.AutoSize = true;
            this.radioButton_importes.Location = new System.Drawing.Point(45, 33);
            this.radioButton_importes.Name = "radioButton_importes";
            this.radioButton_importes.Size = new System.Drawing.Size(121, 17);
            this.radioButton_importes.TabIndex = 9;
            this.radioButton_importes.Text = "Articles importés";
            this.radioButton_importes.UseVisualStyleBackColor = true;
            this.radioButton_importes.CheckedChanged += new System.EventHandler(this.radioButton_importes_CheckedChanged);
            // 
            // checkBox_tousArticles
            // 
            this.checkBox_tousArticles.AutoSize = true;
            this.checkBox_tousArticles.Location = new System.Drawing.Point(597, 43);
            this.checkBox_tousArticles.Name = "checkBox_tousArticles";
            this.checkBox_tousArticles.Size = new System.Drawing.Size(117, 17);
            this.checkBox_tousArticles.TabIndex = 8;
            this.checkBox_tousArticles.Text = "Tous les articles";
            this.checkBox_tousArticles.UseVisualStyleBackColor = true;
            this.checkBox_tousArticles.CheckedChanged += new System.EventHandler(this.checkBox_tousArticles_CheckedChanged);
            // 
            // comboBox_designation
            // 
            this.comboBox_designation.FormattingEnabled = true;
            this.comboBox_designation.Location = new System.Drawing.Point(597, 20);
            this.comboBox_designation.Name = "comboBox_designation";
            this.comboBox_designation.Size = new System.Drawing.Size(249, 21);
            this.comboBox_designation.TabIndex = 7;
            this.comboBox_designation.SelectedIndexChanged += new System.EventHandler(this.comboBox_designation_SelectedIndexChanged);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(23, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(301, 49);
            this.reflectionLabel1.TabIndex = 6;
            this.reflectionLabel1.Text = "L\'état d\'aujourd\'hui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Désignation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 253);
            this.dataGridView1.TabIndex = 2;
            // 
            // Etat_du_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(881, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Etat_du_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat_du_stock";
            this.Load += new System.EventHandler(this.Etat_du_stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.ComboBox comboBox_designation;
        private System.Windows.Forms.CheckBox checkBox_tousArticles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_exportes;
        private System.Windows.Forms.RadioButton radioButton_importes;
    }
}