namespace pryMigotti_C2
{
    partial class frmCultivo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtbIdentificacion2 = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(179, 96);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtbIdentificacion2
            // 
            this.mtbIdentificacion2.Location = new System.Drawing.Point(91, 37);
            this.mtbIdentificacion2.Mask = "99999";
            this.mtbIdentificacion2.Name = "mtbIdentificacion2";
            this.mtbIdentificacion2.Size = new System.Drawing.Size(163, 20);
            this.mtbIdentificacion2.TabIndex = 19;
            this.mtbIdentificacion2.ValidatingType = typeof(int);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(11, 40);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion.TabIndex = 18;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(11, 96);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(63, 63);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(191, 20);
            this.txtNombre2.TabIndex = 15;
            this.txtNombre2.TextChanged += new System.EventHandler(this.txtNombre2_TextChanged);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(11, 66);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 14;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(11, 14);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(102, 13);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Ingrese información:";
            // 
            // frmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 139);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mtbIdentificacion2);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmCultivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacion2;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblLocalidad;
    }
}