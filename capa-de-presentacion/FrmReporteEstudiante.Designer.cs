namespace capa_de_presentacion
{
    partial class FrmReporteEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEstudiante));
            this.splistarestudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEscolarDataSet = new capa_de_presentacion.GestionEscolarDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listar_estudianteTableAdapter = new capa_de_presentacion.GestionEscolarDataSetTableAdapters.sp_listar_estudianteTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClases = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lblProdesor = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splistarestudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splistarestudianteBindingSource
            // 
            this.splistarestudianteBindingSource.DataMember = "sp_listar_estudiante";
            this.splistarestudianteBindingSource.DataSource = this.gestionEscolarDataSet;
            // 
            // gestionEscolarDataSet
            // 
            this.gestionEscolarDataSet.DataSetName = "GestionEscolarDataSet";
            this.gestionEscolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Estudiantes_activos";
            reportDataSource1.Value = this.splistarestudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capa_de_presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(261, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1111, 746);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_listar_estudianteTableAdapter
            // 
            this.sp_listar_estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lblClases);
            this.panel1.Controls.Add(this.lblReporte);
            this.panel1.Controls.Add(this.lblProdesor);
            this.panel1.Controls.Add(this.lblEstudiante);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 764);
            this.panel1.TabIndex = 55;
            // 
            // lblClases
            // 
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClases.Image = ((System.Drawing.Image)(resources.GetObject("lblClases.Image")));
            this.lblClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClases.Location = new System.Drawing.Point(56, 330);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(137, 21);
            this.lblClases.TabIndex = 5;
            this.lblClases.Text = "Clases";
            this.lblClases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClases.Click += new System.EventHandler(this.lblClases_Click);
            // 
            // lblReporte
            // 
            this.lblReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReporte.Image = ((System.Drawing.Image)(resources.GetObject("lblReporte.Image")));
            this.lblReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReporte.Location = new System.Drawing.Point(56, 278);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(137, 21);
            this.lblReporte.TabIndex = 3;
            this.lblReporte.Text = "Reportes";
            this.lblReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReporte.Click += new System.EventHandler(this.lblReporte_Click);
            // 
            // lblProdesor
            // 
            this.lblProdesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProdesor.Image = ((System.Drawing.Image)(resources.GetObject("lblProdesor.Image")));
            this.lblProdesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProdesor.Location = new System.Drawing.Point(56, 226);
            this.lblProdesor.Name = "lblProdesor";
            this.lblProdesor.Size = new System.Drawing.Size(152, 23);
            this.lblProdesor.TabIndex = 2;
            this.lblProdesor.Text = "Profesores";
            this.lblProdesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProdesor.Click += new System.EventHandler(this.lblProdesor_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("lblEstudiante.Image")));
            this.lblEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstudiante.Location = new System.Drawing.Point(56, 176);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(166, 23);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "Estudiantes";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstudiante.Click += new System.EventHandler(this.lblEstudiante_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInicio.Image = ((System.Drawing.Image)(resources.GetObject("lblInicio.Image")));
            this.lblInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInicio.Location = new System.Drawing.Point(56, 116);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(89, 32);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "      Inicio";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // FrmReporteEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteEstudiante";
            this.Text = "FrmReporteEstudiante";
            this.Load += new System.EventHandler(this.FrmReporteEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarestudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEscolarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GestionEscolarDataSet gestionEscolarDataSet;
        private System.Windows.Forms.BindingSource splistarestudianteBindingSource;
        private GestionEscolarDataSetTableAdapters.sp_listar_estudianteTableAdapter sp_listar_estudianteTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lblProdesor;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblClases;
    }
}