using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea Cerrar la aplicacion?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LlenarDatagrid()
        {
            this.EmpleadosTableAdapter.Fill(this.dsEmpleados.Empleados);
        }

        private void DesactivarTo()
        {
            txtNombre.Enabled = false;
            cbRol.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            txtID.Enabled = false;

            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void ActivarTo()
        {
            txtNombre.Enabled = true;
            cbRol.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarTo();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DesactivarTo();

            LlenarDatagrid();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtContraseña.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(cbRol.Text.Trim()))
            {
                MessageBox.Show("Ingrese todos los datos", "faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            Empleados tempiniciosesion = new Empleados();

            if (tempiniciosesion.GetUsuarioExistente(txtUsuario.Text.Trim()))
            {
                MessageBox.Show("El usuario ya existe", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String Hashed = Seguridad.Encriptar(txtContraseña.Text.Trim());

            Empleados iniciosesion = new Empleados();
            iniciosesion.Insertar(txtNombre.Text.Trim(), cbRol.Text.Trim(), Hashed, txtUsuario.Text.Trim());

            Limpial();

            DesactivarTo();

            MessageBox.Show("Usuario creado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LlenarDatagrid();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cancelar la operación actual?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (result == DialogResult.OK)
            {
                Limpial();

                DesactivarTo();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtContraseña.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(cbRol.Text.Trim()))
            {
                MessageBox.Show("Ingrese todos los datos", "faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            Empleados tempiniciosesion = new Empleados();

            if (!tempiniciosesion.GetID(int.Parse(txtID.Text.Trim())))
            {
                MessageBox.Show("El usuario no existe", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String Hashed = Seguridad.Encriptar(txtContraseña.Text.Trim());

            Empleados iniciosesion = new Empleados(int.Parse(txtID.Text.Trim()));
            iniciosesion.Actualizar(txtNombre.Text.Trim(), cbRol.Text.Trim(), Hashed, txtUsuario.Text.Trim());

            Limpial();
            txtID.Clear();

            DesactivarTo();

            MessageBox.Show("Usuario Actualizado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LlenarDatagrid();

        }

        private void dgUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsuarios.Columns[e.ColumnIndex].Name == "_editar")
            {
                txtID.Text = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
                cbRol.Text = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtContraseña.Text = dgUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtUsuario.Text = dgUsuarios.CurrentRow.Cells[4].Value.ToString();

                txtNombre.Enabled = true;
                cbRol.Enabled = true;
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;

                btnCancelar.Enabled = true;
                btnActualizar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            if (dgUsuarios.Columns[e.ColumnIndex].Name == "_eliminar")
            {
                txtID.Text = dgUsuarios.CurrentRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("¿Desea Eliminar este usuario?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                if (result == DialogResult.OK)
                {
                    Empleados iniciosesion = new Empleados(int.Parse(txtID.Text.Trim()));
                    iniciosesion.Eliminar();

                    MessageBox.Show("Usuario Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LlenarDatagrid();
                }
            }

        }

        private void cbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Limpial()
        {
            txtNombre.Clear();
            cbRol.Text = String.Empty;
            txtUsuario.Clear();
            txtContraseña.Text = String.Empty;
        }

    }
}
