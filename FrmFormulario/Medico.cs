﻿using BibliotecaDeClases;
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
            //guardar en grilla
            int n = gridPaciente.Rows.Add();//agrego fila en n
            gridPaciente.Rows[n].Cells[0].Value = txtDni.Text;
            gridPaciente.Rows[n].Cells[1].Value = txtNombre.Text;
            gridPaciente.Rows[n].Cells[2].Value = txtApellido.Text;
            gridPaciente.Rows[n].Cells[3].Value = cbSocial.Text;
            gridPaciente.Rows[n].Cells[4].Value = txtEnfermedad.Text;
            gridPaciente.Rows[n].Cells[5].Value = txtAtendido.Text;
            //limpio las celdas
            txtDni.Text=" ";
            txtNombre.Text=" ";
            txtApellido.Text=" ";
            cbSocial.Text=" ";
            txtEnfermedad.Text=" ";
            txtAtendido.Text=" ";
            //para guardar en la clase

            int dni = Convert.ToInt16(txtDni.Text);
            string nombre= txtNombre.Text; 
            string apellido = txtApellido.Text;
            string obraSocial= cbSocial.Text;
            string enfermedad = txtEnfermedad.Text;
           // bool atendido = txtAtendido.Text;
            Paciente paciente = new Paciente(nombre, apellido, dni, obraSocial, enfermedad, "true");
            
            paciente.setNombre(nombre);
            paciente.setApellido(apellido);
            paciente.setDni(dni);
            paciente.setObraSocial(obraSocial);
            paciente.setEnfermedad(enfermedad);
            paciente.setEstadoPaciente(true);

           // gridPaciente.Rows.Add(nombre, apellido, dni, edad, ObraSocial, Enfermedad, EstadoPaciente);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           string buscarDni= txtBuscar.Text;
            int n = gridPaciente.Rows.Add();//agrego fila en n
           
            for (int i=1; i<=n; i++)
            {
                
                if (buscarDni== gridPaciente.Rows[n].Cells[0].Value) {
                    // txtDni.Text=  gridPaciente.Rows[n].Cells[0].Value ;
                    MessageBox.Show("lo hayo");
                }
            }
        }
    }
}
