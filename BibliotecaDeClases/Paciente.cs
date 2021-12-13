using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente : Persona
    {   /// <summary> Paciente hereda de persona </summary>
        private  int Dni;
        private int Edad;
        private string ObraSocial;
        private string Enfermedad;
        private bool EstadoPaciente;
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

        


        /// <summary> Metodo que sobreescribe  </summary>
        public override string EstaHabilitado()
        {
            return base.EstaHabilitado() + " SI";
        }

        /// <summary> Validacion de DNI </summary>
        public override bool Equals(object obj)
        {
            return this.Dni == ((Paciente)obj).Dni;
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
        public int GetDni() { return Dni; }
        public int GetEdad() { return Edad; }
        public string GetObraSocial() { return ObraSocial; }
        public string GetEnfermedad() { return Enfermedad; }
        public bool GetEstadoPaciente() { return EstadoPaciente; }


        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                this.Nombre = nombre.Trim();
            }
        }
        public void SetApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public void SetDni(int dni)
        {
            this.Dni = dni;
        }
        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }
        public void SetObraSocial(string obrasocial)
        {
            if (!string.IsNullOrWhiteSpace(obrasocial))
            {
                this.ObraSocial = obrasocial.Trim();
            }
        }
        public void SetEnfermedad(string enfermedad)
        {
            if (!string.IsNullOrWhiteSpace(enfermedad))
            {
                this.Enfermedad = enfermedad.Trim();
            }
        }
        public void SetEstadoPaciente(bool estadopaciente)
        {
            this.EstadoPaciente = estadopaciente;
        }
    }
}
