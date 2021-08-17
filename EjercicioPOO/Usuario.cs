using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Usuario : Persona
    {
        private Cuenta cuenta;
        private String tipo;
        private int id;

        public Usuario(int id,Double dinero, String nombre, String sexo, int edad) : base(nombre, sexo, edad)
        {
            this.id = id;
            cuenta = new Cuenta(dinero);
            DefinirTipo(dinero);
        }

        public override String Imprimir()
        {
            return (base.Imprimir() + " Id: " + this.id+ " Tipo de Cuenta: " + this.tipo + "\n"+ cuenta.Imprimir());
        }

        public Cuenta GetCuenta()
        {
            return this.cuenta;
        }

        public int GetId()
        {
            return this.id;
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public void DefinirTipo(Double dinero)
        {
            if (dinero <= 100)
            {
                this.tipo = "normal";
            }
            else if((dinero >= 101) && (dinero <= 500))
            {
                this.tipo = "ricachón";
            }
            else if ((dinero >= 501) && (dinero <= 200))
            {
                this.tipo = "big baller";
            }
        }


    }
}
