namespace button._49
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.chkCilt = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kitap Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Basım Tarihi";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(75, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(66, 20);
            this.txtAd.TabIndex = 10;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(75, 95);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(66, 20);
            this.txtYazar.TabIndex = 11;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(75, 130);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(66, 20);
            this.txtSayfa.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.chkCilt);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSayfa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 226);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP ÖZELLİKLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Romantik",
            "Eğlence",
            "Felsefe",
            "Komedi",
            "Edebiyat",
            "Aksiyon",
            "Bilim kurgu"});
            this.cmbTur.Location = new System.Drawing.Point(224, 24);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(79, 21);
            this.cmbTur.TabIndex = 16;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(224, 96);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(140, 20);
            this.dtpTarih.TabIndex = 15;
            // 
            // chkCilt
            // 
            this.chkCilt.AutoSize = true;
            this.chkCilt.Location = new System.Drawing.Point(164, 60);
            this.chkCilt.Name = "chkCilt";
            this.chkCilt.Size = new System.Drawing.Size(40, 17);
            this.chkCilt.TabIndex = 14;
            this.chkCilt.Text = "Cilt";
            this.chkCilt.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::button._49.Properties.Resources.Sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(336, 130);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 65);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::button._49.Properties.Resources.Güncelle;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(417, 130);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 65);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::button._49.Properties.Resources.Kaydet;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(255, 130);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 65);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 266);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(507, 239);
            this.dgvListe.TabIndex = 14;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 517);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.CheckBox chkCilt;
        private System.Windows.Forms.DataGridView dgvListe;
    }
}

