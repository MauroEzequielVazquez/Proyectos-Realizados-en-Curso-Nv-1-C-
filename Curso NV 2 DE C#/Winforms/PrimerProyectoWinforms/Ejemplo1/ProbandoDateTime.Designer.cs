namespace Ejemplo1
{
    partial class ProbandoDateTime
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
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.calFecha2 = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(183, 42);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha1.TabIndex = 0;
            // 
            // calFecha2
            // 
            this.calFecha2.Location = new System.Drawing.Point(183, 74);
            this.calFecha2.Name = "calFecha2";
            this.calFecha2.TabIndex = 1;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(471, 57);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 2;
            this.btnPrueba1.Text = "Prueba1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(471, 147);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Prueba2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // ProbandoDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.calFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Name = "ProbandoDateTime";
            this.Text = "ProbandoDateTime";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.MonthCalendar calFecha2;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
    }
}