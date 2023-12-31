namespace Ejemplo1
{
    partial class Form2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbFutbol = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.rbtLanus = new System.Windows.Forms.RadioButton();
            this.rbtBoca = new System.Windows.Forms.RadioButton();
            this.rbtRiver = new System.Windows.Forms.RadioButton();
            this.grpEquipos = new System.Windows.Forms.GroupBox();
            this.numNumeroFav = new System.Windows.Forms.NumericUpDown();
            this.lblColores = new System.Windows.Forms.Label();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.grpEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(343, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(16, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 55);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(215, 341);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(400, 155);
            this.lwElementos.TabIndex = 8;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(229, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(212, 102);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(343, 95);
            this.dtpFechaNacimiento.MinimumSize = new System.Drawing.Size(252, 20);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(253, 20);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // ckbFutbol
            // 
            this.ckbFutbol.AutoSize = true;
            this.ckbFutbol.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckbFutbol.Location = new System.Drawing.Point(300, 128);
            this.ckbFutbol.Name = "ckbFutbol";
            this.ckbFutbol.Size = new System.Drawing.Size(114, 17);
            this.ckbFutbol.TabIndex = 4;
            this.ckbFutbol.Text = "Te gusta el futbol?";
            this.ckbFutbol.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(308, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Perfil Persona:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(179, 266);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(253, 21);
            this.cboColorFavorito.TabIndex = 6;
            // 
            // rbtLanus
            // 
            this.rbtLanus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtLanus.AutoSize = true;
            this.rbtLanus.Location = new System.Drawing.Point(17, 41);
            this.rbtLanus.Name = "rbtLanus";
            this.rbtLanus.Size = new System.Drawing.Size(54, 17);
            this.rbtLanus.TabIndex = 9;
            this.rbtLanus.TabStop = true;
            this.rbtLanus.Text = "Lanús";
            this.rbtLanus.UseVisualStyleBackColor = true;
            // 
            // rbtBoca
            // 
            this.rbtBoca.AutoSize = true;
            this.rbtBoca.Location = new System.Drawing.Point(164, 41);
            this.rbtBoca.Name = "rbtBoca";
            this.rbtBoca.Size = new System.Drawing.Size(50, 17);
            this.rbtBoca.TabIndex = 10;
            this.rbtBoca.TabStop = true;
            this.rbtBoca.Text = "Boca";
            this.rbtBoca.UseVisualStyleBackColor = true;
            // 
            // rbtRiver
            // 
            this.rbtRiver.AutoSize = true;
            this.rbtRiver.Location = new System.Drawing.Point(283, 41);
            this.rbtRiver.Name = "rbtRiver";
            this.rbtRiver.Size = new System.Drawing.Size(50, 17);
            this.rbtRiver.TabIndex = 11;
            this.rbtRiver.TabStop = true;
            this.rbtRiver.Text = "River";
            this.rbtRiver.UseVisualStyleBackColor = true;
            // 
            // grpEquipos
            // 
            this.grpEquipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpEquipos.Controls.Add(this.rbtLanus);
            this.grpEquipos.Controls.Add(this.rbtRiver);
            this.grpEquipos.Controls.Add(this.rbtBoca);
            this.grpEquipos.Location = new System.Drawing.Point(215, 163);
            this.grpEquipos.Name = "grpEquipos";
            this.grpEquipos.Size = new System.Drawing.Size(363, 80);
            this.grpEquipos.TabIndex = 5;
            this.grpEquipos.TabStop = false;
            this.grpEquipos.Text = "Equipo a elegir";
            // 
            // numNumeroFav
            // 
            this.numNumeroFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFav.Location = new System.Drawing.Point(179, 296);
            this.numNumeroFav.Name = "numNumeroFav";
            this.numNumeroFav.Size = new System.Drawing.Size(253, 20);
            this.numNumeroFav.TabIndex = 7;
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColores.Location = new System.Drawing.Point(68, 269);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(75, 13);
            this.lblColores.TabIndex = 14;
            this.lblColores.Text = "Color Favorito:";
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(68, 303);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroFavorito.TabIndex = 15;
            this.lblNumeroFavorito.Text = "Numero Favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(16, 46);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(140, 37);
            this.btnVerPerfil.TabIndex = 1;
            this.btnVerPerfil.Text = "Ver &perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 548);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.numNumeroFav);
            this.Controls.Add(this.grpEquipos);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbFutbol);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 587);
            this.Name = "Form2";
            this.Text = "Perfil Persona";
            this.Load += new System.EventHandler(this.lblNombre_Load);
            this.grpEquipos.ResumeLayout(false);
            this.grpEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbFutbol;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.RadioButton rbtLanus;
        private System.Windows.Forms.RadioButton rbtBoca;
        private System.Windows.Forms.RadioButton rbtRiver;
        private System.Windows.Forms.GroupBox grpEquipos;
        private System.Windows.Forms.NumericUpDown numNumeroFav;
        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}