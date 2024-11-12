using Controllers.DataSets;
using Controllers.DataSets.dsEmpleadosTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Empleados
    {
        Int64 IDEmpleado;
        Boolean tiene_datos;

        dsEmpleados.EmpleadosRow datos;

        Controllers.DataSets.dsEmpleadosTableAdapters.EmpleadosTableAdapter q;

        #region Constructores
        public Empleados()
        {
            this.q = new Controllers.DataSets.dsEmpleadosTableAdapters.EmpleadosTableAdapter();
            this.IDEmpleado = -1;
            this.tiene_datos = false;
        }

        public Empleados(Int64 IDEmpleado)
        {
            this.q = new Controllers.DataSets.dsEmpleadosTableAdapters.EmpleadosTableAdapter();
            this.IDEmpleado = IDEmpleado;
            this.datos = q.GetDataByID((int)this.IDEmpleado)[0];
            this.tiene_datos = true;
        }
        #endregion

        #region Datos
        public Int64 Insertar(string NombreEmpleado, string CargoEmpleado, string Contraseña, string Usuario)
        {
            if (q.Connection.State != ConnectionState.Open)
            {
                q.Connection.Open();
            }

            q.Insertar(NombreEmpleado, CargoEmpleado, Contraseña, Usuario);
            int last_id = q.GetDataByLastID()[0].IDEmpleado;
            return last_id;
        }

        public Boolean Actualizar(string NombreEmpleado, string CargoEmpleado, string Contraseña, string Usuario)
        {

            if (q.Connection.State != ConnectionState.Open)
            {
                q.Connection.Open();
            }

            q.Actualizar(NombreEmpleado, CargoEmpleado, Contraseña, Usuario, (int)this.IDEmpleado);
            int id = q.GetDataByID((int)this.IDEmpleado)[0].IDEmpleado;
            return true;
        }

        public Boolean Eliminar()
        {
            if (q.Connection.State != ConnectionState.Open)
            {
                q.Connection.Open();
            }

            try
            {
                q.Eliminar((int)this.IDEmpleado);
                int id = q.GetDataByID((int)this.IDEmpleado)[0].IDEmpleado;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean TieneDatos()
        {
            return this.tiene_datos;
        }
        #endregion

        #region Getters

        public Int64 GetIdUsuarioExistente(string Usuario)
        {
            Int64 idusuarioex = q.GetDataByUsuario(Usuario)[0].IDEmpleado;
            return idusuarioex;
        }

        public String GetCargo()
        {
            String empleadoCargo = this.datos.CargoEmpleado;
            return empleadoCargo;
        }

        public String GetNombre()
        {
            String empleadoNombre = this.datos.NombreEmpleado;
            return empleadoNombre;
        }

        public Int64? GetUsuarioXNombre(string nombre)
        {
            try
            {
                Int64? idempleadonombre = q.GetDataByName(nombre)[0].IDEmpleado;
                if (idempleadonombre != null)
                {
                    return (Int64)idempleadonombre;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {

                return -1;
            }
        }

        public Boolean GetUsuarioExistente(string usuario)
        {
            try
            {
                Int64? idusuarioexist = this.q.GetDataByUsuario(usuario)[0].IDEmpleado;
                if (idusuarioexist != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean GetID(int IDEmpleado)
        {
            try
            {
                Int64? idempleado = this.q.GetDataByID(IDEmpleado)[0].IDEmpleado;
                if (idempleado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int validarDatos(string contraseña)
        {
            if (contraseña == this.datos.Contraseña)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        #endregion
    }
}