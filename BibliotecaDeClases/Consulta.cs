using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public  class Consulta
    {
        public List<Paciente> listaDeCola;
        public List<Medico> listaDeMedico;
        public List<Consulta> listaDeConsulta;

        public Consulta(List<Paciente> listaDeCola, List<Medico> listaDeMedico, List<Consulta> listaDeConsulta)//, Historial historial
        {
            this.listaDeCola = listaDeCola;
            this.listaDeMedico = listaDeMedico;
            this.listaDeConsulta = listaDeConsulta;
            //  this.historial = historial;
        }


    }
}
