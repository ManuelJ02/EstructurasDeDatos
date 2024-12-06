using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EstructurasDeDatos.DataStructures;

namespace EstructurasDeDatos.Forms
{
    public partial class frmQuickSort : Form
    {
        private List<Empleado> empleados; // Lista para almacenar los empleados

        public frmQuickSort()
        {
            InitializeComponent();
            empleados = new List<Empleado>(); // Inicializar la lista de empleados
        }

        // Algoritmo Quicksort para ordenar por nombre
        private void QuickSort(List<Empleado> lista, int low, int high, bool ascendente)
        {
            if (low < high)
            {
                int pi = Partition(lista, low, high, ascendente);

                QuickSort(lista, low, pi - 1, ascendente);  // Lado izquierdo
                QuickSort(lista, pi + 1, high, ascendente); // Lado derecho
            }
        }

        private int Partition(List<Empleado> lista, int low, int high, bool ascendente)
        {
            Empleado pivot = lista[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                bool comparar = ascendente ? string.Compare(lista[j].Nombre, pivot.Nombre) < 0 : string.Compare(lista[j].Nombre, pivot.Nombre) > 0;

                if (comparar)
                {
                    i++;
                    // Intercambiar elementos
                    Empleado temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            // Intercambiar el pivote con el elemento en la posición correcta
            Empleado temp2 = lista[i + 1];
            lista[i + 1] = lista[high];
            lista[high] = temp2;
            return i + 1;
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

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacío
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
            QuickSort(empleados, 0, empleados.Count - 1, true); // Ordenar en orden ascendente
            ActualizarLista(); // Actualizar el ListBox con los empleados ordenados
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdenarDescendente_Click(object sender, EventArgs e)
        {
            QuickSort(empleados, 0, empleados.Count - 1, false); // Ordenar en orden descendente
            ActualizarLista(); // Actualizar el ListBox con los empleados ordenados
        }
    }
}
