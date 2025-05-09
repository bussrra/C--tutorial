namespace button._59
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
            this.mtTc = new System.Windows.Forms.MaskedTextBox();
            this.mtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtDogum = new System.Windows.Forms.MaskedTextBox();
            this.mtKart = new System.Windows.Forms.MaskedTextBox();
            this.mtIp = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtTc
            // 
            this.mtTc.Location = new System.Drawing.Point(110, 32);
            this.mtTc.Name = "mtTc";
            this.mtTc.Size = new System.Drawing.Size(111, 20);
            this.mtTc.TabIndex = 0;
            // 
            // mtTelefon
            // 
            this.mtTelefon.Location = new System.Drawing.Point(110, 68);
            this.mtTelefon.Name = "mtTelefon";
            this.mtTelefon.Size = new System.Drawing.Size(111, 20);
            this.mtTelefon.TabIndex = 1;
            // 
            // mtDogum
            // 
            this.mtDogum.Location = new System.Drawing.Point(110, 104);
            this.mtDogum.Name = "mtDogum";
            this.mtDogum.Size = new System.Drawing.Size(111, 20);
            this.mtDogum.TabIndex = 2;
            // 
            // mtKart
            // 
            this.mtKart.Location = new System.Drawing.Point(110, 141);
            this.mtKart.Name = "mtKart";
            this.mtKart.Size = new System.Drawing.Size(111, 20);
            this.mtKart.TabIndex = 2;
            // 
            // mtIp
            // 
            this.mtIp.Location = new System.Drawing.Point(110, 179);
            this.mtIp.Name = "mtIp";
            this.mtIp.Size = new System.Drawing.Size(111, 20);
            this.mtIp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP Adresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtIp);
            this.Controls.Add(this.mtKart);
            this.Controls.Add(this.mtDogum);
            this.Controls.Add(this.mtTelefon);
            this.Controls.Add(this.mtTc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtTc;
        private System.Windows.Forms.MaskedTextBox mtTelefon;
        private System.Windows.Forms.MaskedTextBox mtDogum;
        private System.Windows.Forms.MaskedTextBox mtKart;
        private System.Windows.Forms.MaskedTextBox mtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

