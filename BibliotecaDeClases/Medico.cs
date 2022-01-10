using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico : Persona /// <summary> Clase Medico hereda de persona </summary>
    {
     
        private string especialidad { get; set; }
        private int cantAtendidos { get; set; } //de pacientes 
        private string atendiendo { get; set; }
        // private List<Paciente> colaEspera { get; set; }  /// <summary> Lista de espera personal del medico </summary>

        //contructor lleno
        public Medico(string nombre, string apellido , string especialidad, int cantAtendidos, string atendiendo) : base(nombre, apellido)//, List<Paciente> colaEspera
        { 
            this.especialidad = especialidad;
            this.cantAtendidos = 0; //inicializo
            this.atendiendo = atendiendo;
           // this.colaEspera = new List<Paciente>();
        }
        
        //metodos get y set de los atributos
        
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
        //atentiendo
        public string getAtendiendo() { return atendiendo; }
        public void setAtendiendo(string atendiendo)
        {
            this.atendiendo = atendiendo;
        }
        //funciones
        /// <summary> Metodo contador </summary>        
        public void ContadorPacientesAtendidos()
        {
            cantAtendidos = 0;
            cantAtendidos = cantAtendidos + 1;
        }
        public string mostrarActivosMedicos(string atendiendo, string nombre, string apellido,string especialidad)
        { //metodo
            if (atendiendo == "true")
            {
                return "ACTIVO: "+ "  "+nombre + "   " + apellido + "   " + especialidad;
            }
            else
            {
                return "no esta activo el medico: " + "   " + nombre +"   " + apellido + "   " + especialidad;
            }
            
        }





        public override void Hablar()
        {
            throw new NotImplementedException();
        }

    }
}
