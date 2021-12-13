using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Medico : Persona /// <summary> Clase Medico hereda de persona </summary>
    {
        private string Matricula { set; get; }
        private string Especialidad { set; get; }
        private int CantAtendidos { set; get; } //de pacientes 
        private List<Paciente> ColaEspera { set; get; }  /// <summary> Lista de espera personal del medico </summary>

        public Medico(string nombre, string apellido, string especialidad, int CantAtendidos, List<Paciente> ColaEspera) : base(nombre, apellido)
        {
            especialidad = " ";
            CantAtendidos = 0; //inicializo
            ColaEspera = new List<Paciente>();
        }
        public override string EstaHabilitado() {
            return base.EstaHabilitado() + " SI";
        }
               
        public void ContadorPacientesAtendidos()/// <summary> Metodo contador </summary>
        {
            int CantAtendidos = 0; //ver :S
            CantAtendidos = CantAtendidos + 1;
        }
       // public string GetMatricula() { return Matricula; }
       // public string GetEspecialidad() { return Especialidad; }
       /// public int GetPacientesAtendidos() { return CantAtendidos; }
        //public List<Paciente> GetColaEspera() { return ColaEspera; }
       
        /// <summary> Validacion de Medico </summary>
        public override bool Equals(object obj)
        {
            return this.Matricula == ((Medico)obj).Matricula;
        }
        public override int GetHashCode()
        {
            return Matricula.GetHashCode();
        }

        public override void Hablar() //heredo de persona 
        {
            throw new NotImplementedException();
        }
    }
}
