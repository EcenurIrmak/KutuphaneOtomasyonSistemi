namespace KutuphaneOtomasyonuSistemi
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUyeler = new System.Windows.Forms.Button();
            this.buttonKitaplar = new System.Windows.Forms.Button();
            this.buttonOduncVer = new System.Windows.Forms.Button();
            this.buttonOduncListesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIadeEtme = new System.Windows.Forms.Button();
            this.buttonUyeEkleme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUyeler
            // 
            this.buttonUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeler.Location = new System.Drawing.Point(81, 196);
            this.buttonUyeler.Name = "buttonUyeler";
            this.buttonUyeler.Size = new System.Drawing.Size(150, 81);
            this.buttonUyeler.TabIndex = 0;
            this.buttonUyeler.Text = "ÜYELER";
            this.buttonUyeler.UseVisualStyleBackColor = true;
            this.buttonUyeler.Click += new System.EventHandler(this.buttonUyeler_Click);
            // 
            // buttonKitaplar
            // 
            this.buttonKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitaplar.Location = new System.Drawing.Point(82, 285);
            this.buttonKitaplar.Name = "buttonKitaplar";
            this.buttonKitaplar.Size = new System.Drawing.Size(150, 81);
            this.buttonKitaplar.TabIndex = 1;
            this.buttonKitaplar.Text = "KİTAPLAR";
            this.buttonKitaplar.UseVisualStyleBackColor = true;
            this.buttonKitaplar.Click += new System.EventHandler(this.buttonKitaplar_Click);
            // 
            // buttonOduncVer
            // 
            this.buttonOduncVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOduncVer.Location = new System.Drawing.Point(286, 196);
            this.buttonOduncVer.Name = "buttonOduncVer";
            this.buttonOduncVer.Size = new System.Drawing.Size(150, 81);
            this.buttonOduncVer.TabIndex = 2;
            this.buttonOduncVer.Text = "ÖDÜNÇ VER";
            this.buttonOduncVer.UseVisualStyleBackColor = true;
            this.buttonOduncVer.Click += new System.EventHandler(this.buttonOduncVer_Click);
            // 
            // buttonOduncListesi
            // 
            this.buttonOduncListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOduncListesi.Location = new System.Drawing.Point(286, 285);
            this.buttonOduncListesi.Name = "buttonOduncListesi";
            this.buttonOduncListesi.Size = new System.Drawing.Size(150, 81);
            this.buttonOduncListesi.TabIndex = 3;
            this.buttonOduncListesi.Text = "ÖDÜNÇ LİSTESİ";
            this.buttonOduncListesi.UseVisualStyleBackColor = true;
            this.buttonOduncListesi.Click += new System.EventHandler(this.buttonOduncListesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(212, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ";
            // 
            // buttonIadeEtme
            // 
            this.buttonIadeEtme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIadeEtme.Location = new System.Drawing.Point(486, 285);
            this.buttonIadeEtme.Name = "buttonIadeEtme";
            this.buttonIadeEtme.Size = new System.Drawing.Size(150, 81);
            this.buttonIadeEtme.TabIndex = 9;
            this.buttonIadeEtme.Text = "İADE ETME";
            this.buttonIadeEtme.UseVisualStyleBackColor = true;
            this.buttonIadeEtme.Click += new System.EventHandler(this.buttonIadeEtme_Click);
            // 
            // buttonUyeEkleme
            // 
            this.buttonUyeEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeEkleme.Location = new System.Drawing.Point(487, 196);
            this.buttonUyeEkleme.Name = "buttonUyeEkleme";
            this.buttonUyeEkleme.Size = new System.Drawing.Size(150, 81);
            this.buttonUyeEkleme.TabIndex = 7;
            this.buttonUyeEkleme.Text = "ÜYE EKLE";
            this.buttonUyeEkleme.UseVisualStyleBackColor = true;
            this.buttonUyeEkleme.Click += new System.EventHandler(this.buttonUyeEkleme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(313, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "SEÇİMİNİZİ YAPINIZ";
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(692, 285);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(150, 81);
            this.buttonCikis.TabIndex = 13;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapEkle.Location = new System.Drawing.Point(692, 196);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(150, 81);
            this.buttonKitapEkle.TabIndex = 12;
            this.buttonKitapEkle.Text = "KİTAP EKLE";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 518);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonKitapEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIadeEtme);
            this.Controls.Add(this.buttonUyeEkleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOduncListesi);
            this.Controls.Add(this.buttonOduncVer);
            this.Controls.Add(this.buttonKitaplar);
            this.Controls.Add(this.buttonUyeler);
            this.Name = "GirisForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUyeler;
        private System.Windows.Forms.Button buttonKitaplar;
        private System.Windows.Forms.Button buttonOduncVer;
        private System.Windows.Forms.Button buttonOduncListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIadeEtme;
        private System.Windows.Forms.Button buttonUyeEkleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonKitapEkle;
    }
}

