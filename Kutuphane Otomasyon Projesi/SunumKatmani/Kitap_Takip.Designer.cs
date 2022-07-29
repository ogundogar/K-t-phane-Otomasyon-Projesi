
namespace SunumKatmani
{
    partial class Kitap_Takip
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
            this.txt_k_NO = new System.Windows.Forms.TextBox();
            this.bttn_tmm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı No";
            // 
            // txt_k_NO
            // 
            this.txt_k_NO.Location = new System.Drawing.Point(121, 13);
            this.txt_k_NO.Name = "txt_k_NO";
            this.txt_k_NO.Size = new System.Drawing.Size(99, 20);
            this.txt_k_NO.TabIndex = 1;
            // 
            // bttn_tmm
            // 
            this.bttn_tmm.BackColor = System.Drawing.Color.LightBlue;
            this.bttn_tmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_tmm.ForeColor = System.Drawing.Color.Black;
            this.bttn_tmm.Location = new System.Drawing.Point(17, 209);
            this.bttn_tmm.Name = "bttn_tmm";
            this.bttn_tmm.Size = new System.Drawing.Size(125, 56);
            this.bttn_tmm.TabIndex = 3;
            this.bttn_tmm.Text = "Tamam";
            this.bttn_tmm.UseVisualStyleBackColor = false;
            this.bttn_tmm.Click += new System.EventHandler(this.bttn_tmm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Kitap_Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(568, 293);
            this.Controls.Add(this.bttn_tmm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_k_NO);
            this.Controls.Add(this.label1);
            this.Name = "Kitap_Takip";
            this.Text = "Kitap_Takip";
            this.Load += new System.EventHandler(this.Kitap_Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_k_NO;
        private System.Windows.Forms.Button bttn_tmm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}