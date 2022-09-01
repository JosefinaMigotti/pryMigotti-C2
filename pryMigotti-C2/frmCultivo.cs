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
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre2.Text = "";
            mtbIdentificacion2.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter Cultivos = new StreamWriter("./ Cultivos.Text", true);
            Cultivos.WriteLine(mtbIdentificacion2.Text + " " + txtNombre2.Text);
            MessageBox.Show("Datos guardados");
            Cultivos.Close();
            mtbIdentificacion2.Text = "";
            txtNombre2.Text = "";
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
