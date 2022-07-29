
namespace SunumKatmani
{
    partial class Kitap_Alma
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
            this.lbl_kullanici_no = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.bttn_alma = new System.Windows.Forms.Button();
            this.cBx_kitaplar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitaplar";
            // 
            // lbl_kullanici_no
            // 
            this.lbl_kullanici_no.AutoSize = true;
            this.lbl_kullanici_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanici_no.Location = new System.Drawing.Point(5, 22);
            this.lbl_kullanici_no.Name = "lbl_kullanici_no";
            this.lbl_kullanici_no.Size = new System.Drawing.Size(105, 20);
            this.lbl_kullanici_no.TabIndex = 3;
            this.lbl_kullanici_no.Text = "Kullanıcı NO";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(163, 21);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(121, 20);
            this.txt_no.TabIndex = 4;
            // 
            // bttn_alma
            // 
            this.bttn_alma.BackColor = System.Drawing.Color.White;
            this.bttn_alma.Enabled = false;
            this.bttn_alma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_alma.ForeColor = System.Drawing.Color.Black;
            this.bttn_alma.Location = new System.Drawing.Point(116, 113);
            this.bttn_alma.Name = "bttn_alma";
            this.bttn_alma.Size = new System.Drawing.Size(121, 41);
            this.bttn_alma.TabIndex = 5;
            this.bttn_alma.Text = "Kitap Alma";
            this.bttn_alma.UseVisualStyleBackColor = false;
            this.bttn_alma.Click += new System.EventHandler(this.bttn_alma_Click);
            // 
            // cBx_kitaplar
            // 
            this.cBx_kitaplar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBx_kitaplar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBx_kitaplar.FormattingEnabled = true;
            this.cBx_kitaplar.Location = new System.Drawing.Point(163, 47);
            this.cBx_kitaplar.Name = "cBx_kitaplar";
            this.cBx_kitaplar.Size = new System.Drawing.Size(121, 21);
            this.cBx_kitaplar.TabIndex = 6;
            this.cBx_kitaplar.SelectedIndexChanged += new System.EventHandler(this.cBx_kitaplar_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Teslim Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Kitap_Alma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(369, 175);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBx_kitaplar);
            this.Controls.Add(this.bttn_alma);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.lbl_kullanici_no);
            this.Controls.Add(this.label1);
            this.Name = "Kitap_Alma";
            this.Text = "Kitap_Alma";
            this.Load += new System.EventHandler(this.Kitap_Alma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kullanici_no;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Button bttn_alma;
        private System.Windows.Forms.ComboBox cBx_kitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}