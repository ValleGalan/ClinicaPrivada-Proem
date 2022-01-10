namespace FrmFormulario
{
    partial class MenuMedicos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtAtendido = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.cbSocial = new System.Windows.Forms.ComboBox();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidoMedico = new System.Windows.Forms.TextBox();
            this.txtnombreMedico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(453, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar paciente y asignar medico";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(744, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "obra social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "enfermedad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "atendido (si/no):";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(149, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(113, 29);
            this.txtDni.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 29);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(149, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 29);
            this.txtApellido.TabIndex = 11;
            // 
            // txtAtendido
            // 
            this.txtAtendido.Location = new System.Drawing.Point(169, 257);
            this.txtAtendido.Name = "txtAtendido";
            this.txtAtendido.Size = new System.Drawing.Size(113, 29);
            this.txtAtendido.TabIndex = 12;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(168, 226);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(113, 29);
            this.txtEnfermedad.TabIndex = 13;
            // 
            // cbSocial
            // 
            this.cbSocial.FormattingEnabled = true;
            this.cbSocial.Items.AddRange(new object[] {
            "no tiene",
            "cobertura completa",
            "cobertura media"});
            this.cbSocial.Location = new System.Drawing.Point(153, 152);
            this.cbSocial.Name = "cbSocial";
            this.cbSocial.Size = new System.Drawing.Size(170, 29);
            this.cbSocial.TabIndex = 15;
            // 
            // gridPaciente
            // 
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.edad,
            this.obraSocial,
            this.enfermedad,
            this.atendido,
            this.ApellidoMedico});
            this.gridPaciente.Location = new System.Drawing.Point(329, 67);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.RowHeadersWidth = 51;
            this.gridPaciente.RowTemplate.Height = 31;
            this.gridPaciente.Size = new System.Drawing.Size(854, 252);
            this.gridPaciente.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "dni";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // edad
            // 
            this.edad.HeaderText = "edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.Width = 125;
            // 
            // obraSocial
            // 
            this.obraSocial.HeaderText = "obra social";
            this.obraSocial.MinimumWidth = 6;
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.Width = 125;
            // 
            // enfermedad
            // 
            this.enfermedad.HeaderText = "enfermedad";
            this.enfermedad.MinimumWidth = 6;
            this.enfermedad.Name = "enfermedad";
            this.enfermedad.Width = 125;
            // 
            // atendido
            // 
            this.atendido.HeaderText = "atendido";
            this.atendido.MinimumWidth = 6;
            this.atendido.Name = "atendido";
            this.atendido.Width = 125;
            // 
            // ApellidoMedico
            // 
            this.ApellidoMedico.HeaderText = "Apellido Del Medico";
            this.ApellidoMedico.MinimumWidth = 6;
            this.ApellidoMedico.Name = "ApellidoMedico";
            this.ApellidoMedico.Width = 125;
            // 
            // dni
            // 
            this.dni.HeaderText = "dni";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Datos de paciente";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(168, 191);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(113, 29);
            this.txtEdad.TabIndex = 20;
            this.txtEdad.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(51, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "edad: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Asignar Medico a paciente";
            // 
            // txtApellidoMedico
            // 
            this.txtApellidoMedico.Location = new System.Drawing.Point(148, 425);
            this.txtApellidoMedico.Name = "txtApellidoMedico";
            this.txtApellidoMedico.Size = new System.Drawing.Size(113, 29);
            this.txtApellidoMedico.TabIndex = 27;
            // 
            // txtnombreMedico
            // 
            this.txtnombreMedico.Location = new System.Drawing.Point(148, 390);
            this.txtnombreMedico.Name = "txtnombreMedico";
            this.txtnombreMedico.Size = new System.Drawing.Size(113, 29);
            this.txtnombreMedico.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "apellido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(35, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nombre :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(35, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "especialidad:";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Alergología",
            "Anestesiología y reanimación",
            "Aparato digestivo",
            "Cardiología",
            "Endocrinología y nutrición",
            "Geriatría",
            "Hematología y hemoterapia",
            "Medicina de la educación física y del deporte"});
            this.cbEspecialidad.Location = new System.Drawing.Point(155, 349);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(278, 29);
            this.cbEspecialidad.TabIndex = 28;
            // 
            // MenuMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1190, 559);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.txtApellidoMedico);
            this.Controls.Add(this.txtnombreMedico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridPaciente);
            this.Controls.Add(this.cbSocial);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtAtendido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "MenuMedicos";
            this.Text = "Medico";
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtAtendido;
        private TextBox txtEnfermedad;
        private ComboBox cbSocial;
        private DataGridView gridPaciente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private Label label7;
        private TextBox txtEdad;
        private Label label8;
        private Label label9;
        private TextBox txtApellidoMedico;
        private TextBox txtnombreMedico;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cbEspecialidad;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn obraSocial;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn atendido;
        private DataGridViewTextBoxColumn ApellidoMedico;
    }
}