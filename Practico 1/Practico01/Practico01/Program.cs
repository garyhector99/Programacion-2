using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parlamento parlamento = new Parlamento();
            List<Legislador> legisladores = new List<Legislador>();
            Senador legislador1 = new Senador("Pablo", "Fernandez", 25, "Si", "Blanco", "Maldonado", 12);
            Diputado legislador2 = new Diputado("Juan", "Perez", 64, "No", "Blanco", "San Jose", 62);
            Diputado legislador3 = new Diputado("Maria", "Suarez", 47, "Si", "Blanco", "Canelones", 76);
            Senador legislador4 = new Senador("Pedro", "Sanchez", 65, "No", "Blanco", "Artigas", 23);
            Senador legislador5 = new Senador("Nicolas", "Rodriguez", 53, "Si", "Blanco", "Salto", 27);
            parlamento.registrarLegislador(legislador1);
            parlamento.registrarLegislador(legislador2);
            parlamento.registrarLegislador(legislador3);
            parlamento.registrarLegislador(legislador4);
            parlamento.registrarLegislador(legislador5);
         



            string continuar = "si";
            while (continuar == "si")
            {
                Console.Clear();
                Console.WriteLine("INGRESE OPCION");
                Console.WriteLine("");
                Console.WriteLine("     1 - MOSTRAR LEGISLADORES");
                Console.WriteLine("     2 - REGISTRAR LEGISLADOR");
                Console.WriteLine("     3 - MOSTRAR CAMARA ALTA");
                Console.WriteLine("     4 - MOSTRAR CAMARA BAJA");
                Console.WriteLine("     5 - PRESENTAR PROPUESTA");
                Console.WriteLine("     6 - VOTAR");
                Console.WriteLine("     7 - PARTICIPAR EN DEBATE");
                Console.WriteLine("     8 - SALIR");

                string opcion = Console.ReadLine();
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "7" && opcion != "8")
                {
                    Console.WriteLine("INGRESE UNA OPCION VALIDA");
                    opcion = Console.ReadLine();
                }
                int.TryParse(opcion, out int numero);

                switch (numero)
                {
                    case 1:
                        Console.Clear();
                        parlamento.mostrarLegisladores();
                        parlamento.cantidadLegisladores();
                        Console.ReadKey();
                        break;
                    case 2:
                        string nuevolegislador = "1";
                        while (nuevolegislador == "1")
                        {
                            string casado = "No";
                            
                            Console.Clear();
                            Console.WriteLine("REGISTRO DE LEGISLADORES");

                            Console.WriteLine("NOMBRE :");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("APELLIDO :");
                            string apellido = Console.ReadLine();
                            int edad;
                            Console.WriteLine("EDAD :");
                            while (true)
                            {
                                string edadIng = Console.ReadLine();
                                if (int.TryParse(edadIng, out edad) && edad > 18 && edad < 100)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("INGRESAR UNA EDAD VALIDA");
                                }
                            }
                            Console.WriteLine("CASADO : OPCION 1 - SI");
                            Console.WriteLine("         OPCION 2 - NO");
                            string estadocivil = Console.ReadLine();
                            if(estadocivil == "1")
                            {
                                casado = "Si";
                            }
                            Console.WriteLine("PARTIDO :");
                            string partido = Console.ReadLine();
                            Console.WriteLine("DEPARTAMENTO :");
                            string departamento = Console.ReadLine();
                            Console.WriteLine("DESPACHO :");
                            int despacho;
                            while (true)
                            {
                                string despachoIng = Console.ReadLine();
                                if (int.TryParse(despachoIng, out despacho) && despacho >= 1 && despacho <= 100)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("INGRESAR UN DESPACHO VALIDO");
                                }
                            }
                            if (despacho <= 50)
                            {
                                Senador legislador = new Senador(nombre, apellido, edad, casado, partido, departamento, despacho);
                                parlamento.registrarLegislador(legislador);
                            }
                            else
                            {
                                Diputado legislador = new Diputado(nombre, apellido, edad, casado, partido, departamento, despacho);
                                parlamento.registrarLegislador(legislador);
                            }

                            Console.WriteLine("SI DESEA REGISTRAR OTRO LEGISLADOR INGRESE 1");
                            nuevolegislador = Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        parlamento.listarCamaraAlta();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        parlamento.listarCamaraBaja();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        parlamento.mostrarLegisladores();
                        Console.WriteLine("INGRESA EL NUMERO DE DESPACHO DEL LEGISLADOR:");
                        if (int.TryParse(Console.ReadLine(), out int numeroIng))
                        {
                            bool existe = false;
                            foreach (Legislador legislador in parlamento.Legisladores)
                            {
                                if (legislador.despacho == numeroIng)
                                {
                                    legislador.presentarPropuesta(numeroIng);
                                    existe = true;  
                                    break;
                                }
                            }
                            if(existe == false)
                            {
                                Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                            }
                        }
                        else
                        {
                            Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                        }
                        Console.ReadKey();
                        break; ;
                    case 6:
                        Console.Clear();
                        parlamento.mostrarLegisladores();
                        Console.WriteLine("INGRESA EL NUMERO DE DESPACHO DEL LEGISLADOR:");
                        if (int.TryParse(Console.ReadLine(), out int numeroIng2))
                        {
                            bool existe = false;
                            foreach (Legislador legislador in parlamento.Legisladores)
                            {
                                if (legislador.despacho == numeroIng2)
                                {
                                    legislador.votar(numeroIng2);
                                    existe = true;
                                    break;
                                }
                            }
                            if (existe == false)
                            {
                                Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                            }
                        }
                        else
                        {
                            Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                        }
                        Console.ReadKey();
                        break; ;
                    case 7:
                        Console.Clear();
                        parlamento.mostrarLegisladores();
                        Console.WriteLine("INGRESA EL NUMERO DE DESPACHO DEL LEGISLADOR:");
                        if (int.TryParse(Console.ReadLine(), out int numeroIng3))
                        {
                            bool existe = false;
                            foreach (Legislador legislador in parlamento.Legisladores)
                            {
                                if (legislador.despacho == numeroIng3)
                                {
                                    legislador.participarDebate(numeroIng3);
                                    existe = true;
                                    break;
                                }
                            }
                            if (existe == false)
                            {
                                Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                            }
                        }
                        else
                        {
                            Console.WriteLine("NUMERO DE DESPACHO INVALIDO");
                        }
                        Console.ReadKey();
                        break; ;
                    case 8:
                        Console.Clear();
                        continuar = "no";
                        Console.WriteLine("Gracias por usar el programa");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
