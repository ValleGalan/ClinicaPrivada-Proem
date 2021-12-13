using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente : Persona
    {   /// <summary> Paciente hereda de persona </summary>
        private int dni;
        private int edad;
        private string obraSocial;
        private string enfermedad;
        private bool estadoPaciente;
        

        //contructor vacio

     

        public Paciente(string nombre, string apellido ) : base(nombre, apellido)
        { 
        }
        //constructor 
        public Paciente(string nombre, string apellido, int dni, int edad, string obraSocial, string enfermedad, bool estadoPaciente) : base(nombre, apellido)
        {
            Dni = dni;
            Edad = edad;
            ObraSocial = obraSocial;
            Enfermedad = enfermedad;
            EstadoPaciente = estadoPaciente;
        }

        public int Dni { get; set; }
        public int Edad { get; set; }
        public string ObraSocial { get; set; }
        public string Enfermedad { get; set; }
        public bool EstadoPaciente { get; set; }




        /// <summary> Metodo que sobreescribe  </summary>
        public override string EstaHabilitado()
        {
            return base.EstaHabilitado() + " SI";
        }

        /// <summary> Validacion de DNI </summary>
        public override bool Equals(object obj)
        {
            return this.dni == ((Paciente)obj).dni;
        }
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }
        //<summary> No se implementa, metodo sobre escrito</summary>
        public override void Hablar()
        {
            throw new NotImplementedException();
        }
       
    }
}
