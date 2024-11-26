using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public class NodoDoble
    {
        public Empleado Empleado { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }

        public NodoDoble(Empleado empleado)
        {
            Empleado = empleado;
            Siguiente = null;
            Anterior = null;
        }
    }

}
