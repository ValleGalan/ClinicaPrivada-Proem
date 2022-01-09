using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Hospital
    {
        public List<Paciente> listaDeCola;
        public List<Medico> listaDeMedico;
        public List<Consulta> listaDeConsulta;
      //  private Historial historial;
          
        public Hospital(List<Paciente> listaDeCola, List<Medico> listaDeMedico, List<Consulta> listaDeConsulta)//, Historial historial
        {
            this.listaDeCola = listaDeCola;
            this.listaDeMedico = listaDeMedico;
            this.listaDeConsulta = listaDeConsulta;
          //  this.historial = historial;
        }
        // <sumary> ALTA paciente <sumary>
        //public void AltaPaciente(string nombre, string apellido, int dni, int edad, string obraSocial,string Enfermedad ,bool estadopaciente)  { 
        //        Paciente paciente = new(nombre, apellido, dni,edad, obraSocial,Enfermedad,false); //inicializo
        //        if (listaDeCola.Contains(paciente)) {
        //            throw new Exception("ERROR: dni ...");
        //        } else {
        //            listaDeCola.Add(paciente);
        //        }          
        //}
        public void CrearPaciente(string nombre, string apellido, int dni, int edad, string obraSocial, string Enfermedad, bool estadopaciente)
        {
            try
            {
                Paciente paciente = new(nombre, apellido, dni, edad, obraSocial, Enfermedad, false);
                //AltaPaciente(paciente);
                //listaDeCola.Add(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public void AltaPaciente(Paciente paciente)
        //{
        //    if (listaDeCola.Contains(paciente))
        //    {
        //        throw new Exception("ERROR: dni ...");
        //    }
        //    else
        //    {
        //        listaDeCola.Add(paciente);
        //    }
        //}





    }
}
