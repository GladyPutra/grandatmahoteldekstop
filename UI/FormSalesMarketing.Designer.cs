namespace GAHDesktop.UI
{
    partial class FormSalesMarketing
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
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnInputReservasi = new System.Windows.Forms.Button();
            this.btnKelolaReservasi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
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
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // btnReservasi
            // 
            this.btnReservasi.Location = new System.Drawing.Point(179, 211);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(75, 58);
            this.btnReservasi.TabIndex = 1;
            this.btnReservasi.Text = "Kelola History Reservasi";
            this.btnReservasi.UseVisualStyleBackColor = true;
            // 
            // btnInputReservasi
            // 
            this.btnInputReservasi.Location = new System.Drawing.Point(318, 211);
            this.btnInputReservasi.Name = "btnInputReservasi";
            this.btnInputReservasi.Size = new System.Drawing.Size(75, 58);
            this.btnInputReservasi.TabIndex = 2;
            this.btnInputReservasi.Text = "Input Reservasi";
            this.btnInputReservasi.UseVisualStyleBackColor = true;
            // 
            // btnKelolaReservasi
            // 
            this.btnKelolaReservasi.Location = new System.Drawing.Point(456, 211);
            this.btnKelolaReservasi.Name = "btnKelolaReservasi";
            this.btnKelolaReservasi.Size = new System.Drawing.Size(75, 58);
            this.btnKelolaReservasi.TabIndex = 3;
            this.btnKelolaReservasi.Text = "Kelola Data Reservasi";
            this.btnKelolaReservasi.UseVisualStyleBackColor = true;
            this.btnKelolaReservasi.Click += new System.EventHandler(this.btnKelolaReservasi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 187);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sales dan Marketing";
            // 
            // FormSalesMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKelolaReservasi);
            this.Controls.Add(this.btnInputReservasi);
            this.Controls.Add(this.btnReservasi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSalesMarketing";
            this.Text = "FormSalesMarketing";
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
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.Button btnInputReservasi;
        private System.Windows.Forms.Button btnKelolaReservasi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}