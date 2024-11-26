using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.DataStructures
{
    public class ColaCircular
    {
        private Empleado[] arreglo;
        private int frente;
        private int final;
        private int capacidad;
        private int cantidad;

        // Constructor de la cola circular
        public ColaCircular(int capacidad)
        {
            this.capacidad = capacidad;
            arreglo = new Empleado[capacidad];
            frente = 0;
            final = -1;
            cantidad = 0;
        }

        // Verificar si la cola está vacía
        public bool EstaVacia()
        {
            return cantidad == 0;
        }

        // Verificar si la cola está llena
        public bool EstaLlena()
        {
            return cantidad == capacidad;
        }

        // Agregar un empleado a la cola (al final)
        public bool Encolar(Empleado empleado)
        {
            if (EstaLlena())
            {
                MessageBox.Show("La cola está llena");
                return false;
            }
            final = (final + 1) % capacidad;  // Usamos módulo para hacer la cola circular
            arreglo[final] = empleado;
            cantidad++;
            return true;
        }

        // Eliminar un empleado de la cola (del frente)
        public Empleado Desencolar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La cola está vacía");
                return null;
            }
            Empleado empleado = arreglo[frente];
            frente = (frente + 1) % capacidad;  // Avanzamos el frente usando módulo
            cantidad--;
            return empleado;
        }

        // Obtener los empleados de la cola (para mostrarlos)
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            if (!EstaVacia())
            {
                int index = frente;
                for (int i = 0; i < cantidad; i++)
                {
                    empleados.Add(arreglo[index]);
                    index = (index + 1) % capacidad;  // Usamos módulo para recorrer la cola circular
                }
            }
            return empleados;
        }
    }

}
