namespace pryTomasCeballosGestorDeTareas
{
    partial class frmGestorDeTareas
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
            lblTareas = new Label();
            lblPrioridad = new Label();
            lblFecha = new Label();
            lblMisTareas = new Label();
            txtTareas = new TextBox();
            cmbPrioridad = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAgregar = new Button();
            lstTarea = new CheckedListBox();
            btnCompletar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(5, 38);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(35, 15);
            lblTareas.TabIndex = 0;
            lblTareas.Text = "Tarea";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(4, 74);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(55, 15);
            lblPrioridad.TabIndex = 1;
            lblPrioridad.Text = "Prioridad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(9, 110);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblMisTareas
            // 
            lblMisTareas.AutoSize = true;
            lblMisTareas.Location = new Point(134, 9);
            lblMisTareas.Name = "lblMisTareas";
            lblMisTareas.Size = new Size(59, 15);
            lblMisTareas.TabIndex = 3;
            lblMisTareas.Text = "MisTareas";
            // 
            // txtTareas
            // 
            txtTareas.Location = new Point(67, 30);
            txtTareas.Name = "txtTareas";
            txtTareas.Size = new Size(201, 23);
            txtTareas.TabIndex = 4;
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPrioridad.Location = new Point(75, 71);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(193, 23);
            cmbPrioridad.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(66, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(118, 148);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstTarea
            // 
            lstTarea.FormattingEnabled = true;
            lstTarea.Location = new Point(94, 179);
            lstTarea.Name = "lstTarea";
            lstTarea.Size = new Size(120, 94);
            lstTarea.TabIndex = 8;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(75, 281);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(75, 23);
            btnCompletar.TabIndex = 9;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(170, 279);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 27);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmGestorDeTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 324);
            Controls.Add(btnEliminar);
            Controls.Add(btnCompletar);
            Controls.Add(lstTarea);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbPrioridad);
            Controls.Add(txtTareas);
            Controls.Add(lblMisTareas);
            Controls.Add(lblFecha);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTareas);
            Name = "frmGestorDeTareas";
            Text = "frmGestorDeTareas";
            Load += frmGestorDeTareas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTareas;
        private Label lblPrioridad;
        private Label lblFecha;
        private Label lblMisTareas;
        private TextBox txtTareas;
        private ComboBox cmbPrioridad;
        private DateTimePicker dateTimePicker1;
        private Button btnAgregar;
        private CheckedListBox lstTarea;
        private Button btnCompletar;
        private Button btnEliminar;
    }
}