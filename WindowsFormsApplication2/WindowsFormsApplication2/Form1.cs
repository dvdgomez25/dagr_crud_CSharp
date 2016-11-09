using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Estudiante estudianteSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Estudiante pEstudiante = new Estudiante();
            pEstudiante.Nombre = tNombre.Text.Trim();
            pEstudiante.Apellido1 = tApellido1.Text.Trim();
            pEstudiante.Apellido2 = tApellido2.Text.Trim();
            pEstudiante.Posicion = tPosicion.Text.Trim();
            pEstudiante.Id = listaDeporte.SelectedIndex + 1;
            pEstudiante.Codigo = pEstudiante.Nombre.Substring(0, 1)+ pEstudiante.Apellido1.Substring(0, 1)+pEstudiante.Apellido2.Substring(0, 1);

            int resultado = EstudianteDAL.Agregar(pEstudiante);
            if (resultado > 0)
            {
                MessageBox.Show("Estudiante Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                lista.DataSource = EstudianteDAL.Buscar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Estudiante", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            lista.DataSource = EstudianteDAL.Buscar();

        }

        private void lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.SelectedRows.Count == 1)
            {
                string cod = Convert.ToString(lista.CurrentRow.Cells[6].Value);
                estudianteSeleccionado = EstudianteDAL.ObtenerEstudiante(cod);
            }
            if (estudianteSeleccionado != null)
            {
                tNombre.Text = estudianteSeleccionado.Nombre;
                tApellido1.Text = estudianteSeleccionado.Apellido1;
                tApellido2.Text = estudianteSeleccionado.Apellido2;
                tPosicion.Text = estudianteSeleccionado.Posicion;
                listaDeporte.SelectedIndex = estudianteSeleccionado.Id - 1;

            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Estudiante pEstudiante = new Estudiante();
            pEstudiante.Nombre = tNombre.Text.Trim();
            pEstudiante.Apellido1 = tApellido1.Text.Trim();
            pEstudiante.Apellido2 = tApellido2.Text.Trim();
            pEstudiante.Posicion = tPosicion.Text.Trim();
            pEstudiante.Id = listaDeporte.SelectedIndex + 1;
            pEstudiante.Codigo = pEstudiante.Nombre.Substring(0, 1) + pEstudiante.Apellido1.Substring(0, 1) + pEstudiante.Apellido2.Substring(0, 1);
            

            int resultado = EstudianteDAL.Actualizar(pEstudiante);
            if (resultado > 0)
            {
                MessageBox.Show("Estudiante actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                lista.DataSource = EstudianteDAL.Buscar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Estudiante", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Estudiante Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EstudianteDAL.Eliminar(estudianteSeleccionado.Codigo) > 0)
                {
                    MessageBox.Show("Estudiante Eliminado Correctamente!", "Estudiante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    lista.DataSource = EstudianteDAL.Buscar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Estudiante", "Estudiante No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void limpiarCampos() {
            tNombre.Text = "";
            tApellido1.Text = "";
            tApellido2.Text = "";
            tPosicion.Text = "";
            listaDeporte.SelectedIndex = -1;
        }
    }
}
