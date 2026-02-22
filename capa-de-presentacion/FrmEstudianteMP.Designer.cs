namespace capa_de_presentacion
{
    partial class FrmEstudianteMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudianteMP));
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.Id_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIreccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 768);
            this.panel1.TabIndex = 54;
            // 
            // lblClases
            // 
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClases.Image = ((System.Drawing.Image)(resources.GetObject("lblClases.Image")));
            this.lblClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClases.Location = new System.Drawing.Point(56, 314);
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
            this.lblReporte.Location = new System.Drawing.Point(56, 263);
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
            this.lblProdesor.Location = new System.Drawing.Point(56, 216);
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
            this.lblEstudiante.Location = new System.Drawing.Point(56, 170);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 29);
            this.label8.TabIndex = 49;
            this.label8.Text = "Gestion Escolar ";
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
            this.btnLimpiar.Location = new System.Drawing.Point(1212, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 38);
            this.btnLimpiar.TabIndex = 47;
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
            this.btnSalir.Location = new System.Drawing.Point(1147, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 38);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(705, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Listado De Profesores Activos";
            // 
            // btnActualiza
            // 
            this.btnActualiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnActualiza.Enabled = false;
            this.btnActualiza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualiza.FlatAppearance.BorderSize = 0;
            this.btnActualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.ForeColor = System.Drawing.SystemColors.Info;
            this.btnActualiza.Location = new System.Drawing.Point(413, 240);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(88, 54);
            this.btnActualiza.TabIndex = 69;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.UseVisualStyleBackColor = false;
            this.btnActualiza.Visible = false;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancelar.Location = new System.Drawing.Point(538, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 54);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardar.Location = new System.Drawing.Point(413, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 54);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(753, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(598, 114);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(131, 20);
            this.txtApellidos.TabIndex = 60;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(598, 184);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 59;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(844, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(131, 20);
            this.txtDireccion.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(391, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(131, 20);
            this.txtEmail.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(391, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiante.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvEstudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiante.ColumnHeadersHeight = 30;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Estudiante,
            this.Nombre,
            this.Apellidos,
            this.DIreccion,
            this.Telefono,
            this.Email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiante.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiante.EnableHeadersVisualStyles = false;
            this.dgvEstudiante.GridColor = System.Drawing.Color.LightGray;
            this.dgvEstudiante.Location = new System.Drawing.Point(355, 393);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstudiante.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstudiante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(820, 324);
            this.dgvEstudiante.TabIndex = 55;
            // 
            // Id_Estudiante
            // 
            this.Id_Estudiante.DataPropertyName = "Id_profesor";
            this.Id_Estudiante.HeaderText = "N# Profesor";
            this.Id_Estudiante.Name = "Id_Estudiante";
            this.Id_Estudiante.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_prof";
            this.Nombre.HeaderText = "Nombre del Profesor";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 140;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellido_prof";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 126;
            // 
            // DIreccion
            // 
            this.DIreccion.DataPropertyName = "Direccion";
            this.DIreccion.HeaderText = "Direccion";
            this.DIreccion.Name = "DIreccion";
            this.DIreccion.ReadOnly = true;
            this.DIreccion.Width = 154;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 126;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 142;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(1085, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 38);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnInsertar.Location = new System.Drawing.Point(1085, 44);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(101, 54);
            this.btnInsertar.TabIndex = 74;
            this.btnInsertar.Text = "Insertar Estudiante";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnActualizar.Location = new System.Drawing.Point(1212, 44);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 54);
            this.btnActualizar.TabIndex = 75;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmEstudianteMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmEstudianteMP";
            this.Text = "FrmEstudianteMP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lblProdesor;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIreccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
    }
}