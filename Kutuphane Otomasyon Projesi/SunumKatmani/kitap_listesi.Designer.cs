
namespace SunumKatmani
{
    partial class kitap_listesi
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
            this.kitap_listele_dGV = new System.Windows.Forms.DataGridView();
            this.bttn_kitap_ekleme = new System.Windows.Forms.Button();
            this.bttn_kitap_gunc_silm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listele_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // kitap_listele_dGV
            // 
            this.kitap_listele_dGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kitap_listele_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_listele_dGV.Location = new System.Drawing.Point(13, 13);
            this.kitap_listele_dGV.Name = "kitap_listele_dGV";
            this.kitap_listele_dGV.Size = new System.Drawing.Size(409, 150);
            this.kitap_listele_dGV.TabIndex = 0;
            // 
            // bttn_kitap_ekleme
            // 
            this.bttn_kitap_ekleme.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_kitap_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kitap_ekleme.ForeColor = System.Drawing.Color.White;
            this.bttn_kitap_ekleme.Location = new System.Drawing.Point(13, 169);
            this.bttn_kitap_ekleme.Name = "bttn_kitap_ekleme";
            this.bttn_kitap_ekleme.Size = new System.Drawing.Size(201, 62);
            this.bttn_kitap_ekleme.TabIndex = 1;
            this.bttn_kitap_ekleme.Text = "Kitap Ekleme";
            this.bttn_kitap_ekleme.UseVisualStyleBackColor = false;
            this.bttn_kitap_ekleme.Click += new System.EventHandler(this.bttn_kitap_ekleme_Click);
            // 
            // bttn_kitap_gunc_silm
            // 
            this.bttn_kitap_gunc_silm.BackColor = System.Drawing.Color.DarkGray;
            this.bttn_kitap_gunc_silm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_kitap_gunc_silm.ForeColor = System.Drawing.Color.White;
            this.bttn_kitap_gunc_silm.Location = new System.Drawing.Point(220, 169);
            this.bttn_kitap_gunc_silm.Name = "bttn_kitap_gunc_silm";
            this.bttn_kitap_gunc_silm.Size = new System.Drawing.Size(201, 62);
            this.bttn_kitap_gunc_silm.TabIndex = 2;
            this.bttn_kitap_gunc_silm.Text = "Kitap Güncelle veya Sil";
            this.bttn_kitap_gunc_silm.UseVisualStyleBackColor = false;
            this.bttn_kitap_gunc_silm.Click += new System.EventHandler(this.bttn_kitap_gunc_silm_Click);
            // 
            // kitap_listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(434, 243);
            this.Controls.Add(this.bttn_kitap_gunc_silm);
            this.Controls.Add(this.bttn_kitap_ekleme);
            this.Controls.Add(this.kitap_listele_dGV);
            this.Name = "kitap_listesi";
            this.Text = "kitap_listesi";
            this.Load += new System.EventHandler(this.kitap_listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listele_dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kitap_listele_dGV;
        private System.Windows.Forms.Button bttn_kitap_ekleme;
        private System.Windows.Forms.Button bttn_kitap_gunc_silm;
    }
}