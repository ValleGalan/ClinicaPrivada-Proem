using BibliotecaDeClases;
namespace FrmFormulario
{
    public partial class MenuMedicos : Form
    {
       // Hospital nuevo = new Hospital();
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
            //HAGO LA PRECARGA
            Paciente mypaciente1 = new Paciente("P1", "Lopez", (int)40821912, (int)23, "No tiene", "Gripe", false);
            Paciente mypaciente2 = new Paciente("P2", "Cruz", (int)19304293, (int)57, "Cobertura Completa", "Angina", false);
            Paciente mypaciente3 = new Paciente("P3", "Caspa", (int)18304923, (int)60, "No tiene", "Fiebre", false);
            Paciente mypaciente4 = new Paciente("P4", "Flores", (int)36405293, (int)26, "Cobertura Simple", "Gripe", false);
            gridPaciente.Rows.Add("P1", "Lopez", (int)40821912, (int)23, "No tiene", "Gripe", false);
            gridPaciente.Rows.Add("P2", "Cruz", (int)19304293, (int)57, "Cobertura Completa", "Angina", false);
            gridPaciente.Rows.Add("P3", "Caspa", (int)18304923, (int)60, "No tiene", "Fiebre", false);
            gridPaciente.Rows.Add("P4", "Flores", (int)36405293, (int)26, "Cobertura Simple", "Gripe", false);
            
            gridPaciente.Columns[4].Width = 170;// cambiar el tamaño
            gridPaciente.Columns[3].Width = 50;
             
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {         
           //ingresado por el medico
           string nombre = txtNombre.Text;
           string apellido = txtApellido.Text;
           int  dni = Convert.ToInt16(txtDni.Text);
           int edad = Convert.ToInt16(txtEdad.Text);
           string ObraSocial = cmbObraSocial.Text;
           string Enfermedad = txtEnfermedad.Text;
            bool EstadoPaciente;
            if (txtEstado.Text=="si"){
                 EstadoPaciente = true;
            }
            else {
                EstadoPaciente = false;
            }

           Paciente paciente = new Paciente(nombre,apellido,dni,edad,ObraSocial,Enfermedad,EstadoPaciente);
           paciente.setNombre(nombre);
            paciente.setApellido(apellido);
            paciente.setDni(dni); 
            paciente.setEdad(edad);
            paciente.setObraSocial(ObraSocial);
            paciente.setEnfermedad(Enfermedad);
            paciente.setEstadoPaciente(EstadoPaciente); 

            gridPaciente.Rows.Add(nombre, apellido, dni, edad, ObraSocial, Enfermedad, EstadoPaciente);
             
            MessageBox.Show("Guardado Correctamente");
            
           // host1.listaDeCola.Add(paciente);
            //host1.CrearPaciente("P1", "Lopez", (int)40821912, (int)23, "No tiene", "Gripe", false);
            //gridMedico.DataSource = mypaciente1;
           
            //Row.Cells["dataGridViewTextBoxColumn1"].Value = txtNombre.Text;
            
            //host1.Add(paciente);
            //limpio la grilla
            //gridMedico.DataSource = null;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDni.Text = " ";
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtEdad.Text=" ";
            txtEnfermedad.Text=" ";
            txtEstado.Text = " ";
        }
    }
}