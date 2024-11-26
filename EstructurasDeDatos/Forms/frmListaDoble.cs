using EstructurasDeDatos.DataStructures;
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
    public partial class frmListaDoble : Form
    {
        private ListaDoble lista;

        public frmListaDoble()
        {
            InitializeComponent();

            lista = new ListaDoble();
        }

        // Actualizar el ListBox con los empleados de la lista
        private void ActualizarListaEmpleados()
        {
            lstEmpleados.Items.Clear(); // Limpiar el ListBox antes de actualizarlo

            // Obtener todos los empleados de la lista y agregarlos al ListBox
            List<Empleado> empleados = lista.ObtenerEmpleados();
            foreach (Empleado empleado in empleados)
            {
                lstEmpleados.Items.Add(empleado.ToString());
            }
        }

        private void ActualizarListaEmpleadosInversa()
        {
            lstEmpleados.Items.Clear(); // Limpiar el ListBox antes de actualizarlo

            // Obtener todos los empleados de la lista desde el final y agregarlos al ListBox
            List<Empleado> empleados = lista.ObtenerEmpleadosInverso();
            foreach (Empleado empleado in empleados)
            {
                lstEmpleados.Items.Add(empleado.ToString());
            }
        }

        private void btnAgregarPrincipio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
           string.IsNullOrWhiteSpace(txtUsuario.Text) ||
           string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos.");
                return;
            }

            Empleado empleado = new Empleado(txtNombre.Text, txtUsuario.Text, txtRol.Text);
            lista.AgregarEmpleadoAlPrincipio(empleado);
            ActualizarListaEmpleados();
            LimpiarCampos();
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos.");
                return;
            }

            Empleado empleado = new Empleado(txtNombre.Text, txtUsuario.Text, txtRol.Text);
            lista.AgregarEmpleadoAlFinal(empleado);
            ActualizarListaEmpleados();
            LimpiarCampos();
        }

        private void btnEliminarPrincipio_Click(object sender, EventArgs e)
        {
            Empleado empleado = lista.EliminarEmpleadoDelPrincipio();
            if (empleado != null)
            {
                MessageBox.Show("Empleado eliminado del principio: " + empleado.ToString());
                ActualizarListaEmpleados();
            }
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            Empleado empleado = lista.EliminarEmpleadoDelFinal();
            if (empleado != null)
            {
                MessageBox.Show("Empleado eliminado del final: " + empleado.ToString());
                ActualizarListaEmpleados();
            }
        }



        // Limpiar los campos de texto después de agregar un empleado
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtRol.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
