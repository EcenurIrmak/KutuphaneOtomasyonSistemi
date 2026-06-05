namespace KutuphaneOtomasyonuSistemi
{
    partial class OduncListesiForm
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
            this.dgvOduncListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOduncListesi
            // 
            this.dgvOduncListesi.AllowUserToAddRows = false;
            this.dgvOduncListesi.AllowUserToDeleteRows = false;
            this.dgvOduncListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOduncListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvOduncListesi.Name = "dgvOduncListesi";
            this.dgvOduncListesi.ReadOnly = true;
            this.dgvOduncListesi.RowHeadersWidth = 51;
            this.dgvOduncListesi.RowTemplate.Height = 24;
            this.dgvOduncListesi.Size = new System.Drawing.Size(800, 450);
            this.dgvOduncListesi.TabIndex = 1;
            // 
            // OduncListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOduncListesi);
            this.Name = "OduncListesiForm";
            this.Text = "OduncListesiForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OduncListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOduncListesi;
    }
}