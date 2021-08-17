using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario us = new Usuario( 001 ,5000, "Daniel", "M", 21);
            usuarios.Add(us);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n\t\t\t █████████████████████████████████████████████████████████████████████" +
                              "\n\t\t\t █▄─▄─▀█▄─▄█▄─▄▄─█▄─▀█▄─▄█▄─█─▄█▄─▄▄─█▄─▀█▄─▄█▄─▄█▄─▄▄▀█─▄▄─██████▀▄─██" +
                              "\n\t\t\t ██─▄─▀██─███─▄█▀██─█▄▀─███▄▀▄███─▄█▀██─█▄▀─███─███─██─█─██─██████─▀─██" +
                              "\n\t\t\t ▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▀▀▀▄▄▀▄▄▀");

            Console.WriteLine("");

            Console.WriteLine("\t\t\t░█████╗░░█████╗░████████╗                    ░█████╗░░█████╗░████████╗ ");
            Console.WriteLine("\t\t\t ██╔══██╗██╔══██╗╚══██╔══╝                    ██╔══██╗██╔══██╗╚══██╔══╝");
            Console.WriteLine("\t\t\t ██║░░╚═╝███████║░░░██║░░░                    ██║░░╚═╝███████║░░░██║░░░");
            Console.WriteLine("\t\t\t ██║░░██╗██╔══██║░░░██║░░░                    ██║░░██╗██╔══██║░░░██║░░░");
            Console.WriteLine("\t\t\t ╚█████╔╝██║░░██║░░░██║░░░                    ╚█████╔╝██║░░██║░░░██║░░░");
            Console.WriteLine("\t\t\t ░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░                    ░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░");
            Console.WriteLine("\t\t\t                                                                       ");
            Console.WriteLine("\t\t\t ██████╗░░█████╗░░█████╗░███████╗██████╗░     ██████╗░░█████╗░░█████╗░███████╗██████╗░");
            Console.WriteLine("\t\t\t ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗     ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("\t\t\t ██████╔╝███████║██║░░╚═╝█████╗░░██████╔╝     ██████╔╝███████║██║░░╚═╝█████╗░░██████╔╝");
            Console.WriteLine("\t\t\t ██╔══██╗██╔══██║██║░░██╗██╔══╝░░██╔══██╗     ██╔══██╗██╔══██║██║░░██╗██╔══╝░░██╔══██╗");
            Console.WriteLine("\t\t\t ██║░░██║██║░░██║╚█████╔╝███████╗██║░░██║     ██║░░██║██║░░██║╚█████╔╝███████╗██║░░██║");
            Console.WriteLine("\t\t\t ╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝     ╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝");

            Console.WriteLine("\n\t\t\t   ▒█▀▀█ █▀▀█ ▀▀█▀▀" + "\t   ▒█▀▀█ █▀▀█ ▀▀█▀▀" + "\t   ▒█▀▀█ █▀▀█ ▀▀█▀▀" +
                              "\n\t\t\t   ▒█░░░ █▄▄█ ░░█░░" + "\t   ▒█░░░ █▄▄█ ░░█░░" + "\t   ▒█░░░ █▄▄█ ░░█░░" +
                              "\n\t\t\t   ▒█▄▄█ ▀░░▀ ░░▀░░" + "\t   ▒█▄▄█ ▀░░▀ ░░▀░░" + "\t   ▒█▄▄█ ▀░░▀ ░░▀░░" +
                              "\n\t\t\t                                                                            " +
                              "\n\t\t\t ▒█▀▀█ ░█▀▀█ ▒█▀▀█ ▒█▀▀▀ ▒█▀▀█" +
                              "\n\t\t\t ▒█▄▄▀ ▒█▄▄█ ▒█░░░ ▒█▀▀▀ ▒█▄▄▀" +
                              "\n\t\t\t ▒█░▒█ ▒█░▒█ ▒█▄▄█ ▒█▄▄▄ ▒█░▒█");

            Console.WriteLine("\n\t\t\t\t\t████████████████████████████████████████████████" +
                              "\n\t\t\t\t\t███   Presiona cualquier tecla para empezar  ███" +
                              "\n\t\t\t\t\t████████████████████████████████████████████████");

                    
            String n = Console.ReadLine();

            Usuario UsuarioJugador = null;
            while (true)
            {
                Console.Clear();

                PrintLogo();

                Console.WriteLine("1. Ingresar.");
                Console.WriteLine("2. Crear cuenta.");
                Console.Write("Ingrese su opción (1 o 2): "); int resp1 = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                PrintLogo();

                if (resp1 == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Introduzca su ID: "); int id = Convert.ToInt16(Console.ReadLine());
                        foreach (Usuario item in usuarios)
                        {
                            if (id == item.GetId())
                            {
                                Console.Clear();
                                PrintLogo();
                                Console.WriteLine("Login exitoso");
                                UsuarioJugador = item;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Id no encontrado, revise sus datos");
                            }
                        }
                        
                        break;
                    }
                }
                else if (resp1 == 2)
                {
                    int id = 999;
                    int res = 0;
                    while (res == 0)
                    {
                        Console.WriteLine("Introduzca un id de 3 dígitos: ");  id = Convert.ToInt16(Console.ReadLine());
                        foreach (Usuario item in usuarios)
                        {
                            if (id == item.GetId())
                            {
                                Console.WriteLine("Id ya registrado, escoga otro");
                            }
                            else
                            {
                                res = 1;
                            }
                        }
                        
                    }                                        
                    Console.WriteLine("Introduzca la cantidad de dinero que invertirá: "); Double dinero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca su nombre: "); String nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca su sexo: "); String sexo = Console.ReadLine();
                    Console.WriteLine("Introduzca su edad: "); int edad = Convert.ToInt16(Console.ReadLine());
                    Usuario usu = new Usuario(id, dinero, nombre, sexo, edad);
                    usuarios.Add(usu);
                    UsuarioJugador = usu;

                    Console.WriteLine("Confime sus datos:");
                    Console.WriteLine(usu.Imprimir());
                    Console.WriteLine("Presione cualquier tecla para continuar.."); String tipe = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Introduzca una entrada válida");
                }

                break;
            }

            Console.Clear();
            PrintLogo();
            Juego juego = new Juego();

            String resp2 = "Y";
            while ((resp2 == "Y") || (resp2 == "y"))
            {
                Double dinero2 = 0;
                while (true)
                {
                    Console.Clear();
                    PrintLogo();
                    Console.WriteLine("\nIntroduzca la cantidad de dinero que desea apostar: "); dinero2 = Convert.ToDouble(Console.ReadLine());
                    if (dinero2 > UsuarioJugador.GetCuenta().GetDineroTotal())
                    {
                        Console.WriteLine("\nNo tiene el suficiente dinero para apostar");
                    }
                    else
                    {
                        break;
                    }
                }


                Console.Clear();
                PrintLogo();
                juego.Jugar(dinero2, UsuarioJugador.GetCuenta());                

                Console.WriteLine("\nDesea jugar de nuevo o ver el resumen: [Y/R]");  resp2 = Console.ReadLine();

                if (resp2 == "R")
                {
                    Console.WriteLine(UsuarioJugador.GetCuenta().Imprimir()); 
                    Console.WriteLine("\nDesea jugar de nuevo: [Y/N]"); resp2 = Console.ReadLine();
                }

            }

            void PrintLogo()
            {
                Console.WriteLine("\n\t\t\t   ▒█▀▀█ █▀▀█ ▀▀█▀▀" +
                                  "\n\t\t\t   ▒█░░░ █▄▄█ ░░█░░" +
                                  "\n\t\t\t   ▒█▄▄█ ▀░░▀ ░░▀░░" +
                                  "\n\t\t\t                        " +
                                  "\n\t\t\t ▒█▀▀█ ░█▀▀█ ▒█▀▀█ ▒█▀▀▀ ▒█▀▀█" +
                                  "\n\t\t\t ▒█▄▄▀ ▒█▄▄█ ▒█░░░ ▒█▀▀▀ ▒█▄▄▀" +
                                  "\n\t\t\t ▒█░▒█ ▒█░▒█ ▒█▄▄█ ▒█▄▄▄ ▒█░▒█ \n\n");
            }
        }
        

    }
    
}
