using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico : Persona /// <summary> Clase Medico hereda de persona </summary>
    {
        private string matricula { get; set; }
        private string especialidad { get; set; }
        private int cantAtendidos { get; set; } //de pacientes 
        private List<Paciente> colaEspera { get; set; }  /// <summary> Lista de espera personal del medico </summary>
      
        //contructor lleno
        public Medico(string nombre, string apellido, string matricula, string especialidad, int cantAtendidos, List<Paciente> colaEspera) : base(nombre, apellido)
        {
            this.matricula = matricula; 
            this.especialidad = especialidad;
            this.cantAtendidos = 0; //inicializo
            this.colaEspera = new List<Paciente>();
        }
        /// <summary> Metodo contador </summary>        
        public void ContadorPacientesAtendidos()
        {
            cantAtendidos = 0;  
            cantAtendidos = cantAtendidos + 1;
        }
        //metodos get y set de los atributos
        //matricula
        public string getMatricula() { return matricula; }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        //especialidad
        public string getEspecialidad() { return especialidad; }
        public void setEspecialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
        //cantAtendidos
        public int getCantAtendidos() { return cantAtendidos; }
        public void setCantAtendidos(int cantAtendidos)
        {
            this.cantAtendidos = cantAtendidos;
        }





        public override void Hablar()
        {
            throw new NotImplementedException();
        }

    }
}
