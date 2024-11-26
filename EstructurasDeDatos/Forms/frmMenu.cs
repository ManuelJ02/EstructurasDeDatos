using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            Form formulario = new frmPilas();
            formulario.Show();

        }

        private void btnColasSimples_Click(object sender, EventArgs e)
        {
            Form formulario = new frmColasSimples();
            formulario.Show();
        }

        private void tnListasSimples_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListasSimples();
            formulario.Show();
        }

        private void btnColasCirculares_Click(object sender, EventArgs e)
        {
            Form formulario = new frmColaCircular();
            formulario.Show();
        }
    }
}
