using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    internal class Legislador
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string casado;
        public string partido;
        public string departamento;
        public int despacho;
        public Legislador(string nombre, string apellido, int edad, string casado, string partido, string departamento, int despacho)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
            this.partido = partido;
            this.departamento = departamento;
            this.despacho = despacho;
        }
        public string getCamara()
        {
            if(despacho <= 50)
            {
                return "Senado";
            }
            else
            {
                return "Diputados";
            }
        }
        public virtual void presentarPropuesta(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha presentado una propuesta");
        }
        public virtual void votar(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha votado");
        }
        public virtual void participarDebate(int despacho)
        {
            Console.WriteLine("El legislador " + nombre + " " + apellido + " ha participado en un debate");
        }
    }
}
