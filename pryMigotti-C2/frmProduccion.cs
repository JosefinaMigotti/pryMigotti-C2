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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void mtbFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtbFecha.Text = "";
            txtNLocalidad.Text = "";
            txtNombreC.Text = "";
            mtbCantidad.Text = "";
        }
    }
}
