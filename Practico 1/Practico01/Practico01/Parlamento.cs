using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    internal class Parlamento
    {
        public List<Legislador> Legisladores { get; set; }

        public Parlamento()
        {
            Legisladores = new List<Legislador>();
        }
        public void registrarLegislador(Legislador legislador)
        {
            Legisladores.Add(legislador);
        }
        public void listarCamaraAlta()
        {
            Console.WriteLine("Camara de Senadores : ");
            foreach (var legislador in Legisladores)
            {
                if(legislador.getCamara() == "Senado")
                {
                    Console.WriteLine(legislador.nombre + " " + legislador.apellido + " - Numero de Despacho : " + legislador.despacho + " - Cámara: Alta");
                }
            }
        }
        public void listarCamaraBaja()
        {
            Console.WriteLine("Camara de Diputados : ");
            foreach (var legislador in Legisladores)
            {
                if (legislador.getCamara() == "Diputados")
                {
                    Console.WriteLine(legislador.nombre + " " + legislador.apellido + " - Numero de Despacho : "+ legislador.despacho +" - Cámara: Baja");
                }
            }
        }
        public void mostrarLegisladores()
        {
            foreach (var legislador in Legisladores)
            {
                Console.WriteLine("Nombre : " + legislador.nombre + " " + legislador.apellido);
                Console.WriteLine("Edad : " + legislador.edad + " - Casado : " + legislador.casado);
                Console.WriteLine("Partido : " + legislador.partido + " - Despacho : " + legislador.despacho);
                Console.WriteLine();
            }
        }
        public void cantidadLegisladores()
        {
            int senadores = 0;
            int diputados = 0;

            foreach (var Legislador in Legisladores)
            {
                if (Legislador.getCamara() == "Senado")
                {
                    senadores++;
                }
                else if (Legislador.getCamara() == "Diputados")
                {
                    diputados++;
                }
            }

            Console.WriteLine("Cantidad de Senadores : " + senadores);
            Console.WriteLine(("Cantidad de Diputados : " + diputados));
        }
    }
}
 

