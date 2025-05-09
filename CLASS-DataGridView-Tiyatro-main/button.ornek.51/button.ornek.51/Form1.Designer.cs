namespace button.ornek._51
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOyunAd = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.chkMuzikal = new System.Windows.Forms.CheckBox();
            this.nudSure = new System.Windows.Forms.NumericUpDown();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "oyun id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "oyun ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "oyun tarih saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "oyun süre";
            // 
            // cmbOyunAd
            // 
            this.cmbOyunAd.FormattingEnabled = true;
            this.cmbOyunAd.Location = new System.Drawing.Point(116, 102);
            this.cmbOyunAd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOyunAd.Name = "cmbOyunAd";
            this.cmbOyunAd.Size = new System.Drawing.Size(95, 23);
            this.cmbOyunAd.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(116, 212);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(156, 21);
            this.dtpTarih.TabIndex = 8;
            // 
            // chkMuzikal
            // 
            this.chkMuzikal.AutoSize = true;
            this.chkMuzikal.Location = new System.Drawing.Point(116, 249);
            this.chkMuzikal.Margin = new System.Windows.Forms.Padding(2);
            this.chkMuzikal.Name = "chkMuzikal";
            this.chkMuzikal.Size = new System.Drawing.Size(69, 19);
            this.chkMuzikal.TabIndex = 9;
            this.chkMuzikal.Text = "müzikal";
            this.chkMuzikal.UseVisualStyleBackColor = true;
            // 
            // nudSure
            // 
            this.nudSure.Location = new System.Drawing.Point(116, 139);
            this.nudSure.Margin = new System.Windows.Forms.Padding(2);
            this.nudSure.Name = "nudSure";
            this.nudSure.Size = new System.Drawing.Size(93, 21);
            this.nudSure.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(116, 175);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(79, 21);
            this.txtFiyat.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSahne);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkMuzikal);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudSure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.cmbOyunAd);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(505, 286);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TİYATRO";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::button.ornek._51.Properties.Resources.Güncelle;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(331, 62);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 62);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::button.ornek._51.Properties.Resources.Sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(409, 62);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 62);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Image = global::button.ornek._51.Properties.Resources.Ekle;
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEkle.Location = new System.Drawing.Point(259, 62);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(74, 62);
            this.BtnEkle.TabIndex = 12;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(29, 326);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(502, 209);
            this.dgvListe.TabIndex = 16;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellContentClick);
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sahne";
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Location = new System.Drawing.Point(116, 62);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(121, 23);
            this.cmbSahne.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 547);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOyunAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.CheckBox chkMuzikal;
        private System.Windows.Forms.NumericUpDown nudSure;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.Label label7;
    }
}

