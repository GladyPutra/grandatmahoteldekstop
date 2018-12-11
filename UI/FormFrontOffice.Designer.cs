namespace GAHDesktop.UI
{
    partial class FormFrontOffice
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
            this.dgViewCheck = new System.Windows.Forms.DataGridView();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgView2 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtJumlahDesawa = new System.Windows.Forms.TextBox();
            this.txtJumlahAnak = new System.Windows.Forms.TextBox();
            this.txtJumlahTamu = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtNamaKamar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnChekIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tempTgl = new System.Windows.Forms.DateTimePicker();
            this.btnKonfrimasi = new System.Windows.Forms.Button();
            this.txtNoKartu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJenisTamu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewCheck
            // 
            this.dgViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCheck.Location = new System.Drawing.Point(12, 84);
            this.dgViewCheck.Name = "dgViewCheck";
            this.dgViewCheck.Size = new System.Drawing.Size(413, 366);
            this.dgViewCheck.TabIndex = 0;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(431, 84);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(289, 366);
            this.dgView.TabIndex = 1;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konfirmasi Pembayaran";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRole});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(301, 87);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 20);
            this.txtCari.TabIndex = 4;
            this.txtCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // dgView2
            // 
            this.dgView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView2.Location = new System.Drawing.Point(29, 118);
            this.dgView2.Name = "dgView2";
            this.dgView2.Size = new System.Drawing.Size(372, 114);
            this.dgView2.TabIndex = 5;
            this.dgView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView2_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 118);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(102, 144);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(114, 20);
            this.txtNama.TabIndex = 7;
            // 
            // txtJumlahDesawa
            // 
            this.txtJumlahDesawa.Location = new System.Drawing.Point(102, 202);
            this.txtJumlahDesawa.Name = "txtJumlahDesawa";
            this.txtJumlahDesawa.Size = new System.Drawing.Size(114, 20);
            this.txtJumlahDesawa.TabIndex = 14;
            // 
            // txtJumlahAnak
            // 
            this.txtJumlahAnak.Location = new System.Drawing.Point(102, 228);
            this.txtJumlahAnak.Name = "txtJumlahAnak";
            this.txtJumlahAnak.Size = new System.Drawing.Size(114, 20);
            this.txtJumlahAnak.TabIndex = 15;
            // 
            // txtJumlahTamu
            // 
            this.txtJumlahTamu.Location = new System.Drawing.Point(301, 202);
            this.txtJumlahTamu.Name = "txtJumlahTamu";
            this.txtJumlahTamu.Size = new System.Drawing.Size(100, 20);
            this.txtJumlahTamu.TabIndex = 16;
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(301, 228);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(100, 20);
            this.txtKota.TabIndex = 17;
            // 
            // txtNamaKamar
            // 
            this.txtNamaKamar.Location = new System.Drawing.Point(102, 254);
            this.txtNamaKamar.Name = "txtNamaKamar";
            this.txtNamaKamar.Size = new System.Drawing.Size(114, 20);
            this.txtNamaKamar.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Item tambah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID Booking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dewasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Anak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Jenis Kamar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Jumlah Tamu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Kota";
            // 
            // btnChekIn
            // 
            this.btnChekIn.Location = new System.Drawing.Point(130, 411);
            this.btnChekIn.Name = "btnChekIn";
            this.btnChekIn.Size = new System.Drawing.Size(75, 23);
            this.btnChekIn.TabIndex = 34;
            this.btnChekIn.Text = "CheckIn";
            this.btnChekIn.UseVisualStyleBackColor = true;
            this.btnChekIn.Click += new System.EventHandler(this.btnChekIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(216, 411);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 35;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tempTgl
            // 
            this.tempTgl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tempTgl.Location = new System.Drawing.Point(523, 41);
            this.tempTgl.Name = "tempTgl";
            this.tempTgl.Size = new System.Drawing.Size(98, 20);
            this.tempTgl.TabIndex = 39;
            // 
            // btnKonfrimasi
            // 
            this.btnKonfrimasi.Location = new System.Drawing.Point(313, 411);
            this.btnKonfrimasi.Name = "btnKonfrimasi";
            this.btnKonfrimasi.Size = new System.Drawing.Size(75, 23);
            this.btnKonfrimasi.TabIndex = 41;
            this.btnKonfrimasi.Text = "Konfirmasi Pembayaran";
            this.btnKonfrimasi.UseVisualStyleBackColor = true;
            this.btnKonfrimasi.Click += new System.EventHandler(this.btnKonfrimasi_Click);
            // 
            // txtNoKartu
            // 
            this.txtNoKartu.Location = new System.Drawing.Point(102, 347);
            this.txtNoKartu.Name = "txtNoKartu";
            this.txtNoKartu.Size = new System.Drawing.Size(114, 20);
            this.txtNoKartu.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Jenis Bayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "No.Rek";
            // 
            // txtJenisTamu
            // 
            this.txtJenisTamu.Location = new System.Drawing.Point(301, 118);
            this.txtJenisTamu.Name = "txtJenisTamu";
            this.txtJenisTamu.Size = new System.Drawing.Size(100, 20);
            this.txtJenisTamu.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Jenis Tamu";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(102, 280);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(114, 21);
            this.cmbItem.TabIndex = 48;
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Transfer",
            "Kredit"});
            this.cmbJenis.Location = new System.Drawing.Point(102, 321);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(114, 21);
            this.cmbJenis.TabIndex = 49;
            this.cmbJenis.Text = "Pilih";
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // FormFrontOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 462);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJenisTamu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoKartu);
            this.Controls.Add(this.btnKonfrimasi);
            this.Controls.Add(this.tempTgl);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnChekIn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaKamar);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtJumlahTamu);
            this.Controls.Add(this.txtJumlahAnak);
            this.Controls.Add(this.txtJumlahDesawa);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgView2);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.dgViewCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFrontOffice";
            this.Text = "FormFrontOffice";
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewCheck;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRole;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgView2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtJumlahDesawa;
        private System.Windows.Forms.TextBox txtJumlahAnak;
        private System.Windows.Forms.TextBox txtJumlahTamu;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtNamaKamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnChekIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DateTimePicker tempTgl;
        private System.Windows.Forms.Button btnKonfrimasi;
        private System.Windows.Forms.TextBox txtNoKartu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJenisTamu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbJenis;
    }
}