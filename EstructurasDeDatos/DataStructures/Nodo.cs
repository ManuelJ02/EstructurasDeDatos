using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public class Nodo
    {
        public Empleado Empleado { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Empleado empleado)
        {
            Empleado = empleado;
            Siguiente = null; // Inicialmente no apunta a ningún nodo
        }
    }

}
