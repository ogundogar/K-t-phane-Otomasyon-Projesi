
namespace SunumKatmani
{
    partial class kitap_silme_guncelleme
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
            this.lbl_kitapID = new System.Windows.Forms.Label();
            this.lbl_kitapAdi = new System.Windows.Forms.Label();
            this.lbl_YazarAdi = new System.Windows.Forms.Label();
            this.lbl_YayınEvi = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_yazaradi = new System.Windows.Forms.TextBox();
            this.txt_yayınevi = new System.Windows.Forms.TextBox();
            this.bttn_guncelle = new System.Windows.Forms.Button();
            this.bttn_Sil = new System.Windows.Forms.Button();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_silme = new System.Windows.Forms.Label();
            this.txt_silme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kitapID
            // 
            this.lbl_kitapID.AutoSize = true;
            this.lbl_kitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapID.ForeColor = System.Drawing.Color.White;
            this.lbl_kitapID.Location = new System.Drawing.Point(36, 57);
            this.lbl_kitapID.Name = "lbl_kitapID";
            this.lbl_kitapID.Size = new System.Drawing.Size(84, 20);
            this.lbl_kitapID.TabIndex = 0;
            this.lbl_kitapID.Text = "Kitap ID :";
            // 
            // lbl_kitapAdi
            // 
            this.lbl_kitapAdi.AutoSize = true;
            this.lbl_kitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitapAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_kitapAdi.Location = new System.Drawing.Point(29, 96);
            this.lbl_kitapAdi.Name = "lbl_kitapAdi";
            this.lbl_kitapAdi.Size = new System.Drawing.Size(91, 20);
            this.lbl_kitapAdi.TabIndex = 1;
            this.lbl_kitapAdi.Text = "Kitap Adı :";
            // 
            // lbl_YazarAdi
            // 
            this.lbl_YazarAdi.AutoSize = true;
            this.lbl_YazarAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YazarAdi.ForeColor = System.Drawing.Color.White;
            this.lbl_YazarAdi.Location = new System.Drawing.Point(23, 130);
            this.lbl_YazarAdi.Name = "lbl_YazarAdi";
            this.lbl_YazarAdi.Size = new System.Drawing.Size(97, 20);
            this.lbl_YazarAdi.TabIndex = 2;
            this.lbl_YazarAdi.Text = "Yazar Adı :";
            // 
            // lbl_YayınEvi
            // 
            this.lbl_YayınEvi.AutoSize = true;
            this.lbl_YayınEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YayınEvi.ForeColor = System.Drawing.Color.White;
            this.lbl_YayınEvi.Location = new System.Drawing.Point(28, 165);
            this.lbl_YayınEvi.Name = "lbl_YayınEvi";
            this.lbl_YayınEvi.Size = new System.Drawing.Size(92, 20);
            this.lbl_YayınEvi.TabIndex = 3;
            this.lbl_YayınEvi.Text = "Yayın Evi :";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(126, 57);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_yazaradi
            // 
            this.txt_yazaradi.Location = new System.Drawing.Point(126, 130);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Size = new System.Drawing.Size(100, 20);
            this.txt_yazaradi.TabIndex = 6;
            // 
            // txt_yayınevi
            // 
            this.txt_yayınevi.Location = new System.Drawing.Point(126, 165);
            this.txt_yayınevi.Name = "txt_yayınevi";
            this.txt_yayınevi.Size = new System.Drawing.Size(100, 20);
            this.txt_yayınevi.TabIndex = 7;
            // 
            // bttn_guncelle
            // 
            this.bttn_guncelle.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_guncelle.ForeColor = System.Drawing.Color.White;
            this.bttn_guncelle.Location = new System.Drawing.Point(27, 203);
            this.bttn_guncelle.Name = "bttn_guncelle";
            this.bttn_guncelle.Size = new System.Drawing.Size(93, 32);
            this.bttn_guncelle.TabIndex = 8;
            this.bttn_guncelle.Text = "Güncelle";
            this.bttn_guncelle.UseVisualStyleBackColor = false;
            this.bttn_guncelle.Click += new System.EventHandler(this.bttn_guncelle_Click);
            // 
            // bttn_Sil
            // 
            this.bttn_Sil.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_Sil.ForeColor = System.Drawing.Color.White;
            this.bttn_Sil.Location = new System.Drawing.Point(126, 203);
            this.bttn_Sil.Name = "bttn_Sil";
            this.bttn_Sil.Size = new System.Drawing.Size(93, 32);
            this.bttn_Sil.TabIndex = 9;
            this.bttn_Sil.Text = "Sil";
            this.bttn_Sil.UseVisualStyleBackColor = false;
            this.bttn_Sil.Click += new System.EventHandler(this.bttn_Sil_Click);
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(126, 96);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapadi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 234);
            this.dataGridView1.TabIndex = 11;
            // 
            // lbl_silme
            // 
            this.lbl_silme.AutoSize = true;
            this.lbl_silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_silme.ForeColor = System.Drawing.Color.White;
            this.lbl_silme.Location = new System.Drawing.Point(12, 25);
            this.lbl_silme.Name = "lbl_silme";
            this.lbl_silme.Size = new System.Drawing.Size(109, 20);
            this.lbl_silme.TabIndex = 12;
            this.lbl_silme.Text = "Kitap Silme :";
            // 
            // txt_silme
            // 
            this.txt_silme.Location = new System.Drawing.Point(126, 25);
            this.txt_silme.Name = "txt_silme";
            this.txt_silme.Size = new System.Drawing.Size(100, 20);
            this.txt_silme.TabIndex = 13;
            // 
            // kitap_silme_guncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.txt_silme);
            this.Controls.Add(this.lbl_silme);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kitapadi);
            this.Controls.Add(this.bttn_Sil);
            this.Controls.Add(this.bttn_guncelle);
            this.Controls.Add(this.txt_yayınevi);
            this.Controls.Add(this.txt_yazaradi);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_YayınEvi);
            this.Controls.Add(this.lbl_YazarAdi);
            this.Controls.Add(this.lbl_kitapAdi);
            this.Controls.Add(this.lbl_kitapID);
            this.Name = "kitap_silme_guncelleme";
            this.Text = "kitap_silme_guncelleme";
            this.Load += new System.EventHandler(this.kitap_silme_guncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kitapID;
        private System.Windows.Forms.Label lbl_kitapAdi;
        private System.Windows.Forms.Label lbl_YazarAdi;
        private System.Windows.Forms.Label lbl_YayınEvi;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_yazaradi;
        private System.Windows.Forms.TextBox txt_yayınevi;
        private System.Windows.Forms.Button bttn_guncelle;
        private System.Windows.Forms.Button bttn_Sil;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_silme;
        private System.Windows.Forms.TextBox txt_silme;
    }
}