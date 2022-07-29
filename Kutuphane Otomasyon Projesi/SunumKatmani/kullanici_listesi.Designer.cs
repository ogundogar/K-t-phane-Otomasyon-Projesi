
namespace SunumKatmani
{
    partial class kullanici_listesi
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
            this.dGv_kullanici_liste = new System.Windows.Forms.DataGridView();
            this.bttn_kullanici_ekle = new System.Windows.Forms.Button();
            this.bttn_kullanci_sil_guncelle = new System.Windows.Forms.Button();
            this.bttn_takip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_kullanici_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // dGv_kullanici_liste
            // 
            this.dGv_kullanici_liste.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGv_kullanici_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_kullanici_liste.Location = new System.Drawing.Point(13, 12);
            this.dGv_kullanici_liste.Name = "dGv_kullanici_liste";
            this.dGv_kullanici_liste.Size = new System.Drawing.Size(417, 176);
            this.dGv_kullanici_liste.TabIndex = 0;
            // 
            // bttn_kullanici_ekle
            // 
            this.bttn_kullanici_ekle.BackColor = System.Drawing.Color.LightBlue;
            this.bttn_kullanici_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kullanici_ekle.ForeColor = System.Drawing.Color.Black;
            this.bttn_kullanici_ekle.Location = new System.Drawing.Point(13, 194);
            this.bttn_kullanici_ekle.Name = "bttn_kullanici_ekle";
            this.bttn_kullanici_ekle.Size = new System.Drawing.Size(125, 56);
            this.bttn_kullanici_ekle.TabIndex = 1;
            this.bttn_kullanici_ekle.Text = "Kullanici Ekle";
            this.bttn_kullanici_ekle.UseVisualStyleBackColor = false;
            this.bttn_kullanici_ekle.Click += new System.EventHandler(this.bttn_kullanici_ekle_Click);
            // 
            // bttn_kullanci_sil_guncelle
            // 
            this.bttn_kullanci_sil_guncelle.BackColor = System.Drawing.Color.LightBlue;
            this.bttn_kullanci_sil_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kullanci_sil_guncelle.ForeColor = System.Drawing.Color.Black;
            this.bttn_kullanci_sil_guncelle.Location = new System.Drawing.Point(156, 194);
            this.bttn_kullanci_sil_guncelle.Name = "bttn_kullanci_sil_guncelle";
            this.bttn_kullanci_sil_guncelle.Size = new System.Drawing.Size(125, 56);
            this.bttn_kullanci_sil_guncelle.TabIndex = 2;
            this.bttn_kullanci_sil_guncelle.Text = "Kullanıcı Güncelleme Silme";
            this.bttn_kullanci_sil_guncelle.UseVisualStyleBackColor = false;
            this.bttn_kullanci_sil_guncelle.Click += new System.EventHandler(this.bttn_kullanci_sil_guncelle_Click);
            // 
            // bttn_takip
            // 
            this.bttn_takip.BackColor = System.Drawing.Color.LightBlue;
            this.bttn_takip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_takip.ForeColor = System.Drawing.Color.Black;
            this.bttn_takip.Location = new System.Drawing.Point(305, 194);
            this.bttn_takip.Name = "bttn_takip";
            this.bttn_takip.Size = new System.Drawing.Size(125, 56);
            this.bttn_takip.TabIndex = 3;
            this.bttn_takip.Text = "Kitap Takip";
            this.bttn_takip.UseVisualStyleBackColor = false;
            this.bttn_takip.Click += new System.EventHandler(this.bttn_takip_Click);
            // 
            // kullanici_listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(444, 275);
            this.Controls.Add(this.bttn_takip);
            this.Controls.Add(this.bttn_kullanci_sil_guncelle);
            this.Controls.Add(this.bttn_kullanici_ekle);
            this.Controls.Add(this.dGv_kullanici_liste);
            this.Name = "kullanici_listesi";
            this.Text = "kullanici_listesi";
            this.Load += new System.EventHandler(this.kullanici_listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_kullanici_liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGv_kullanici_liste;
        private System.Windows.Forms.Button bttn_kullanici_ekle;
        private System.Windows.Forms.Button bttn_kullanci_sil_guncelle;
        private System.Windows.Forms.Button bttn_takip;
    }
}