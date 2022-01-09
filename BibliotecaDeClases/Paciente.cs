﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Paciente : Persona
    {   /// <summary> Paciente hereda de persona </summary>
        private int dni { get; set; }
        private int edad { get; set; }
        private string obraSocial { get; set; }
        private string enfermedad { get; set; }
        private bool estadoPaciente { get; set; } //si esta activo o no

       
        //constructor lleno
        public Paciente(string nombre, string apellido, int dni, int edad, string obraSocial, string enfermedad, bool estadoPaciente) : base(nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.obraSocial = obraSocial;
            this.enfermedad = enfermedad;
            this.estadoPaciente = estadoPaciente;
        }

        /// <summary> Metodo que sobreescribe  </summary>
        public override string EstaHabilitado()
        {
            return base.EstaHabilitado() + " SI";
        }
        //<summary> No se implementa, metodo sobre escrito</summary>
        public override void Hablar()
        {
            throw new NotImplementedException();
        }
        //metodos get y set
        //dni
        public int getDni() { return dni; }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        //edad
        public int getEdad() { return edad; }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        //obraSocial
        public string getObraSocial() { return obraSocial; }
        public void setObraSocial(string obraSocial)
        {
            this.obraSocial = obraSocial;
        }
        //enfermedad
        public string getEnfermedad() { return enfermedad; }
        public void setEnfermedad(string enfermedad)
        {
            this.enfermedad = enfermedad;
        }

        //estadoPaciente
        public bool getEstadoPaciente() { return estadoPaciente; }
        public void setEstadoPaciente(bool estadoPaciente)
        {
            this.estadoPaciente = estadoPaciente;
        }
    }
}
