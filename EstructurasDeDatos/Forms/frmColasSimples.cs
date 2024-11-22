using Controlador;
using EstructurasDeDatos.DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos.Forms
{
    public partial class frmColasSimples : Form
    {
        private ColasSimples<Empleado> colaEmpleados;

        public frmColasSimples()
        {
            InitializeComponent();
            colaEmpleados = new ColasSimples<Empleado>(10); // Capacidad de 10 elementos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string rol = txtRol.Text.Trim();
            string usuario = txtUsuario.Text.Trim();

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(rol) && !string.IsNullOrEmpty(usuario))
            {
                var empleado = new Empleado
                {
                    Nombre = nombre,
                    Rol = rol,
                    Usuario = usuario
                };

                if (colaEmpleados.Enqueue(empleado))
                {
                    MessageBox.Show("Empleado agregado a la cola.", "Éxito");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("La cola está llena.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = colaEmpleados.Dequeue();
                MessageBox.Show($"Empleado eliminado: {empleado.Nombre}", "Éxito");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            var elementos = colaEmpleados.ObtenerElementos();
            dgvEmpleados.Rows.Clear();
            foreach (var empleado in elementos)
            {
                dgvEmpleados.Rows.Add(empleado.Nombre, empleado.Rol, empleado.Usuario);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtRol.Clear();
            txtUsuario.Clear();
        }

        public class Empleado
        {
            public string Nombre { get; set; }
            public string Rol { get; set; }
            public string Usuario { get; set; }
        }
    }
}
