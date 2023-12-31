namespace Probemosqueaprendimos
{
    partial class Ventana
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
            this.lblPerfilAgente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtCuerpoGeneral = new System.Windows.Forms.RadioButton();
            this.rbtAdministrativo = new System.Windows.Forms.RadioButton();
            this.rbtMaestranza = new System.Windows.Forms.RadioButton();
            this.rbtNinguna = new System.Windows.Forms.RadioButton();
            this.lblNombreyApe = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCredencial = new System.Windows.Forms.Label();
            this.numericUpDownCredencial = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEscalafon = new System.Windows.Forms.GroupBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbActividad = new System.Windows.Forms.CheckBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.btnDatosAgente = new System.Windows.Forms.Button();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredencial)).BeginInit();
            this.groupBoxEscalafon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerfilAgente
            // 
            this.lblPerfilAgente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerfilAgente.AutoSize = true;
            this.lblPerfilAgente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPerfilAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilAgente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerfilAgente.Location = new System.Drawing.Point(71, 9);
            this.lblPerfilAgente.Name = "lblPerfilAgente";
            this.lblPerfilAgente.Size = new System.Drawing.Size(148, 25);
            this.lblPerfilAgente.TabIndex = 0;
            this.lblPerfilAgente.Text = "Perfil Agente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(259, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(259, 104);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // rbtCuerpoGeneral
            // 
            this.rbtCuerpoGeneral.AutoSize = true;
            this.rbtCuerpoGeneral.Location = new System.Drawing.Point(14, 40);
            this.rbtCuerpoGeneral.Name = "rbtCuerpoGeneral";
            this.rbtCuerpoGeneral.Size = new System.Drawing.Size(99, 17);
            this.rbtCuerpoGeneral.TabIndex = 4;
            this.rbtCuerpoGeneral.TabStop = true;
            this.rbtCuerpoGeneral.Text = "Cuerpo General";
            this.rbtCuerpoGeneral.UseVisualStyleBackColor = true;
            // 
            // rbtAdministrativo
            // 
            this.rbtAdministrativo.AutoSize = true;
            this.rbtAdministrativo.Location = new System.Drawing.Point(238, 40);
            this.rbtAdministrativo.Name = "rbtAdministrativo";
            this.rbtAdministrativo.Size = new System.Drawing.Size(90, 17);
            this.rbtAdministrativo.TabIndex = 5;
            this.rbtAdministrativo.TabStop = true;
            this.rbtAdministrativo.Text = "Administrativo";
            this.rbtAdministrativo.UseVisualStyleBackColor = true;
            // 
            // rbtMaestranza
            // 
            this.rbtMaestranza.AutoSize = true;
            this.rbtMaestranza.Location = new System.Drawing.Point(405, 40);
            this.rbtMaestranza.Name = "rbtMaestranza";
            this.rbtMaestranza.Size = new System.Drawing.Size(80, 17);
            this.rbtMaestranza.TabIndex = 6;
            this.rbtMaestranza.TabStop = true;
            this.rbtMaestranza.Text = "Maestranza";
            this.rbtMaestranza.UseVisualStyleBackColor = true;
            // 
            // rbtNinguna
            // 
            this.rbtNinguna.AutoSize = true;
            this.rbtNinguna.Location = new System.Drawing.Point(521, 40);
            this.rbtNinguna.Name = "rbtNinguna";
            this.rbtNinguna.Size = new System.Drawing.Size(146, 17);
            this.rbtNinguna.TabIndex = 7;
            this.rbtNinguna.TabStop = true;
            this.rbtNinguna.Text = "Ninguna de las Anteriores";
            this.rbtNinguna.UseVisualStyleBackColor = true;
            // 
            // lblNombreyApe
            // 
            this.lblNombreyApe.AutoSize = true;
            this.lblNombreyApe.Location = new System.Drawing.Point(80, 58);
            this.lblNombreyApe.Name = "lblNombreyApe";
            this.lblNombreyApe.Size = new System.Drawing.Size(103, 13);
            this.lblNombreyApe.TabIndex = 8;
            this.lblNombreyApe.Text = "Nombres  y Apellido:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(80, 104);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "FechaNacimiento:";
            // 
            // lblCredencial
            // 
            this.lblCredencial.AutoSize = true;
            this.lblCredencial.Location = new System.Drawing.Point(80, 146);
            this.lblCredencial.Name = "lblCredencial";
            this.lblCredencial.Size = new System.Drawing.Size(57, 13);
            this.lblCredencial.TabIndex = 10;
            this.lblCredencial.Text = "Credencial";
            // 
            // numericUpDownCredencial
            // 
            this.numericUpDownCredencial.Location = new System.Drawing.Point(259, 146);
            this.numericUpDownCredencial.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownCredencial.Name = "numericUpDownCredencial";
            this.numericUpDownCredencial.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownCredencial.TabIndex = 11;
            // 
            // groupBoxEscalafon
            // 
            this.groupBoxEscalafon.Controls.Add(this.rbtCuerpoGeneral);
            this.groupBoxEscalafon.Controls.Add(this.rbtAdministrativo);
            this.groupBoxEscalafon.Controls.Add(this.rbtMaestranza);
            this.groupBoxEscalafon.Controls.Add(this.rbtNinguna);
            this.groupBoxEscalafon.Location = new System.Drawing.Point(83, 233);
            this.groupBoxEscalafon.Name = "groupBoxEscalafon";
            this.groupBoxEscalafon.Size = new System.Drawing.Size(667, 76);
            this.groupBoxEscalafon.TabIndex = 12;
            this.groupBoxEscalafon.TabStop = false;
            this.groupBoxEscalafon.Text = "Esalafón";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(115, 336);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 13);
            this.lblDestino.TabIndex = 8;
            this.lblDestino.Text = "Destino Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Se encuentra en Actividad?";
            // 
            // ckbActividad
            // 
            this.ckbActividad.AutoSize = true;
            this.ckbActividad.Location = new System.Drawing.Point(299, 199);
            this.ckbActividad.Name = "ckbActividad";
            this.ckbActividad.Size = new System.Drawing.Size(15, 14);
            this.ckbActividad.TabIndex = 14;
            this.ckbActividad.UseVisualStyleBackColor = true;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(258, 328);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(190, 21);
            this.cboDestino.TabIndex = 15;
            // 
            // btnDatosAgente
            // 
            this.btnDatosAgente.Location = new System.Drawing.Point(331, 415);
            this.btnDatosAgente.Name = "btnDatosAgente";
            this.btnDatosAgente.Size = new System.Drawing.Size(167, 23);
            this.btnDatosAgente.TabIndex = 16;
            this.btnDatosAgente.Text = "Recopilar Datos del Agente";
            this.btnDatosAgente.UseVisualStyleBackColor = true;
            this.btnDatosAgente.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(601, 36);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(92, 13);
            this.lblFechaIngreso.TabIndex = 17;
            this.lblFechaIngreso.Text = "Fecha De Ingreso";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(534, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.btnDatosAgente);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.ckbActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxEscalafon);
            this.Controls.Add(this.numericUpDownCredencial);
            this.Controls.Add(this.lblCredencial);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombreyApe);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPerfilAgente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana";
            this.Text = "PerfilAgente";
            this.Load += new System.EventHandler(this.PerfilAgente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredencial)).EndInit();
            this.groupBoxEscalafon.ResumeLayout(false);
            this.groupBoxEscalafon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfilAgente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbtCuerpoGeneral;
        private System.Windows.Forms.RadioButton rbtAdministrativo;
        private System.Windows.Forms.RadioButton rbtMaestranza;
        private System.Windows.Forms.RadioButton rbtNinguna;
        private System.Windows.Forms.Label lblNombreyApe;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCredencial;
        private System.Windows.Forms.NumericUpDown numericUpDownCredencial;
        private System.Windows.Forms.GroupBox groupBoxEscalafon;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbActividad;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Button btnDatosAgente;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}