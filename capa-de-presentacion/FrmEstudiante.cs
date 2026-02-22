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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace capa_de_presentacion
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
            Listar();  
            cmbArea.Items.Add("Contabilidad");
            cmbArea.Items.Add("Electricidad");
            cmbArea.Items.Add("Enfermería");
            cmbArea.Items.Add("Gastronomía");
            cmbArea.Items.Add("Informática");
            this.WindowState = FormWindowState.Maximized;
        }

        private EstudianteBl bl = new EstudianteBl();
        private int idSeleccionado = 0;

        private void Listar()
        {
            dgvEstudiante.DataSource = bl.Listar();
        }
        private void CargarDatosDesdeGrid()
        {
            if (dgvEstudiante.CurrentRow == null) return;

            idSeleccionado = Convert.ToInt32(
                dgvEstudiante.CurrentRow.Cells["Id_Estudiante"].Value);

            txtNombre.Text =
                dgvEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();

            txtApellidos.Text =
                dgvEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();

            txtDireccion.Text =
                dgvEstudiante.CurrentRow.Cells["Direccion"].Value.ToString();

            txtTelefono.Text =
                dgvEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();

            txtEmail.Text =
                dgvEstudiante.CurrentRow.Cells["Email"].Value.ToString();

            cmbArea.Text =
                dgvEstudiante.CurrentRow.Cells["Area_Tecnica"].Value.ToString();
        }

        private void dgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtBuscar.Clear();
            cmbArea.SelectedIndex = -1;
            cmbArea.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int ObtenerIdArea()
        {
            switch (cmbArea.SelectedItem.ToString())
            {
                case "Contabilidad": return 1;
                case "Electricidad": return 2;
                case "Enfermería": return 3;
                case "Gastronomía": return 4;
                case "Informática": return 5;
                default: return 0;
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvEstudiante.CurrentRow != null)
            {
                idSeleccionado = Convert.ToInt32(dgvEstudiante.CurrentRow.Cells["Id_Estudiante"].Value);
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres borrar este registro?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bl.Eliminar(new Estudiante { Id_Estudiante = idSeleccionado });
                    Limpiar();
                    Listar();

                    MessageBox.Show("Estudiante eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero.");
            }
        }

        private bool CamposVacios()
        {
            if (txtNombre.Text == "" ||
                txtApellidos.Text == "" ||
                txtDireccion.Text == "" ||
                txtTelefono.Text == "" ||
                txtEmail.Text == "" ||
                cmbArea.Text == "")

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
            int idArea = ObtenerIdArea();

            if (idArea == 0)
            {
                MessageBox.Show("Área técnica no válida");
                return;
            }
            Estudiante c = new Estudiante
            {
                Id_Estudiante = idSeleccionado,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                ID_Area_tecnica = idArea
            };

            bl.Guardar(c);
            Limpiar();
            Listar();

            MessageBox.Show("Estudiante guardado correctamente");
        }
        
        private void btnActualiza_Click(object sender, EventArgs e)
        {
            int idArea = ObtenerIdArea();

            if (idArea == 0)
            {
                MessageBox.Show("Área técnica no válida");
                return;
            }

            Estudiante c = new Estudiante
            {
                Id_Estudiante = idSeleccionado,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                ID_Area_tecnica = idArea
            };

            bl.Actualizar(c);
            Limpiar();
            Listar();

            MessageBox.Show("Estudiante actualizado correctamente");


        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosDesdeGrid();
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            cmbArea.Enabled = true;

            btnActualiza.Enabled = true;
            btnActualiza.Visible = true;
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;

        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            cmbArea.Enabled = true;

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
            cmbArea.Enabled = false;
            cmbArea.Enabled = false;

            btnGuardar.Enabled = false;
            btnGuardar.Visible = false;
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnActualiza.Enabled = false;
            btnActualiza.Visible = false;
            idSeleccionado = 0;
            Limpiar();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEstudiante.DataSource = bl.Buscar(txtBuscar.Text);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteEstudiante f2 = new FrmReporteEstudiante();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            FrmHome f2 = new FrmHome();
            f2.ShowDialog();
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
    }
}
