
namespace SunumKatmani
{
    partial class kullanici_guncelle_sil
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
            this.txt_silme = new System.Windows.Forms.TextBox();
            this.lbl_silme = new System.Windows.Forms.Label();
            this.dGv_listele = new System.Windows.Forms.DataGridView();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.bttn_Sil = new System.Windows.Forms.Button();
            this.bttn_guncelle = new System.Windows.Forms.Button();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_YayınEvi = new System.Windows.Forms.Label();
            this.lbl_soyadı = new System.Windows.Forms.Label();
            this.lbl_adı = new System.Windows.Forms.Label();
            this.lbl_kullaniciID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_listele)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_silme
            // 
            this.txt_silme.Location = new System.Drawing.Point(139, 25);
            this.txt_silme.Name = "txt_silme";
            this.txt_silme.Size = new System.Drawing.Size(100, 20);
            this.txt_silme.TabIndex = 26;
            // 
            // lbl_silme
            // 
            this.lbl_silme.AutoSize = true;
            this.lbl_silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_silme.ForeColor = System.Drawing.Color.White;
            this.lbl_silme.Location = new System.Drawing.Point(9, 25);
            this.lbl_silme.Name = "lbl_silme";
            this.lbl_silme.Size = new System.Drawing.Size(124, 20);
            this.lbl_silme.TabIndex = 25;
            this.lbl_silme.Text = "Kullanıcı Silme";
            // 
            // dGv_listele
            // 
            this.dGv_listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_listele.Location = new System.Drawing.Point(269, 12);
            this.dGv_listele.Name = "dGv_listele";
            this.dGv_listele.Size = new System.Drawing.Size(401, 234);
            this.dGv_listele.TabIndex = 24;
            this.dGv_listele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_listele_CellContentClick);
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(139, 96);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 23;
            // 
            // bttn_Sil
            // 
            this.bttn_Sil.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_Sil.ForeColor = System.Drawing.Color.White;
            this.bttn_Sil.Location = new System.Drawing.Point(139, 203);
            this.bttn_Sil.Name = "bttn_Sil";
            this.bttn_Sil.Size = new System.Drawing.Size(93, 32);
            this.bttn_Sil.TabIndex = 22;
            this.bttn_Sil.Text = "Sil";
            this.bttn_Sil.UseVisualStyleBackColor = false;
            this.bttn_Sil.Click += new System.EventHandler(this.bttn_Sil_Click);
            // 
            // bttn_guncelle
            // 
            this.bttn_guncelle.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_guncelle.ForeColor = System.Drawing.Color.White;
            this.bttn_guncelle.Location = new System.Drawing.Point(24, 203);
            this.bttn_guncelle.Name = "bttn_guncelle";
            this.bttn_guncelle.Size = new System.Drawing.Size(93, 32);
            this.bttn_guncelle.TabIndex = 21;
            this.bttn_guncelle.Text = "Güncelle";
            this.bttn_guncelle.UseVisualStyleBackColor = false;
            this.bttn_guncelle.Click += new System.EventHandler(this.bttn_guncelle_Click);
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(139, 167);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(100, 20);
            this.txt_No.TabIndex = 20;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(139, 132);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 19;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(139, 59);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 18;
            // 
            // lbl_YayınEvi
            // 
            this.lbl_YayınEvi.AutoSize = true;
            this.lbl_YayınEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YayınEvi.ForeColor = System.Drawing.Color.White;
            this.lbl_YayınEvi.Location = new System.Drawing.Point(25, 165);
            this.lbl_YayınEvi.Name = "lbl_YayınEvi";
            this.lbl_YayınEvi.Size = new System.Drawing.Size(102, 20);
            this.lbl_YayınEvi.TabIndex = 17;
            this.lbl_YayınEvi.Text = "Kullanıcı No";
            // 
            // lbl_soyadı
            // 
            this.lbl_soyadı.AutoSize = true;
            this.lbl_soyadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadı.ForeColor = System.Drawing.Color.White;
            this.lbl_soyadı.Location = new System.Drawing.Point(3, 132);
            this.lbl_soyadı.Name = "lbl_soyadı";
            this.lbl_soyadı.Size = new System.Drawing.Size(134, 20);
            this.lbl_soyadı.TabIndex = 16;
            this.lbl_soyadı.Text = "Kullanıcı Soyadı";
            // 
            // lbl_adı
            // 
            this.lbl_adı.AutoSize = true;
            this.lbl_adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adı.ForeColor = System.Drawing.Color.White;
            this.lbl_adı.Location = new System.Drawing.Point(26, 96);
            this.lbl_adı.Name = "lbl_adı";
            this.lbl_adı.Size = new System.Drawing.Size(111, 20);
            this.lbl_adı.TabIndex = 15;
            this.lbl_adı.Text = "Kullanıcı Adı ";
            // 
            // lbl_kullaniciID
            // 
            this.lbl_kullaniciID.AutoSize = true;
            this.lbl_kullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciID.ForeColor = System.Drawing.Color.White;
            this.lbl_kullaniciID.Location = new System.Drawing.Point(24, 59);
            this.lbl_kullaniciID.Name = "lbl_kullaniciID";
            this.lbl_kullaniciID.Size = new System.Drawing.Size(104, 20);
            this.lbl_kullaniciID.TabIndex = 14;
            this.lbl_kullaniciID.Text = "Kullanıcı ID ";
            // 
            // kullanici_guncelle_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(694, 263);
            this.Controls.Add(this.txt_silme);
            this.Controls.Add(this.lbl_silme);
            this.Controls.Add(this.dGv_listele);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.bttn_Sil);
            this.Controls.Add(this.bttn_guncelle);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_YayınEvi);
            this.Controls.Add(this.lbl_soyadı);
            this.Controls.Add(this.lbl_adı);
            this.Controls.Add(this.lbl_kullaniciID);
            this.Name = "kullanici_guncelle_sil";
            this.Text = "kullanici_guncelle_sil";
            this.Load += new System.EventHandler(this.kullanici_guncelle_sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_silme;
        private System.Windows.Forms.Label lbl_silme;
        private System.Windows.Forms.DataGridView dGv_listele;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Button bttn_Sil;
        private System.Windows.Forms.Button bttn_guncelle;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_YayınEvi;
        private System.Windows.Forms.Label lbl_soyadı;
        private System.Windows.Forms.Label lbl_adı;
        private System.Windows.Forms.Label lbl_kullaniciID;
    }
}