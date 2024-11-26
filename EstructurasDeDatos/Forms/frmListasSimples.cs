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
    public partial class frmListasSimples : Form
    {
        private ListaSimple lista;

        public frmListasSimples()
        {
            InitializeComponent();

            lista = new ListaSimple();
        }

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

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos.");
                return;
            }

            // Crear un nuevo objeto Empleado
            Empleado empleado = new Empleado(txtNombre.Text, txtUsuario.Text, txtRol.Text);

            // Agregar el empleado a la lista
            lista.AgregarEmpleado(empleado);

            // Actualizar la lista en el ListBox
            ActualizarListaEmpleados();

            // Limpiar los campos de texto
            LimpiarCampos();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = lista.EliminarEmpleado();
            if (empleado != null)
            {
                MessageBox.Show("Empleado eliminado: " + empleado.ToString());
                ActualizarListaEmpleados(); // Actualizar el ListBox
            }
        }

        // Limpiar los campos de texto después de agregar un empleado
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtRol.Clear();
        }
    }
}
