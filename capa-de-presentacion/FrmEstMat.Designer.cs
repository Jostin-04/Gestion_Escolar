namespace capa_de_presentacion
{
    partial class FrmEstMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstMat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClases = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lblProdesor = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 65;
            // 
            // lblClases
            // 
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClases.Image = ((System.Drawing.Image)(resources.GetObject("lblClases.Image")));
            this.lblClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClases.Location = new System.Drawing.Point(56, 323);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(137, 21);
            this.lblClases.TabIndex = 4;
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
            this.lblReporte.Location = new System.Drawing.Point(56, 273);
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
            this.lblEstudiante.Location = new System.Drawing.Point(56, 178);
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
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(468, 177);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(131, 21);
            this.cmbArea.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 29);
            this.label8.TabIndex = 63;
            this.label8.Text = "Registrar Materia al Estudiante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(885, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Listado de Materias y Profesor que la Imparte";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Location = new System.Drawing.Point(356, 360);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(665, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 38);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardar.Location = new System.Drawing.Point(511, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 38);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "Area tecnica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Estudiante";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(468, 132);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(131, 20);
            this.txtEstudiante.TabIndex = 56;
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToAddRows = false;
            this.dgvBuscar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvBuscar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvBuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscar.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscar.ColumnHeadersHeight = 30;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Materia,
            this.Nombre_Materia,
            this.Id_profesor,
            this.Nombre_prof});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscar.EnableHeadersVisualStyles = false;
            this.dgvBuscar.GridColor = System.Drawing.Color.LightGray;
            this.dgvBuscar.Location = new System.Drawing.Point(850, 82);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscar.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvBuscar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(431, 633);
            this.dgvBuscar.TabIndex = 55;
            this.dgvBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellDoubleClick);
            // 
            // Id_Materia
            // 
            this.Id_Materia.DataPropertyName = "Id_Materia";
            this.Id_Materia.HeaderText = "Id_Materia";
            this.Id_Materia.Name = "Id_Materia";
            this.Id_Materia.ReadOnly = true;
            this.Id_Materia.Visible = false;
            this.Id_Materia.Width = 5;
            // 
            // Nombre_Materia
            // 
            this.Nombre_Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre_Materia.DataPropertyName = "Nombre_Materia";
            this.Nombre_Materia.HeaderText = "Materia";
            this.Nombre_Materia.Name = "Nombre_Materia";
            this.Nombre_Materia.ReadOnly = true;
            this.Nombre_Materia.Width = 200;
            // 
            // Id_profesor
            // 
            this.Id_profesor.DataPropertyName = "Id_profesor";
            this.Id_profesor.HeaderText = "Id_profesor";
            this.Id_profesor.Name = "Id_profesor";
            this.Id_profesor.ReadOnly = true;
            this.Id_profesor.Visible = false;
            this.Id_profesor.Width = 5;
            // 
            // Nombre_prof
            // 
            this.Nombre_prof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre_prof.DataPropertyName = "Nombre_prof";
            this.Nombre_prof.HeaderText = "Profesor";
            this.Nombre_prof.Name = "Nombre_prof";
            this.Nombre_prof.ReadOnly = true;
            this.Nombre_prof.Width = 200;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstudiante.Location = new System.Drawing.Point(644, 199);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(122, 46);
            this.btnEstudiante.TabIndex = 66;
            this.btnEstudiante.Text = "Selecionar Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Profesor";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(468, 229);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(131, 20);
            this.txtMateria.TabIndex = 69;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(468, 272);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(131, 20);
            this.txtProfesor.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(983, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "Seleciona la materia a cursar";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReporte.Location = new System.Drawing.Point(511, 529);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(101, 48);
            this.btnReporte.TabIndex = 72;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Reporte de Materias  del Estudiante a Cursar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 15);
            this.label9.TabIndex = 74;
            this.label9.Text = "Para ver el reporte seleccione el estudiante y dele al boton de reporte ";
            // 
            // FrmEstMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.dgvBuscar);
            this.Name = "FrmEstMat";
            this.Text = "FrmEstMat";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lblProdesor;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_prof;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}