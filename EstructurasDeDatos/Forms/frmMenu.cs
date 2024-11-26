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
            formulario.ShowDialog();

        }

        private void btnColasSimples_Click(object sender, EventArgs e)
        {
            Form formulario = new frmColasSimples();
            formulario.ShowDialog();
        }

        private void tnListasSimples_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListasSimples();
            formulario.ShowDialog();
        }

        private void btnColasCirculares_Click(object sender, EventArgs e)
        {
            Form formulario = new frmColaCircular();
            formulario.ShowDialog();
        }

        private void btnListasDobles_Click(object sender, EventArgs e)
        {
            Form formulario = new frmColaCircular();
            formulario.ShowDialog();
        }
    }
}
