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
        private Empleado[] arreglo;
        private int cima;
        private int capacidad;

        // Constructor
        public Pilas(int capacidad)
        {
            this.capacidad = capacidad;
            arreglo = new Empleado[capacidad];
            cima = -1;
        }

        // Método para verificar si la pila está vacía
        public bool EstaVacia()
        {
            return cima == -1;
        }

        // Método para verificar si la pila está llena
        public bool EstaLlena()
        {
            return cima == capacidad - 1;
        }

        // Método para agregar un empleado a la pila (apilar)
        public bool Apilar(Empleado empleado)
        {
            if (EstaLlena())
            {
                MessageBox.Show("La pila está llena");
                return false;
            }
            arreglo[++cima] = empleado;
            return true;
        }

        // Método para quitar un empleado de la pila (desapilar)
        public Empleado Desapilar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La pila está vacía");
                return null;
            }
            return arreglo[cima--];
        }

        // Método para obtener el empleado en la cima de la pila
        public Empleado Cima()
        {
            if (EstaVacia())
            {
                MessageBox.Show("La pila está vacía");
                return null;
            }
            return arreglo[cima];
        }

        // Método para obtener un empleado de la pila por su índice
        public Empleado this[int index]
        {
            get
            {
                if (index < 0 || index > cima) return null;
                return arreglo[index];
            }
        }
    }

}
