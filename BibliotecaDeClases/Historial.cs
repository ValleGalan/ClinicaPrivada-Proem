using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public  class Historial
    {
        private List<Medico> ListHistorial;

        public Historial(List<Medico> listHistorial)
        {
            ListHistorial = listHistorial;
        }
        public void SetEdad(List<Medico> edad)
        {
            this.ListHistorial = ListHistorial;
        }

    }
}
