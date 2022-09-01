namespace pryMigotti_C2
{
    partial class frmProduccion
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtNLocalidad = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.mtbCantidad = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(14, 40);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(111, 13);
            this.lblNombreLocalidad.TabIndex = 1;
            this.lblNombreLocalidad.Text = "Nombre de Localidad:";
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.Location = new System.Drawing.Point(14, 65);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCultivo.TabIndex = 2;
            this.lblNombreCultivo.Text = "Nombre de Cultivo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(14, 90);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(131, 12);
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(122, 20);
            this.mtbFecha.TabIndex = 4;
            this.mtbFecha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbFecha_MaskInputRejected);
            // 
            // txtNLocalidad
            // 
            this.txtNLocalidad.Location = new System.Drawing.Point(131, 37);
            this.txtNLocalidad.Name = "txtNLocalidad";
            this.txtNLocalidad.Size = new System.Drawing.Size(122, 20);
            this.txtNLocalidad.TabIndex = 5;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(131, 62);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(122, 20);
            this.txtNombreC.TabIndex = 6;
            // 
            // mtbCantidad
            // 
            this.mtbCantidad.Location = new System.Drawing.Point(131, 87);
            this.mtbCantidad.Name = "mtbCantidad";
            this.mtbCantidad.Size = new System.Drawing.Size(122, 20);
            this.mtbCantidad.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(175, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 122);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 157);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtbCantidad);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.txtNLocalidad);
            this.Controls.Add(this.mtbFecha);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.TextBox txtNLocalidad;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.MaskedTextBox mtbCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
    }
}