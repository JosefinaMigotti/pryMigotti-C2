using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMigotti_C2
{
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre1.Text = "";
            mtbIdentificacion.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter localidades = new StreamWriter("./ Localidades.Text", true);
            localidades.WriteLine(mtbIdentificacion.Text + " " + txtNombre1.Text);
            MessageBox.Show("Datos guardados");
            localidades.Close();
            mtbIdentificacion.Text = "";
            txtNombre1.Text = "";
        }

        private void mtbIdentificacion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
