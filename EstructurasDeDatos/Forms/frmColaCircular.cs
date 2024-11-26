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
    public partial class frmColaCircular : Form
    {
        private ColaCircular cola;

        public frmColaCircular()
        {
            InitializeComponent();

            cola = new ColaCircular(5); // Creamos la cola con capacidad para 5 empleados
        }

        // Actualizar el ListBox con los empleados de la cola
        private void ActualizarListaEmpleados()
        {
            lstEmpleados.Items.Clear(); // Limpiar el ListBox antes de actualizarlo

            // Obtener todos los empleados de la cola y agregarlos al ListBox
            List<Empleado> empleados = cola.ObtenerEmpleados();
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

            // Encolar el empleado en la cola
            if (cola.Encolar(empleado))
            {
                // Actualizamos el ListBox con los empleados de la cola
                ActualizarListaEmpleados();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el empleado, la cola está llena.");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = cola.Desencolar();
            if (empleado != null)
            {
                MessageBox.Show("Empleado eliminado: " + empleado.ToString());
                ActualizarListaEmpleados(); // Actualizar la lista
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
