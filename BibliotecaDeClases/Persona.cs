using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Persona // Clase Padre
    {
        public string Nombre;
        public string Apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        //Metodo abstracto
        public abstract void Hablar();
        //Metodo virtual 
        public virtual string EstaHabilitado()
        {
            return "Esta Habilitado";
        }

        public string GetApellido() { return Apellido; }
        public string GetNombre() { return Nombre; }
       
    }
}