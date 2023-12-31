namespace MiPrimerApp
{
    partial class Frm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtpasatiempo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboColorFav = new System.Windows.Forms.ComboBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.llbColorfav = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerInfo.Image = global::MiPrimerApp.Properties.Resources.descarga;
            this.btnVerInfo.Location = new System.Drawing.Point(539, 128);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(136, 37);
            this.btnVerInfo.TabIndex = 0;
            this.btnVerInfo.Text = "Ver info";
            this.btnVerInfo.UseVisualStyleBackColor = false;
            this.btnVerInfo.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtinfo.Location = new System.Drawing.Point(309, 78);
            this.txtinfo.MaxLength = 327672323;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(157, 20);
            this.txtinfo.TabIndex = 2;
            this.txtinfo.TextChanged += new System.EventHandler(this.txtinfo_TextChanged);
            this.txtinfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtpasatiempo
            // 
            this.txtpasatiempo.Location = new System.Drawing.Point(309, 120);
            this.txtpasatiempo.Multiline = true;
            this.txtpasatiempo.Name = "txtpasatiempo";
            this.txtpasatiempo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtpasatiempo.Size = new System.Drawing.Size(147, 37);
            this.txtpasatiempo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.veerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // veerToolStripMenuItem
            // 
            this.veerToolStripMenuItem.Name = "veerToolStripMenuItem";
            this.veerToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.veerToolStripMenuItem.Text = "Ver";
            // 
            // cboColorFav
            // 
            this.cboColorFav.FormattingEnabled = true;
            this.cboColorFav.Location = new System.Drawing.Point(309, 191);
            this.cboColorFav.Name = "cboColorFav";
            this.cboColorFav.Size = new System.Drawing.Size(121, 21);
            this.cboColorFav.TabIndex = 5;
            this.cboColorFav.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEtiqueta.Location = new System.Drawing.Point(63, 70);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(240, 28);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Informacion Personal";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblAgregar_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAgregar_MouseMove);
            // 
            // llbColorfav
            // 
            this.llbColorfav.AutoSize = true;
            this.llbColorfav.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbColorfav.ForeColor = System.Drawing.SystemColors.Desktop;
            this.llbColorfav.Location = new System.Drawing.Point(63, 184);
            this.llbColorfav.Name = "llbColorfav";
            this.llbColorfav.Size = new System.Drawing.Size(163, 28);
            this.llbColorfav.TabIndex = 6;
            this.llbColorfav.Text = "Color Favorito";
            this.llbColorfav.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(63, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pasatiempo";
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbColorfav);
            this.Controls.Add(this.cboColorFav);
            this.Controls.Add(this.txtpasatiempo);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtpasatiempo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboColorFav;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label llbColorfav;
        private System.Windows.Forms.Label label1;
    }
}

