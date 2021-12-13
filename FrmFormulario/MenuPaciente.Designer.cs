namespace FrmFormulario
{
    partial class MenuPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPacientes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombrePaciente = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.rbSiAtendido = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rbNoAtendido = new System.Windows.Forms.RadioButton();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(681, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "DETALLE ";
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.White;
            this.btnSolicitar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolicitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSolicitar.Location = new System.Drawing.Point(137, 56);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(175, 35);
            this.btnSolicitar.TabIndex = 17;
            this.btnSolicitar.Text = "Solicitar Turno";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.White;
            this.btnDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDatos.Location = new System.Drawing.Point(12, 56);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(110, 35);
            this.btnDatos.TabIndex = 16;
            this.btnDatos.Text = "MisDatos";
            this.btnDatos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datos Paciente";
            // 
            // lbNombrePaciente
            // 
            this.lbNombrePaciente.AutoSize = true;
            this.lbNombrePaciente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombrePaciente.Location = new System.Drawing.Point(25, 150);
            this.lbNombrePaciente.Name = "lbNombrePaciente";
            this.lbNombrePaciente.Size = new System.Drawing.Size(90, 25);
            this.lbNombrePaciente.TabIndex = 20;
            this.lbNombrePaciente.Text = "Nombre :";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEdad.Location = new System.Drawing.Point(42, 244);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(63, 25);
            this.lbEdad.TabIndex = 21;
            this.lbEdad.Text = "Edad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "DNI :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Obra Social : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enfermedad : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 26;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(149, 113);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 33);
            this.txtDni.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(149, 196);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 33);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(149, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 33);
            this.txtNombre.TabIndex = 30;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnfermedad.Location = new System.Drawing.Point(149, 319);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(100, 33);
            this.txtEnfermedad.TabIndex = 31;
            // 
            // rbSiAtendido
            // 
            this.rbSiAtendido.AutoSize = true;
            this.rbSiAtendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSiAtendido.Location = new System.Drawing.Point(121, 386);
            this.rbSiAtendido.Name = "rbSiAtendido";
            this.rbSiAtendido.Size = new System.Drawing.Size(45, 29);
            this.rbSiAtendido.TabIndex = 32;
            this.rbSiAtendido.TabStop = true;
            this.rbSiAtendido.Text = "SI";
            this.rbSiAtendido.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "ATENDIDO :";
            // 
            // rbNoAtendido
            // 
            this.rbNoAtendido.AutoSize = true;
            this.rbNoAtendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoAtendido.Location = new System.Drawing.Point(121, 411);
            this.rbNoAtendido.Name = "rbNoAtendido";
            this.rbNoAtendido.Size = new System.Drawing.Size(58, 29);
            this.rbNoAtendido.TabIndex = 34;
            this.rbNoAtendido.TabStop = true;
            this.rbNoAtendido.Text = "NO";
            this.rbNoAtendido.UseVisualStyleBackColor = true;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Items.AddRange(new object[] {
            "No tiene",
            "Cobertura Basica",
            "Cobertura Completa"});
            this.cmbObraSocial.Location = new System.Drawing.Point(149, 280);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(121, 29);
            this.cmbObraSocial.TabIndex = 35;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.Location = new System.Drawing.Point(149, 241);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 33);
            this.txtEdad.TabIndex = 36;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(222, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(863, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "limpiar Grilla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.cmObraSocial,
            this.Enfermedad,
            this.estado});
            this.gridPacientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPacientes.Location = new System.Drawing.Point(419, 79);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowTemplate.Height = 25;
            this.gridPacientes.Size = new System.Drawing.Size(847, 361);
            this.gridPacientes.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cmObraSocial
            // 
            this.cmObraSocial.HeaderText = "Obra Social";
            this.cmObraSocial.Name = "cmObraSocial";
            // 
            // Enfermedad
            // 
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.Name = "Enfermedad";
            // 
            // estado
            // 
            this.estado.HeaderText = "Atendido";
            this.estado.Name = "estado";
            // 
            // MenuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1278, 450);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmbObraSocial);
            this.Controls.Add(this.rbNoAtendido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbSiAtendido);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombrePaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPacientes";
            this.Text = "MenuPacientes";
            this.Load += new System.EventHandler(this.MenuPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSolicitar;
        private Button btnDatos;
        private Label label2;
        private Label lbNombrePaciente;
        private Label lbEdad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtEnfermedad;
        private RadioButton rbSiAtendido;
        private Label label8;
        private RadioButton rbNoAtendido;
        private ComboBox cmbObraSocial;
        private TextBox txtEdad;
        private Button btnSalir;
        private Button button1;
        private DataGridView gridPacientes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn cmObraSocial;
        private DataGridViewTextBoxColumn Enfermedad;
        private DataGridViewTextBoxColumn estado;
    }
}