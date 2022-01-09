using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Persona // Clase Padre
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        
        //Metodo abstracto
        public abstract void Hablar();
        //Metodo virtual 
        public virtual string EstaHabilitado()
        {
            return "Esta Habilitado";
        }

        //metodos get y set de los atributos
        //nombre
        public string getNombre() { return nombre; }
        public void setNombre(string nombre){
            this.nombre = nombre;
        }
        //apellido
        public string getApellido() { return apellido; }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }


        //constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}