using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.DataStructures
{
    public class ListaDoble
    {
        private NodoDoble frente;
        private NodoDoble final;
        private int cantidad;

        // Constructor de la lista doblemente enlazada
        public ListaDoble()
        {
            frente = null;
            final = null;
            cantidad = 0;
        }

        // Verificar si la lista está vacía
        public bool EstaVacia()
        {
            return cantidad == 0;
        }

        // Agregar un empleado al final de la lista
        public void AgregarEmpleadoAlFinal(Empleado empleado)
        {
            NodoDoble nuevoNodo = new NodoDoble(empleado);

            if (EstaVacia())
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = final;
                final = nuevoNodo;
            }

            cantidad++;
        }

        // Agregar un empleado al principio de la lista
        public void AgregarEmpleadoAlPrincipio(Empleado empleado)
        {
            NodoDoble nuevoNodo = new NodoDoble(empleado);

            if (EstaVacia())
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = frente;
                frente.Anterior = nuevoNodo;
                frente = nuevoNodo;
            }

            cantidad++;
        }

        // Eliminar el primer empleado de la lista
        public Empleado EliminarEmpleadoDelPrincipio()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La lista está vacía");
                return null;
            }

            Empleado empleadoEliminado = frente.Empleado;
            frente = frente.Siguiente;

            if (frente != null)
            {
                frente.Anterior = null;
            }
            else
            {
                final = null;
            }

            cantidad--;
            return empleadoEliminado;
        }

        // Eliminar el último empleado de la lista
        public Empleado EliminarEmpleadoDelFinal()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La lista está vacía");
                return null;
            }

            Empleado empleadoEliminado = final.Empleado;
            final = final.Anterior;

            if (final != null)
            {
                final.Siguiente = null;
            }
            else
            {
                frente = null;
            }

            cantidad--;
            return empleadoEliminado;
        }

        // Obtener todos los empleados (para mostrar en el ListBox)
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            NodoDoble actual = frente;
            while (actual != null)
            {
                empleados.Add(actual.Empleado);
                actual = actual.Siguiente;
            }
            return empleados;
        }

        // Mostrar la lista desde el final hacia el principio
        public List<Empleado> ObtenerEmpleadosInverso()
        {
            List<Empleado> empleados = new List<Empleado>();
            NodoDoble actual = final;
            while (actual != null)
            {
                empleados.Add(actual.Empleado);
                actual = actual.Anterior;
            }
            return empleados;
        }
    }

}
