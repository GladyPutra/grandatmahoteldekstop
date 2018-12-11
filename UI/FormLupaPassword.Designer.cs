namespace GAHDesktop.UI
{
    partial class FormLupaPassword
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
            this.txtNamaPengguna = new System.Windows.Forms.TextBox();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.txtRandomPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPassBaru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Nama Pengguna";
            // 
            // txtNamaPengguna
            // 
            this.txtNamaPengguna.Location = new System.Drawing.Point(70, 25);
            this.txtNamaPengguna.Name = "txtNamaPengguna";
            this.txtNamaPengguna.Size = new System.Drawing.Size(126, 20);
            this.txtNamaPengguna.TabIndex = 1;
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(94, 151);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(75, 23);
            this.btnKonfirmasi.TabIndex = 2;
            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // txtRandomPass
            // 
            this.txtRandomPass.Location = new System.Drawing.Point(70, 108);
            this.txtRandomPass.Name = "txtRandomPass";
            this.txtRandomPass.Size = new System.Drawing.Size(126, 20);
            this.txtRandomPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password Baru";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(94, 180);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnPassBaru
            // 
            this.btnPassBaru.Location = new System.Drawing.Point(75, 59);
            this.btnPassBaru.Name = "btnPassBaru";
            this.btnPassBaru.Size = new System.Drawing.Size(121, 23);
            this.btnPassBaru.TabIndex = 6;
            this.btnPassBaru.Text = "Buat Password Baru";
            this.btnPassBaru.UseVisualStyleBackColor = true;
            this.btnPassBaru.Click += new System.EventHandler(this.btnPassBaru_Click);
            // 
            // FormLupaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.btnPassBaru);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRandomPass);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.txtNamaPengguna);
            this.Controls.Add(this.label1);
            this.Name = "FormLupaPassword";
            this.Text = "FormLupaPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaPengguna;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.TextBox txtRandomPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPassBaru;
    }
}