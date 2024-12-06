using System;
using System.Collections.Generic;
using System.Windows.Forms;

using EstructurasDeDatos.DataStructures;

namespace EstructurasDeDatos.Forms
{
    public partial class frmBubbleSort : Form
    {
        private List<Empleado> empleados; // Lista para almacenar los empleados

        public frmBubbleSort()
        {
            InitializeComponent();
            empleados = new List<Empleado>(); // Inicializar la lista de empleados
        }

        // Algoritmo BubbleSort para ordenar por nombre
        private void BubbleSort(List<Empleado> lista)
        {
            int n = lista.Count;
            bool intercambio;

            // Realizar el algoritmo de BubbleSort
            for (int i = 0; i < n - 1; i++)
            {
                intercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compara los nombres de los empleados alfabéticamente
                    if (string.Compare(lista[j].Nombre, lista[j + 1].Nombre) > 0)
                    {
                        // Intercambiar los empleados
                        Empleado temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                        intercambio = true;
                    }
                }
                // Si no hubo intercambio, la lista ya está ordenada
                if (!intercambio)
                    break;
            }
        }

        // Algoritmo BubbleSort para ordenar por nombre en orden descendente
        private void BubbleSortDescendente(List<Empleado> lista)
        {
            int n = lista.Count;
            bool intercambio;

            // Realizar el algoritmo de BubbleSort
            for (int i = 0; i < n - 1; i++)
            {
                intercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compara los nombres de los empleados alfabéticamente en orden descendente
                    if (string.Compare(lista[j].Nombre, lista[j + 1].Nombre) < 0)
                    {
                        // Intercambiar los empleados
                        Empleado temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                        intercambio = true;
                    }
                }
                // Si no hubo intercambio, la lista ya está ordenada
                if (!intercambio)
                    break;
            }
        }

        // Método para actualizar el ListBox con los empleados ordenados
        private void ActualizarLista()
        {
            lstEmpleados.Items.Clear(); // Limpiar el ListBox antes de mostrar los empleados

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

            // Crear un nuevo empleado con los datos del formulario
            Empleado empleado = new Empleado(txtNombre.Text, txtUsuario.Text, txtRol.Text);

            empleados.Add(empleado); // Agregar el empleado a la lista
            lstEmpleados.Items.Add(empleado.ToString()); // Mostrar en el ListBox
            LimpiarCampos(); // Limpiar los campos de texto
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            BubbleSort(empleados); // Ordenar la lista en orden ascendente
            ActualizarLista(); // Actualizar el ListBox con los empleados ordenados
        }

        private void btnOrdenarDescendente_Click_1(object sender, EventArgs e)
        {
            BubbleSortDescendente(empleados); // Ordenar la lista en orden descendente
            ActualizarLista(); // Actualizar el ListBox con los empleados ordenados
        }
    }
}
