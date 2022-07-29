
namespace SunumKatmani
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
            this.kitap_listele_bttn = new System.Windows.Forms.Button();
            this.bttn_kullanici = new System.Windows.Forms.Button();
            this.bttn_alma = new System.Windows.Forms.Button();
            this.bttn_iade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kitap_listele_bttn
            // 
            this.kitap_listele_bttn.BackColor = System.Drawing.Color.Gray;
            this.kitap_listele_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_listele_bttn.ForeColor = System.Drawing.Color.White;
            this.kitap_listele_bttn.Location = new System.Drawing.Point(37, 12);
            this.kitap_listele_bttn.Name = "kitap_listele_bttn";
            this.kitap_listele_bttn.Size = new System.Drawing.Size(118, 50);
            this.kitap_listele_bttn.TabIndex = 0;
            this.kitap_listele_bttn.Text = "Kitaplar";
            this.kitap_listele_bttn.UseVisualStyleBackColor = false;
            this.kitap_listele_bttn.Click += new System.EventHandler(this.kitap_listele_bttn_Click);
            // 
            // bttn_kullanici
            // 
            this.bttn_kullanici.BackColor = System.Drawing.Color.Gray;
            this.bttn_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kullanici.ForeColor = System.Drawing.Color.White;
            this.bttn_kullanici.Location = new System.Drawing.Point(37, 68);
            this.bttn_kullanici.Name = "bttn_kullanici";
            this.bttn_kullanici.Size = new System.Drawing.Size(118, 50);
            this.bttn_kullanici.TabIndex = 1;
            this.bttn_kullanici.Text = "Kullanıcılar";
            this.bttn_kullanici.UseVisualStyleBackColor = false;
            this.bttn_kullanici.Click += new System.EventHandler(this.bttn_kullanici_Click);
            // 
            // bttn_alma
            // 
            this.bttn_alma.BackColor = System.Drawing.Color.Gray;
            this.bttn_alma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_alma.ForeColor = System.Drawing.Color.White;
            this.bttn_alma.Location = new System.Drawing.Point(37, 123);
            this.bttn_alma.Name = "bttn_alma";
            this.bttn_alma.Size = new System.Drawing.Size(118, 50);
            this.bttn_alma.TabIndex = 2;
            this.bttn_alma.Text = "Kitap Alma";
            this.bttn_alma.UseVisualStyleBackColor = false;
            this.bttn_alma.Click += new System.EventHandler(this.bttn_alma_Click);
            // 
            // bttn_iade
            // 
            this.bttn_iade.BackColor = System.Drawing.Color.Gray;
            this.bttn_iade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_iade.ForeColor = System.Drawing.Color.White;
            this.bttn_iade.Location = new System.Drawing.Point(37, 179);
            this.bttn_iade.Name = "bttn_iade";
            this.bttn_iade.Size = new System.Drawing.Size(118, 50);
            this.bttn_iade.TabIndex = 3;
            this.bttn_iade.Text = "Kitap iade";
            this.bttn_iade.UseVisualStyleBackColor = false;
            this.bttn_iade.Click += new System.EventHandler(this.bttn_iade_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grafik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(184, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttn_iade);
            this.Controls.Add(this.bttn_alma);
            this.Controls.Add(this.bttn_kullanici);
            this.Controls.Add(this.kitap_listele_bttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kitap_listele_bttn;
        private System.Windows.Forms.Button bttn_kullanici;
        private System.Windows.Forms.Button bttn_alma;
        private System.Windows.Forms.Button bttn_iade;
        private System.Windows.Forms.Button button1;
    }
}

