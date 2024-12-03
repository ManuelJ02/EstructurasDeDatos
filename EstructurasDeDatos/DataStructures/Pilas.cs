using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.DataStructures
{
    public class Pilas
    {
        private List<Empleado> empleados;
        private int capacidad;

        public Pilas(int capacidad)
        {
            this.capacidad = capacidad;
            empleados = new List<Empleado>();
        }

        // Método para apilar
        public bool Apilar(Empleado empleado)
        {
            if (empleados.Count < capacidad)
            {
                empleados.Add(empleado);
                return true;
            }
            return false;
        }

        // Método para desapilar
        public Empleado Desapilar()
        {
            if (empleados.Count > 0)
            {
                Empleado empleado = empleados.Last();
                empleados.RemoveAt(empleados.Count - 1);
                return empleado;
            }
            return null; // Retornar null si la pila está vacía
        }

        // Método para obtener la cima de la pila
        public Empleado Cima()
        {
            if (empleados.Count > 0)
            {
                return empleados.Last(); // Obtener el último empleado de la pila
            }
            return null; // Retornar null si la pila está vacía
        }

        // Método para obtener un empleado por índice
        public Empleado this[int index]
        {
            get
            {
                if (index >= 0 && index < empleados.Count)
                    return empleados[index];
                return null; // Retornar null si el índice es inválido
            }
        }

        // Método para obtener la cantidad de elementos en la pila
        public int Count()
        {
            return empleados.Count;
        }
    }


}
