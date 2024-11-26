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
    public partial class frmPilas : Form
    {
        private Pilas pila;


        public frmPilas()
        {
            InitializeComponent();

            pila = new Pilas(5);
        }

        // Método para actualizar el ListBox con los empleados en la pila
        private void ActualizarListaEmpleados()
        {
            lstEmpleados.Items.Clear(); // Limpiar la lista antes de actualizarla

            // Recorrer la pila y agregar cada empleado al ListBox
            for (int i = 0; i <= pila.Cima().ToString().Length; i++)
            {
                lstEmpleados.Items.Add(pila[i].ToString());
            }
        }

        private void btnApilarEmpleado_Click(object sender, EventArgs e)
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

            // Apilar el empleado
            if (pila.Apilar(empleado))
            {
                lblEstadoEmpleado.Text = "Empleado apilado: " + empleado.ToString();
                LimpiarCampos();
                ActualizarListaEmpleados(); // Actualizamos la lista
            }
            else
            {
                lblEstadoEmpleado.Text = "No se pudo apilar el empleado.";
            }
        }

        private void btnDesapilarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = pila.Desapilar();
            if (empleado != null)
            {
                lblEstadoEmpleado.Text = "Empleado desapilado: " + empleado.ToString();
                ActualizarListaEmpleados(); // Actualizamos la lista
            }
            else
            {
                lblEstadoEmpleado.Text = "No se pudo desapilar, la pila está vacía.";
            }
        }

        // Método para limpiar los campos de texto después de apilar un empleado
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtRol.Clear();
        }
    }
}
