using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }

        public Empleado(string nombre, string usuario, string rol)
        {
            Nombre = nombre;
            Usuario = usuario;
            Rol = rol;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Usuario}) - {Rol}";
        }
    }

}
