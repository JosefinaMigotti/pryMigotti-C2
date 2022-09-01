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
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            File.Create("./CrearArchivo.Text");
            MessageBox.Show("Creaste un archivo");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            File.Delete("./CrearArchivo.Text");
            MessageBox.Show("Eliminaste un archivo");
        }

        private void btnRescribir_Click(object sender, EventArgs e)
        {
            
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades objLocalidades = new frmLocalidades();
            objLocalidades.ShowDialog();
        }

        private void cultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivo objCultivos = new frmCultivo();
            objCultivos.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion objCultivos = new frmProduccion();
            objCultivos.ShowDialog();
        }

        private void frmAgricultura_Load(object sender, EventArgs e)
        {

        }
    }
}
