namespace filmArsiv
{
    partial class Elestiriler
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
            this.dgvEles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEles
            // 
            this.dgvEles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEles.Location = new System.Drawing.Point(12, 141);
            this.dgvEles.Name = "dgvEles";
            this.dgvEles.Size = new System.Drawing.Size(611, 225);
            this.dgvEles.TabIndex = 0;
            this.dgvEles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEles_CellContentClick);
            // 
            // Elestiriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 390);
            this.Controls.Add(this.dgvEles);
            this.Name = "Elestiriler";
            this.Text = "Elestiriler";
            this.Load += new System.EventHandler(this.Elestiriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEles;
    }
}