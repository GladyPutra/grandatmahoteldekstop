namespace GAHDesktop.UI
{
    partial class FormAdmin
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
            this.btnKelolaAkun = new System.Windows.Forms.Button();
            this.btnKelolaKamar = new System.Windows.Forms.Button();
            this.btnKelolaItem = new System.Windows.Forms.Button();
            this.btnKelolaTarif = new System.Windows.Forms.Button();
            this.btnKelolaSeason = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKelolaAkun
            // 
            this.btnKelolaAkun.Location = new System.Drawing.Point(106, 96);
            this.btnKelolaAkun.Name = "btnKelolaAkun";
            this.btnKelolaAkun.Size = new System.Drawing.Size(76, 28);
            this.btnKelolaAkun.TabIndex = 0;
            this.btnKelolaAkun.Text = "Kelola Akun";
            this.btnKelolaAkun.UseVisualStyleBackColor = true;
            // 
            // btnKelolaKamar
            // 
            this.btnKelolaKamar.Location = new System.Drawing.Point(212, 96);
            this.btnKelolaKamar.Name = "btnKelolaKamar";
            this.btnKelolaKamar.Size = new System.Drawing.Size(76, 41);
            this.btnKelolaKamar.TabIndex = 1;
            this.btnKelolaKamar.Text = "Kelola Kamar";
            this.btnKelolaKamar.UseVisualStyleBackColor = true;
            this.btnKelolaKamar.Click += new System.EventHandler(this.btnKelolaKamar_Click);
            // 
            // btnKelolaItem
            // 
            this.btnKelolaItem.Location = new System.Drawing.Point(264, 181);
            this.btnKelolaItem.Name = "btnKelolaItem";
            this.btnKelolaItem.Size = new System.Drawing.Size(76, 28);
            this.btnKelolaItem.TabIndex = 2;
            this.btnKelolaItem.Text = "Kelola Item";
            this.btnKelolaItem.UseVisualStyleBackColor = true;
            // 
            // btnKelolaTarif
            // 
            this.btnKelolaTarif.Location = new System.Drawing.Point(161, 181);
            this.btnKelolaTarif.Name = "btnKelolaTarif";
            this.btnKelolaTarif.Size = new System.Drawing.Size(76, 28);
            this.btnKelolaTarif.TabIndex = 3;
            this.btnKelolaTarif.Text = "Kelola Tarif";
            this.btnKelolaTarif.UseVisualStyleBackColor = true;
            this.btnKelolaTarif.Click += new System.EventHandler(this.btnKelolaTarif_Click);
            // 
            // btnKelolaSeason
            // 
            this.btnKelolaSeason.Location = new System.Drawing.Point(310, 96);
            this.btnKelolaSeason.Name = "btnKelolaSeason";
            this.btnKelolaSeason.Size = new System.Drawing.Size(76, 41);
            this.btnKelolaSeason.TabIndex = 4;
            this.btnKelolaSeason.Text = "Kelola Season";
            this.btnKelolaSeason.UseVisualStyleBackColor = true;
            this.btnKelolaSeason.Click += new System.EventHandler(this.btnKelolaSeason_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRole});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRole
            // 
            this.menuRole.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuRole.Name = "menuRole";
            this.menuRole.Size = new System.Drawing.Size(42, 20);
            this.menuRole.Text = "Role";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 338);
            this.Controls.Add(this.btnKelolaSeason);
            this.Controls.Add(this.btnKelolaTarif);
            this.Controls.Add(this.btnKelolaItem);
            this.Controls.Add(this.btnKelolaKamar);
            this.Controls.Add(this.btnKelolaAkun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKelolaAkun;
        private System.Windows.Forms.Button btnKelolaKamar;
        private System.Windows.Forms.Button btnKelolaItem;
        private System.Windows.Forms.Button btnKelolaTarif;
        private System.Windows.Forms.Button btnKelolaSeason;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRole;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}