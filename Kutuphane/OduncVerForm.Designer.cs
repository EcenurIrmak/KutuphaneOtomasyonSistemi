namespace KutuphaneOtomasyonuSistemi
{
    partial class OduncVerForm
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
            this.dtAlis = new System.Windows.Forms.DateTimePicker();
            this.dtTeslim = new System.Windows.Forms.DateTimePicker();
            this.cbUye = new System.Windows.Forms.ComboBox();
            this.cbKopya = new System.Windows.Forms.ComboBox();
            this.cbKitap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "KOPYA: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALIŞ TARİHİ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "SON TESLİM TARİHİ: ";
            // 
            // dtAlis
            // 
            this.dtAlis.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtAlis.Location = new System.Drawing.Point(382, 193);
            this.dtAlis.Name = "dtAlis";
            this.dtAlis.Size = new System.Drawing.Size(341, 31);
            this.dtAlis.TabIndex = 6;
            this.dtAlis.ValueChanged += new System.EventHandler(this.dtAlis_ValueChanged);
            // 
            // dtTeslim
            // 
            this.dtTeslim.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTeslim.Location = new System.Drawing.Point(382, 240);
            this.dtTeslim.Name = "dtTeslim";
            this.dtTeslim.Size = new System.Drawing.Size(341, 31);
            this.dtTeslim.TabIndex = 7;
            // 
            // cbUye
            // 
            this.cbUye.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUye.FormattingEnabled = true;
            this.cbUye.Location = new System.Drawing.Point(382, 62);
            this.cbUye.Name = "cbUye";
            this.cbUye.Size = new System.Drawing.Size(341, 32);
            this.cbUye.TabIndex = 8;
            // 
            // cbKopya
            // 
            this.cbKopya.Enabled = false;
            this.cbKopya.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKopya.FormattingEnabled = true;
            this.cbKopya.Location = new System.Drawing.Point(382, 149);
            this.cbKopya.Name = "cbKopya";
            this.cbKopya.Size = new System.Drawing.Size(341, 32);
            this.cbKopya.TabIndex = 9;
            // 
            // cbKitap
            // 
            this.cbKitap.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKitap.FormattingEnabled = true;
            this.cbKitap.Location = new System.Drawing.Point(382, 105);
            this.cbKitap.Name = "cbKitap";
            this.cbKitap.Size = new System.Drawing.Size(341, 32);
            this.cbKitap.TabIndex = 10;
            this.cbKitap.SelectedIndexChanged += new System.EventHandler(this.cbKitap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "ÜYELER:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(287, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OduncVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbKitap);
            this.Controls.Add(this.cbKopya);
            this.Controls.Add(this.cbUye);
            this.Controls.Add(this.dtTeslim);
            this.Controls.Add(this.dtAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OduncVerForm";
            this.Text = "OduncVerForm";
            this.Load += new System.EventHandler(this.OduncVerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtAlis;
        private System.Windows.Forms.DateTimePicker dtTeslim;
        private System.Windows.Forms.ComboBox cbUye;
        private System.Windows.Forms.ComboBox cbKopya;
        private System.Windows.Forms.ComboBox cbKitap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}