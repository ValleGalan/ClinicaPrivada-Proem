using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace FrmFormulario
{
    public partial class MenuMedicos : Form
    {
        public MenuMedicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomMedico = txtnombreMedico.Text;
            string apeMedico = txtApellidoMedico.Text;
            if (apeMedico == "" && nomMedico=="")
            {
                MessageBox.Show("NO se puede cargar y finalizar, tiene que asignar un medico");
            }
            else
            {
                //guardar en grilla
                int n = gridPaciente.Rows.Add();//agrego fila en n
                gridPaciente.Rows[n].Cells[0].Value = txtDni.Text;
                gridPaciente.Rows[n].Cells[1].Value = txtNombre.Text;
                gridPaciente.Rows[n].Cells[2].Value = txtApellido.Text;
                gridPaciente.Rows[n].Cells[3].Value = txtEdad.Text;
                gridPaciente.Rows[n].Cells[4].Value = cbSocial.Text;
                gridPaciente.Rows[n].Cells[5].Value = txtEnfermedad.Text;
                gridPaciente.Rows[n].Cells[6].Value = txtAtendido.Text;
                gridPaciente.Rows[n].Cells[7].Value = txtApellidoMedico.Text;
            }
            //limpio las celdas
            txtDni.Text=" ";
            txtNombre.Text=" ";
            txtApellido.Text=" ";
            cbSocial.Text=" ";
            txtEnfermedad.Text=" ";
            txtAtendido.Text=" ";
            txtApellidoMedico.Text= "";
            txtnombreMedico.Text = "";
            cbEspecialidad.Text = " ";
            //para guardar en la clase

            // int dni = Convert.ToInt16(txtDni.Text);
            string nombre= txtNombre.Text; 
            string apellido = txtApellido.Text;
            string obraSocial= cbSocial.Text;
            string enfermedad = txtEnfermedad.Text;
           // bool atendido = txtAtendido.Text;
            Paciente paciente = new Paciente(nombre, apellido, 6, obraSocial, enfermedad, "true");
            
            paciente.setNombre(nombre);
            paciente.setApellido(apellido);
            paciente.setDni(8);
            paciente.setObraSocial(obraSocial);
            paciente.setEnfermedad(enfermedad);
            paciente.setEstadoPaciente(true);
 
        }

         
    }
}
