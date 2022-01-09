using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public  class Consulta
    {  
        private Paciente Paciente;
        private Medico Medico;
        private string Atiende;

        public Consulta(Paciente paciente, Medico medico, string atiende)
        {
            Paciente = paciente;
            Medico = medico;
            Atiende = atiende;
        } 


    }
}
