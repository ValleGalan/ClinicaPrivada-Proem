using BibliotecaDeClases;
namespace FrmFormulario
{
    public partial class MenuMedicos : Form
    {
        Hospital nuevo = new Hospital();
        //Paciente paciente = new Paciente(txtNombre.Text, txtApellido.Text);
        private void btnSalir_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void MenuMedico_Load(object sender, EventArgs e){
            InitializeComponent();
        }
        public MenuMedicos()
        {
            InitializeComponent();
            //Hospital hospital = new();
            //Paciente paciente1 = new Paciente(txtNombre.Text, txtApellido.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(txtNombre.Text, txtApellido.Text);
            txtDni.Text= "0";
            txtEdad.Text = "0";
            txtEstado.Text = "false";
            //<sumary> Instanciamos <sumary>
            //aciente.Nombre = txtNombre.Text;
            //aciente.Apellido = txtApellido.Text;
            paciente.Dni = Convert.ToInt16(txtDni.Text);
            paciente.Edad = Convert.ToInt16(txtEdad.Text);
            paciente.ObraSocial = cmbObraSocial.Text;
            paciente.Enfermedad = txtEnfermedad.Text;
            paciente.EstadoPaciente = Convert.ToBoolean(txtEstado.Text);
            MessageBox.Show("Guardado Correctamente");
            //Paciente mypaciente1 = new Paciente("P1", "Lopez", (int)40821912, (int)23, "No tiene", "Gripe", false);
            //Paciente mypaciente2 = new Paciente("P2", "Cruz", (int)19304293, (int)57, "Cobertura Completa", "Angina", false);
            //Paciente mypaciente3 = new Paciente("P3", "Caspa",(int) 18304923,(int) 60, "No tiene", "Fiebre", false);
            //Paciente mypaciente4 = new Paciente("P4", "Flores", (int)36405293, (int)26, "Cobertura Simple", "Gripe", false);
            // host1.listaDeCola.Add(mypaciente1);
            //host1.CrearPaciente("P1", "Lopez", (int)40821912, (int)23, "No tiene", "Gripe", false);
            //gridMedico.DataSource = mypaciente1;


            // host1.CrearPaciente("P9", "Lopez", 40821912, 23, "No tiene", "Gripe", false);
            // host1.CrearPaciente("P5", "Lopez", 40821912, 23, "No tiene", "Gripe", false);
           

            //txtDni.Text= "0";
            //txtEdad.Text = "0";
            //txtEstado.Text = "false";
            //int d = Convert.ToInt16(txtDni.Text);
            //int edad = Convert.ToInt32(txtEdad.Text);
            //bool estado = Convert.ToBoolean(txtEstado.Text);


            //host1.CrearPaciente(txtNombre.Text, txtApellido.Text, d, edad, cmbObraSocial.Text, txtEnfermedad.Text, estado);
           
            //Row.Cells["dataGridViewTextBoxColumn1"].Value = txtNombre.Text;
            
            //host1.Add(paciente);
            //limpio la grilla
            //gridMedico.DataSource = null;
           
            // mypaciente.Nombre = txtNombre.Text;
            // mypaciente.Apellido = txtApellido.Text;


        }

        

      
    }
}