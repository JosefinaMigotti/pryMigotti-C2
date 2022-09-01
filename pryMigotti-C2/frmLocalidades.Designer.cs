namespace pryMigotti_C2
{
    partial class frmLocalidades
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
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.mtbIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir1
            // 
            this.btnSalir1.Location = new System.Drawing.Point(181, 100);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(75, 23);
            this.btnSalir1.TabIndex = 11;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(18, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(73, 68);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(190, 20);
            this.txtNombre1.TabIndex = 8;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(13, 16);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(90, 13);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Ingrese localidad:";
            // 
            // mtbIdentificacion
            // 
            this.mtbIdentificacion.Location = new System.Drawing.Point(99, 40);
            this.mtbIdentificacion.Name = "mtbIdentificacion";
            this.mtbIdentificacion.Size = new System.Drawing.Size(164, 20);
            this.mtbIdentificacion.TabIndex = 15;
            this.mtbIdentificacion.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbIdentificacion_MaskInputRejected);
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(13, 69);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(47, 13);
            this.lblNombre1.TabIndex = 7;
            this.lblNombre1.Text = "Nombre:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(13, 40);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificador.TabIndex = 14;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 141);
            this.Controls.Add(this.mtbIdentificacion);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacion;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblIdentificador;
    }
}