namespace GAHDesktop.UI
{
    partial class FormKonfirmasiPembayaran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoKartu = new System.Windows.Forms.TextBox();
            this.txtId_Booking = new System.Windows.Forms.TextBox();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.lblHargaItem = new System.Windows.Forms.Label();
            this.lblHargaKamar = new System.Windows.Forms.Label();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBatalReservasi = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbNamaKamar = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRole});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRole
            // 
            this.menuRole.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keluarToolStripMenuItem});
            this.menuRole.Name = "menuRole";
            this.menuRole.Size = new System.Drawing.Size(42, 20);
            this.menuRole.Text = "Role";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konfirmasi Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detil Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fasilitas Tambahan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Bayar";
            // 
            // txtNoKartu
            // 
            this.txtNoKartu.Location = new System.Drawing.Point(211, 127);
            this.txtNoKartu.Name = "txtNoKartu";
            this.txtNoKartu.Size = new System.Drawing.Size(119, 20);
            this.txtNoKartu.TabIndex = 10;
            this.txtNoKartu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoKartu_KeyPress);
            // 
            // txtId_Booking
            // 
            this.txtId_Booking.Location = new System.Drawing.Point(381, 82);
            this.txtId_Booking.Name = "txtId_Booking";
            this.txtId_Booking.Size = new System.Drawing.Size(83, 20);
            this.txtId_Booking.TabIndex = 12;
            this.txtId_Booking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_Booking_KeyDown);
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(378, 258);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(35, 13);
            this.lblTotalHarga.TabIndex = 15;
            this.lblTotalHarga.Text = "label7";
            // 
            // lblHargaItem
            // 
            this.lblHargaItem.AutoSize = true;
            this.lblHargaItem.Location = new System.Drawing.Point(378, 227);
            this.lblHargaItem.Name = "lblHargaItem";
            this.lblHargaItem.Size = new System.Drawing.Size(35, 13);
            this.lblHargaItem.TabIndex = 16;
            this.lblHargaItem.Text = "label8";
            // 
            // lblHargaKamar
            // 
            this.lblHargaKamar.AutoSize = true;
            this.lblHargaKamar.Location = new System.Drawing.Point(378, 174);
            this.lblHargaKamar.Name = "lblHargaKamar";
            this.lblHargaKamar.Size = new System.Drawing.Size(35, 13);
            this.lblHargaKamar.TabIndex = 17;
            this.lblHargaKamar.Text = "label5";
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(210, 291);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(75, 39);
            this.btnKonfirmasi.TabIndex = 18;
            this.btnKonfirmasi.Text = "Konfrimasi Pembayaran";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Tampil Nota";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Kirim Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBatalReservasi
            // 
            this.btnBatalReservasi.Location = new System.Drawing.Point(354, 323);
            this.btnBatalReservasi.Name = "btnBatalReservasi";
            this.btnBatalReservasi.Size = new System.Drawing.Size(75, 36);
            this.btnBatalReservasi.TabIndex = 21;
            this.btnBatalReservasi.Text = "Batal Reservasi";
            this.btnBatalReservasi.UseVisualStyleBackColor = true;
            this.btnBatalReservasi.Click += new System.EventHandler(this.btnBatalReservasi_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(148, 27);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(83, 20);
            this.txtCari.TabIndex = 24;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(210, 224);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 25;
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Transfer",
            "Kredit"});
            this.cmbJenis.Location = new System.Drawing.Point(210, 101);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(121, 21);
            this.cmbJenis.TabIndex = 26;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // cmbNamaKamar
            // 
            this.cmbNamaKamar.FormattingEnabled = true;
            this.cmbNamaKamar.Location = new System.Drawing.Point(209, 174);
            this.cmbNamaKamar.Name = "cmbNamaKamar";
            this.cmbNamaKamar.Size = new System.Drawing.Size(121, 21);
            this.cmbNamaKamar.TabIndex = 27;
            // 
            // FormKonfirmasiPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 395);
            this.Controls.Add(this.cmbNamaKamar);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnBatalReservasi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.lblHargaKamar);
            this.Controls.Add(this.lblHargaItem);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.txtId_Booking);
            this.Controls.Add(this.txtNoKartu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKonfirmasiPembayaran";
            this.Text = "FormKonfirmasiPembayaran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRole;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoKartu;
        private System.Windows.Forms.TextBox txtId_Booking;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblHargaItem;
        private System.Windows.Forms.Label lblHargaKamar;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBatalReservasi;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.ComboBox cmbNamaKamar;

    }
}