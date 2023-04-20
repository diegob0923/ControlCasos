namespace ControlCasos.Formularios.Casos
{
    partial class frmCasos
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
            this.dgvListaCasos = new System.Windows.Forms.DataGridView();
            this.IdCaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lnkNuevoCaso = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCasos
            // 
            this.dgvListaCasos.AllowUserToAddRows = false;
            this.dgvListaCasos.AllowUserToDeleteRows = false;
            this.dgvListaCasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCaso,
            this.Fecha,
            this.Doctor,
            this.Paciente,
            this.Detalles});
            this.dgvListaCasos.Location = new System.Drawing.Point(40, 323);
            this.dgvListaCasos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaCasos.Name = "dgvListaCasos";
            this.dgvListaCasos.ReadOnly = true;
            this.dgvListaCasos.RowHeadersWidth = 51;
            this.dgvListaCasos.RowTemplate.Height = 27;
            this.dgvListaCasos.Size = new System.Drawing.Size(739, 150);
            this.dgvListaCasos.TabIndex = 9;
            this.dgvListaCasos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCasos_CellContentClick);
            this.dgvListaCasos.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaCasos_CellMouseMove);
            this.dgvListaCasos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaCasos_CellPainting);
            // 
            // IdCaso
            // 
            this.IdCaso.DataPropertyName = "idCaso";
            this.IdCaso.FillWeight = 50F;
            this.IdCaso.HeaderText = "ID";
            this.IdCaso.MinimumWidth = 6;
            this.IdCaso.Name = "IdCaso";
            this.IdCaso.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Doctor
            // 
            this.Doctor.DataPropertyName = "Doctor";
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 6;
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // Detalles
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap";
            this.Detalles.DefaultCellStyle = dataGridViewCellStyle1;
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Image = global::ControlCasos.Properties.Resources.btnAbrir;
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaciente.DisplayMember = "Paciente";
            this.cmbPaciente.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(41, 205);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(561, 26);
            this.cmbPaciente.TabIndex = 6;
            this.cmbPaciente.ValueMember = "Paciente";
            this.cmbPaciente.SelectedValueChanged += new System.EventHandler(this.cmbPaciente_SelectedValueChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctor.DisplayMember = "Doctor";
            this.cmbDoctor.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(41, 129);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(561, 26);
            this.cmbDoctor.TabIndex = 5;
            this.cmbDoctor.ValueMember = "idDoctor";
            this.cmbDoctor.SelectedValueChanged += new System.EventHandler(this.cmbDoctor_SelectedValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "Detalles";
            this.dataGridViewImageColumn1.Image = global::ControlCasos.Properties.Resources.buscar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 152;
            // 
            // lnkNuevoCaso
            // 
            this.lnkNuevoCaso.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.lnkNuevoCaso.AutoSize = true;
            this.lnkNuevoCaso.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNuevoCaso.LinkColor = System.Drawing.Color.Teal;
            this.lnkNuevoCaso.Location = new System.Drawing.Point(681, 298);
            this.lnkNuevoCaso.Name = "lnkNuevoCaso";
            this.lnkNuevoCaso.Size = new System.Drawing.Size(98, 21);
            this.lnkNuevoCaso.TabIndex = 11;
            this.lnkNuevoCaso.TabStop = true;
            this.lnkNuevoCaso.Text = "Nuevo Caso";
            this.lnkNuevoCaso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoCaso_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Casos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkNuevoCaso);
            this.Controls.Add(this.dgvListaCasos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.cmbDoctor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCasos";
            this.Text = "Casos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCasos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
        private System.Windows.Forms.LinkLabel lnkNuevoCaso;
        private System.Windows.Forms.Label label4;
    }
}