using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace capa_de_presentacion
{
    public partial class FrmEstudianteMP : Form
    {
        public FrmEstudianteMP()
        {
            InitializeComponent();
            Listar();
            this.WindowState = FormWindowState.Maximized;
        }

        private ProfesoreBL bl = new ProfesoreBL();
        private int idSeleccionado = 0;

        private void CargarDatosDesdeGrid()
        {
            if (dgvEstudiante.CurrentRow == null) return;

            idSeleccionado = Convert.ToInt32(
                dgvEstudiante.CurrentRow.Cells["Id_profesor"].Value);

            txtNombre.Text =
                dgvEstudiante.CurrentRow.Cells["Nombre_prof"].Value.ToString();

            txtApellidos.Text =
                dgvEstudiante.CurrentRow.Cells["Apellido_prof"].Value.ToString();

            txtDireccion.Text =
                dgvEstudiante.CurrentRow.Cells["Direccion"].Value.ToString();

            txtTelefono.Text =
                dgvEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();

            txtEmail.Text =
                dgvEstudiante.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void Listar()
        {
            dgvEstudiante.DataSource = bl.Listar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lblEstudiante_Click(object sender, EventArgs e)
        {
            FrmEstudiante f2 = new FrmEstudiante();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblProdesor_Click(object sender, EventArgs e)
        {
            FrmEstudianteMP f2 = new FrmEstudianteMP();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {
            FrmReporteEstudiante f2 = new FrmReporteEstudiante();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblClases_Click(object sender, EventArgs e)
        {
            FrmEstMat f2 = new FrmEstMat();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.CurrentRow != null)
            {
                idSeleccionado = Convert.ToInt32(dgvEstudiante.CurrentRow.Cells["Id_profesor"].Value);
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres borrar este registro?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bl.Eliminar(new Profesores { Id_profesor = idSeleccionado });
                    Limpiar();
                    Listar();

                    MessageBox.Show("Profesor eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;

            btnActualiza.Enabled = true;
            btnActualiza.Visible = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;

            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;

            btnGuardar.Enabled = false;
            btnGuardar.Visible = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnActualiza.Enabled = false;
            btnActualiza.Visible = false;
            idSeleccionado = 0;
            Limpiar();
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            Profesores c = new Profesores
            {
                Id_profesor = idSeleccionado,
                Nombre_prof = txtNombre.Text,
                Apellido_prof = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };

            bl.Actualizar(c);
            Limpiar();
            Listar();

            MessageBox.Show("Estudiante actualizado correctamente");
        }
        private bool CamposVacios()
        {
            if (txtNombre.Text == "" ||
                txtApellidos.Text == "" ||
                txtDireccion.Text == "" ||
                txtTelefono.Text == "" ||
                txtEmail.Text == "" )

            {
                MessageBox.Show("Debe completar todos los campos",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios()) return;

            Profesores c = new Profesores
            {
                Id_profesor = idSeleccionado,
                Nombre_prof = txtNombre.Text,
                Apellido_prof = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };

            bl.Guardar(c);
            Limpiar();
            Listar();

            MessageBox.Show("Estudiante guardado correctamente");
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            FrmHome f2 = new FrmHome();
            f2.ShowDialog();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
