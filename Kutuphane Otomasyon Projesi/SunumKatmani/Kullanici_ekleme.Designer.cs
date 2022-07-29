
namespace SunumKatmani
{
    partial class Kullanici_ekleme
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
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.lbl_Kullancisoyad = new System.Windows.Forms.Label();
            this.lbl_NO = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.bttn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(13, 31);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(106, 20);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(156, 33);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 1;
            // 
            // lbl_Kullancisoyad
            // 
            this.lbl_Kullancisoyad.AutoSize = true;
            this.lbl_Kullancisoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullancisoyad.Location = new System.Drawing.Point(13, 75);
            this.lbl_Kullancisoyad.Name = "lbl_Kullancisoyad";
            this.lbl_Kullancisoyad.Size = new System.Drawing.Size(134, 20);
            this.lbl_Kullancisoyad.TabIndex = 2;
            this.lbl_Kullancisoyad.Text = "Kullanıcı Soyadı";
            // 
            // lbl_NO
            // 
            this.lbl_NO.AutoSize = true;
            this.lbl_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_NO.Location = new System.Drawing.Point(13, 122);
            this.lbl_NO.Name = "lbl_NO";
            this.lbl_NO.Size = new System.Drawing.Size(105, 20);
            this.lbl_NO.TabIndex = 3;
            this.lbl_NO.Text = "Kullanıcı NO";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(156, 77);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 4;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(156, 124);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 5;
            // 
            // bttn_kaydet
            // 
            this.bttn_kaydet.BackColor = System.Drawing.Color.LightBlue;
            this.bttn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kaydet.ForeColor = System.Drawing.Color.Black;
            this.bttn_kaydet.Location = new System.Drawing.Point(89, 176);
            this.bttn_kaydet.Name = "bttn_kaydet";
            this.bttn_kaydet.Size = new System.Drawing.Size(100, 36);
            this.bttn_kaydet.TabIndex = 6;
            this.bttn_kaydet.Text = "Kaydet";
            this.bttn_kaydet.UseVisualStyleBackColor = false;
            this.bttn_kaydet.Click += new System.EventHandler(this.bttn_kaydet_Click);
            // 
            // Kullanici_ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.bttn_kaydet);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_NO);
            this.Controls.Add(this.lbl_Kullancisoyad);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Name = "Kullanici_ekleme";
            this.Text = "Kullanici_ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label lbl_Kullancisoyad;
        private System.Windows.Forms.Label lbl_NO;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Button bttn_kaydet;
    }
}