using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public class ColasSimples<T>
    {
        private List<T> elementos = new List<T>();
        private int cant;

        public ColasSimples(int cant)
        {
            this.cant = cant;
        }

        public bool Enqueue(T elemento)
        {
            if (elementos.Count < cant)
            {
                elementos.Add(elemento);
                return true;
            }
            return false;
        }

        public T Dequeue()
        {
            if (elementos.Count > 0)
            {
                T elemento = elementos[0];
                elementos.RemoveAt(0);
                return elemento;
            }
            throw new InvalidOperationException("La cola está vacía.");
        }

        public List<T> ObtenerElementos()
        {
            return new List<T>(elementos);
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public bool EstaLlena()
        {
            return elementos.Count >= cant;
        }
    }
}
