using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.DataStructures
{
    public class ListaSimple
    {
        private Nodo cabeza;

        public ListaSimple()
        {
            cabeza = null;
        }

        // Verificar si la lista está vacía
        public bool EstaVacia()
        {
            return cabeza == null;
        }

        // Agregar un empleado al final de la lista
        public void AgregarEmpleado(Empleado empleado)
        {
            Nodo nuevoNodo = new Nodo(empleado);

            if (EstaVacia())
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Eliminar el primer empleado de la lista
        public Empleado EliminarEmpleado()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La lista está vacía.");
                return null;
            }
            Empleado empleadoEliminado = cabeza.Empleado;
            cabeza = cabeza.Siguiente; // Se mueve la cabeza al siguiente nodo
            return empleadoEliminado;
        }

        // Mostrar todos los empleados en la lista
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                empleados.Add(actual.Empleado);
                actual = actual.Siguiente;
            }
            return empleados;
        }
    }

}
