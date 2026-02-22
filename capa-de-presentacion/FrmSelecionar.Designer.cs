namespace capa_de_presentacion
{
    partial class FrmSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.Id_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area_tecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
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
            this.Area_tecnica});
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
            this.dgvEstudiante.Location = new System.Drawing.Point(23, 31);
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
            this.dgvEstudiante.Size = new System.Drawing.Size(682, 506);
            this.dgvEstudiante.TabIndex = 1;
            this.dgvEstudiante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellDoubleClick);
            // 
            // Id_Estudiante
            // 
            this.Id_Estudiante.DataPropertyName = "Id_Estudiante";
            this.Id_Estudiante.HeaderText = "Id_Estudiante";
            this.Id_Estudiante.Name = "Id_Estudiante";
            this.Id_Estudiante.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_Completo";
            this.Nombre.HeaderText = "Nombre del Estudiante";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Area_tecnica
            // 
            this.Area_tecnica.DataPropertyName = "Area_Tecnica";
            this.Area_tecnica.HeaderText = "Area Tecnica";
            this.Area_tecnica.Name = "Area_tecnica";
            this.Area_tecnica.ReadOnly = true;
            this.Area_tecnica.Width = 250;
            // 
            // FrmSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 573);
            this.Controls.Add(this.dgvEstudiante);
            this.Name = "FrmSelecionar";
            this.Text = "FrmSelecionar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_tecnica;
    }
}