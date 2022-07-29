
namespace SunumKatmani
{
    partial class Kitap_Ekleme_form
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
            this.lbl_kitap_adi = new System.Windows.Forms.Label();
            this.lbl_yazar_adi = new System.Windows.Forms.Label();
            this.lbl_yayinevi = new System.Windows.Forms.Label();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_yazaradi = new System.Windows.Forms.TextBox();
            this.txt_yayınevi = new System.Windows.Forms.TextBox();
            this.bttn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kitap_adi
            // 
            this.lbl_kitap_adi.AutoSize = true;
            this.lbl_kitap_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kitap_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_kitap_adi.Location = new System.Drawing.Point(19, 60);
            this.lbl_kitap_adi.Name = "lbl_kitap_adi";
            this.lbl_kitap_adi.Size = new System.Drawing.Size(91, 20);
            this.lbl_kitap_adi.TabIndex = 0;
            this.lbl_kitap_adi.Text = "Kitap Adı :";
            // 
            // lbl_yazar_adi
            // 
            this.lbl_yazar_adi.AutoSize = true;
            this.lbl_yazar_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_yazar_adi.Location = new System.Drawing.Point(13, 109);
            this.lbl_yazar_adi.Name = "lbl_yazar_adi";
            this.lbl_yazar_adi.Size = new System.Drawing.Size(97, 20);
            this.lbl_yazar_adi.TabIndex = 1;
            this.lbl_yazar_adi.Text = "Yazar Adı :";
            // 
            // lbl_yayinevi
            // 
            this.lbl_yayinevi.AutoSize = true;
            this.lbl_yayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yayinevi.ForeColor = System.Drawing.Color.White;
            this.lbl_yayinevi.Location = new System.Drawing.Point(18, 153);
            this.lbl_yayinevi.Name = "lbl_yayinevi";
            this.lbl_yayinevi.Size = new System.Drawing.Size(92, 20);
            this.lbl_yayinevi.TabIndex = 2;
            this.lbl_yayinevi.Text = "Yayın Evi :";
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapadi.Location = new System.Drawing.Point(125, 60);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(136, 26);
            this.txt_kitapadi.TabIndex = 3;
            // 
            // txt_yazaradi
            // 
            this.txt_yazaradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazaradi.Location = new System.Drawing.Point(125, 103);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Size = new System.Drawing.Size(136, 26);
            this.txt_yazaradi.TabIndex = 4;
            // 
            // txt_yayınevi
            // 
            this.txt_yayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yayınevi.Location = new System.Drawing.Point(125, 147);
            this.txt_yayınevi.Name = "txt_yayınevi";
            this.txt_yayınevi.Size = new System.Drawing.Size(136, 26);
            this.txt_yayınevi.TabIndex = 5;
            // 
            // bttn_kaydet
            // 
            this.bttn_kaydet.BackColor = System.Drawing.Color.White;
            this.bttn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kaydet.Location = new System.Drawing.Point(125, 205);
            this.bttn_kaydet.Name = "bttn_kaydet";
            this.bttn_kaydet.Size = new System.Drawing.Size(116, 38);
            this.bttn_kaydet.TabIndex = 6;
            this.bttn_kaydet.Text = "Kaydet";
            this.bttn_kaydet.UseVisualStyleBackColor = false;
            this.bttn_kaydet.Click += new System.EventHandler(this.bttn_kaydet_Click);
            // 
            // Kitap_Ekleme_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(298, 284);
            this.Controls.Add(this.bttn_kaydet);
            this.Controls.Add(this.txt_yayınevi);
            this.Controls.Add(this.txt_yazaradi);
            this.Controls.Add(this.txt_kitapadi);
            this.Controls.Add(this.lbl_yayinevi);
            this.Controls.Add(this.lbl_yazar_adi);
            this.Controls.Add(this.lbl_kitap_adi);
            this.Name = "Kitap_Ekleme_form";
            this.Text = "Kitap_Ekleme_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kitap_adi;
        private System.Windows.Forms.Label lbl_yazar_adi;
        private System.Windows.Forms.Label lbl_yayinevi;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.TextBox txt_yazaradi;
        private System.Windows.Forms.TextBox txt_yayınevi;
        private System.Windows.Forms.Button bttn_kaydet;
    }
}