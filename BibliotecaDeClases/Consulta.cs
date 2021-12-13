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
        //Metodo para ver si el Medico atiende al paciente o el paciente tiene por medico a X
        public override bool Equals(object obj)
        {
            return obj is Consulta consulta && EqualityComparer<Paciente>.Default.Equals(Paciente, consulta.Paciente) && EqualityComparer<Medico>.Default.Equals(Medico, consulta.Medico);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Paciente, Medico);
        }


    }
}
