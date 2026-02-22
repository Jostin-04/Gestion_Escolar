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
    public partial class FrmEstMat : Form
    {
        public FrmEstMat()
        {
            InitializeComponent();
            dgvBuscar.DataSource = bL.ProfeMateria();
            this.WindowState = FormWindowState.Maximized;
        }

        private Buscar_MatBL bL = new Buscar_MatBL();

        private void lblClases_Click(object sender, EventArgs e)
        {
            FrmEstMat f2 = new FrmEstMat();
            f2.Show();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
        private bool CamposVacios()
        {
            if (txtEstudiante.Text == "" ||
                txtProfesor.Text == "" ||
                txtMateria.Text == "" ||
                cmbArea.Text == "")

            {
                MessageBox.Show("Debe completar todos los campos",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void Limpiar()
        {
            txtEstudiante.Clear();
            txtMateria.Clear();
            txtProfesor.Clear();
            cmbArea.Text = "";
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
        int idEstudianteSeleccionado;
        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FrmSelecionar f = new FrmSelecionar();

            if (f.ShowDialog() == DialogResult.OK)
            {
                txtEstudiante.Text = f.NombreEstudiante;
                cmbArea.Text = f.Area;
                idEstudianteSeleccionado = f.IdEstudiante;
            }
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMateria.Text = dgvBuscar.CurrentRow.Cells["Nombre_Materia"]
                .Value.ToString();

            txtProfesor.Text = dgvBuscar.CurrentRow.Cells["Nombre_prof"]
                .Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios()) return;

            Estudiante_Materia a = new Estudiante_Materia
            {
                Id_Estudiante = idEstudianteSeleccionado,
                Id_Materia = Convert.ToInt32( dgvBuscar.CurrentRow.Cells["Id_Materia"].Value),
                Id_profesor = Convert.ToInt32(dgvBuscar.CurrentRow.Cells["Id_Profesor"].Value)
            };

            bL.AgregarMateria(a);
            Limpiar();

            MessageBox.Show("Estudiante guardado correctamente");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporEstudianteMateria f2 = new FrmReporEstudianteMateria(idEstudianteSeleccionado);
            f2.ShowDialog();
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
    }
}
