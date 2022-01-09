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
            // 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
        }
    }
}
