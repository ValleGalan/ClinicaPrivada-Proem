using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
namespace FrmFormulario
{
    public partial class MenuPacientes : Form
    {
        public MenuPacientes()
        {
            InitializeComponent();
           
        }

        private void MenuPacientes_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paciente paciente1 = new  Paciente("juana","Clara",23234234,"no tiene","Cardialogia","true");
            lbLista.Items.Add(paciente1.mostrarActivos(true,"Juana","Flores",34343434));
            lbLista.Items.Add(paciente1.mostrarActivos(false, "Oscar", "Gaspar", 25343423));
            lbLista.Items.Add(paciente1.mostrarActivos(true, "Pepe", "Perez", 98432187));
            lbLista.Items.Add(paciente1.mostrarActivos(false, "Lucas", "Lopez", 23453234));
            // 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico medico1 = new Medico("juana", "Clara", "Cardialogia",0, "true");
            lbLista.Items.Add(medico1.mostrarActivosMedicos("true","Luis", "Gonzalez", "Cardialogia"));
            lbLista.Items.Add(medico1.mostrarActivosMedicos("true","Carlos", "Ruiz", "Traumatologa"));
            lbLista.Items.Add(medico1.mostrarActivosMedicos("false","Josefa", "Cruz", "Dentista" ));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Paciente pacienten = new Paciente("juana", "Clara", 23234234, "no tiene", "Cardialogia", "true");
            lbLista.Items.Add(pacienten.mostrarCola(false, "Juana", "Flores", 34343434));
            lbLista.Items.Add(pacienten.mostrarCola(false, "Lucas", "Lopez", 23453234));
        }
    }
}
