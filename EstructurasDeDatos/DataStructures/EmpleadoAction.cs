using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos.DataStructures
{
    public enum ActionType
    {
        Create,
        Update,
        Delete
    }

    public class EmpleadoAction
    {
        public ActionType Tipo { get; set; }
        public Int64 EmpleadoId { get; set; }
        public string NombreEmpleado { get; set; }
        public string CargoEmpleado { get; set; }
        public DateTime FechaAccion { get; set; } = DateTime.Now;

        public EmpleadoAction(ActionType tipo, Int64 empleadoId, string nombre, string cargo)
        {
            Tipo = tipo;
            EmpleadoId = empleadoId;
            NombreEmpleado = nombre;
            CargoEmpleado = cargo;
        }
    }
}
