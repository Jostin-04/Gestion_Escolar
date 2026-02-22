using CapaEntidades;
using CapaNegocio;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporEstudianteMateria : Form
    {
        public int IdEstudianteRecibido { get; set; }

        public FrmReporEstudianteMateria(int id)
        {
            InitializeComponent();
            IdEstudianteRecibido = id;
            this.WindowState = FormWindowState.Maximized;
        }

        private Buscar_MatBL bL = new Buscar_MatBL();

        private void FrmReporEstudianteMateria_Load(object sender, EventArgs e)
        {
            if (IdEstudianteRecibido > 0)
            {

                DataTable dt = bL.Reporte(IdEstudianteRecibido);

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds =
                    new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se recibió el ID del estudiante.");
            }
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

        private void lblInicio_Click(object sender, EventArgs e)
        {
            FrmHome f2 = new FrmHome();
            f2.ShowDialog();
            f2.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
