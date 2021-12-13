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
    public partial class Menu : Form //menu hereda de formulario
    {
        public Menu()
        {

            InitializeComponent();
            Hospital hospital = new Hospital();
            hospital.CrearPaciente("P9", "Lopez", 40821912, 23, "No tiene", "Gripe", false);
            hospital.CrearPaciente("P5", "Lopez", 40821912, 23, "No tiene", "Gripe", false);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // <sumary>para mostrar el formulario del paciente <sumary>
            Form formulario = new MenuPacientes();
            formulario.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            // <sumary>para mostrar el formulario del medico <sumary>
            Form formulari = new MenuMedicos();
            formulari.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
