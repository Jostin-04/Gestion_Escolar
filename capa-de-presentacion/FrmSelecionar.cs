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

namespace capa_de_presentacion
{
    public partial class FrmSelecionar : Form
    {
        public FrmSelecionar()
        {
            InitializeComponent();

            dgvEstudiante.DataSource = bL.Seleccionar();
        }

        private Buscar_MatBL bL = new Buscar_MatBL();

        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }

        public string Area { get; set; }

        private void dgvEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEstudiante = Convert.ToInt32(
                dgvEstudiante.CurrentRow.Cells["Id_Estudiante"].Value);

            NombreEstudiante = dgvEstudiante.CurrentRow.Cells["Nombre"]
                .Value.ToString();

            Area = dgvEstudiante.CurrentRow.Cells["Area_tecnica"]
                .Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
