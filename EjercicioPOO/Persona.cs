using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Persona
    {
        String nombre;
        String sexo;
        int edad;

        public Persona(String nombre, String sexo, int edad)
        {
            this.Nombre = nombre;
            if (ValidarEdad(edad))
            {
                this.Edad = edad;
            }
            else
            {
                Console.WriteLine("Eres menor de edad, no puedes usar apostar");
                throw new Exception("Eres menor de edad, no puedes usar apostar");
            }
            this.Sexo = sexo;
            
        }

        public virtual String Imprimir()
        {
            return ("Nombre: "+ this.nombre +" Sexo: "+ this.sexo +" Edad: "+ this.edad);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }

        public Boolean ValidarEdad(int edad)
        {
            return (edad >= 18) ? true : false;
        }
    }
}
