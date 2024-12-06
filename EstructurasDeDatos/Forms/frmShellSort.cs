using System;
using System.Collections.Generic;
using System.Windows.Forms;

using EstructurasDeDatos.DataStructures;

namespace EstructurasDeDatos.Forms
{
    public partial class frmShellSort : Form
    {
        private List<Empleado> empleados;

        public frmShellSort()
        {
            InitializeComponent();
            empleados = new List<Empleado>(); // Inicializamos la lista de empleados
        }

        // Algoritmo ShellSort para ordenar los empleados por nombre
        private void ShellSort(List<Empleado> lista)
        {
            int n = lista.Count;
            int gap = n / 2;

            // Mientras el gap sea mayor que 0
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    Empleado temp = lista[i];
                    int j = i;
                    // Comparar los empleados por su nombre (alfabéticamente)
                    while (j >= gap && string.Compare(lista[j - gap].Nombre, temp.Nombre) > 0)
                    {
                        lista[j] = lista[j - gap];
                        j -= gap;
                    }
                    lista[j] = temp;
                }

                gap /= 2; // Reducir el gap
            }
        }

        // Método para actualizar el ListBox con los empleados ordenados
        private void ActualizarLista()
        {
            lstEmpleados.Items.Clear(); // Limpiar el ListBox

            // Agregar los empleados ordenados al ListBox
            foreach (var empleado in empleados)
            {
                lstEmpleados.Items.Add(empleado.ToString());
            }
        }

        // Método para limpiar los campos de texto después de agregar un empleado
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

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos.");
                return;
            }

            // Crear un nuevo empleado
            Empleado empleado = new Empleado(txtNombre.Text, txtUsuario.Text, txtRol.Text);

            // Agregarlo a la lista
            empleados.Add(empleado);
            lstEmpleados.Items.Add(empleado.ToString());
            LimpiarCampos(); // Limpiar los campos de texto
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            ShellSort(empleados); // Ordenar los empleados por nombre
            ActualizarLista(); // Actualizar el ListBox
        }
    }
}
