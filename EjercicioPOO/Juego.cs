using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Juego
    {
        private String[] gatos = {"Aldo", "Kitty", "Bola de nieve", "Pelusa", "Patas", "Mr Puffle", "Torisosu", "Gilbert", "Java"};
        
        public String PrintGato(int num)
        {
            switch (num)
            {
                case 0:
                    return           ("\n ▄▀█ █░░ █▀▄ █▀█" +
                                      "\n █▀█ █▄▄ █▄▀ █▄█");
                    
                case 1:
                    return            ("\n████████████████████████████" +
                                       "\n█▄─█─▄█▄─▄█─▄─▄─█─▄─▄─█▄─█─▄█" +
                                       "\n██─▄▀███─████─█████─████▄─▄██" +
                                       "\n▀▄▄▀▄▄▀▄▄▄▀▀▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▀▀");
                    
                case 2:
                    return           ("\n █▄─▄─▀█─▄▄─█▄─▄████▀▄─████▄─▄▄▀█▄─▄▄─███▄─▀█▄─▄█▄─▄█▄─▄▄─█▄─█─▄█▄─▄▄─█" +
                                      "\n ██─▄─▀█─██─██─██▀██─▀─█████─██─██─▄█▀████─█▄▀─███─███─▄█▀██▄▀▄███─▄█▀█" +
                                      "\n ▀▄▄▄▄▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀");
                    
                case 3:
                    return           ("\n █▀▀█ █▀▀ █── █──█ █▀▀ █▀▀█" +
                                      "\n █──█ █▀▀ █── █──█ ▀▀█ █▄▄█" +
                                      "\n █▀▀▀ ▀▀▀ ▀▀▀ ─▀▀▀ ▀▀▀ ▀──▀");
                    
                case 4:
                    return        ("\n█▄─▄▄─██▀▄─██─▄─▄─██▀▄─██─▄▄▄▄█" +
                                   "\n██─▄▄▄██─▀─████─████─▀─██▄▄▄▄─█" +
                                   "\n▀▄▄▄▀▀▀▄▄▀▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀");


                case 5:
                    return          ("\n█▀▄▀█ █▀█   █▀█ █░█ █▀▀ █▀▀ █░░ █▀▀"+
                                     "\n█░▀░█ █▀▄   █▀▀ █▄█ █▀░ █▀░ █▄▄ ██▄");


                case 6:
                    return           ("\n ▀▀█▀▀ █▀▀█ █▀▀█ ─▀─ █▀▀ █▀▀█ █▀▀ █──█ " +
                                      "\n  ░█── █──█ █▄▄▀ ▀█▀ ▀▀█ █──█ ▀▀█ █──█ " +
                                      "\n ─░█── ▀▀▀▀ ▀─▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀ ─▀▀▀");
                    
                case 7:
                    return           ("\n █████▀███████████████████████████████████" +
                                      "\n █─▄▄▄▄█▄─▄█▄─▄███▄─▄─▀█▄─▄▄─█▄─▄▄▀█─▄─▄─█" +
                                      "\n █─██▄─██─███─██▀██─▄─▀██─▄█▀██─▄─▄███─███" +
                                      "\n ▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▀▄▄▄▀▀");
                    
                case 8:
                    return           ("\n ░░▀ █▀▀█ ▀█░█▀ █▀▀█ " +
                                      "\n ░░█ █▄▄█ ░█▄█░ █▄▄█ " +
                                      "\n █▄█ ▀░░▀ ░░▀░░ ▀░░▀");
                    
                default:
                    return "";
            }
        }

        public void Jugar(Double dinero, Cuenta cuenta)
        {
            Random rnd = new Random();           

            Console.WriteLine("\nCon su apuesta puede ganar: $" + (dinero + (dinero / 2)) + " y puede perder: " + dinero);

            int gato1 = rnd.Next(8);
            int gato2 = rnd.Next(8);
            int gato3 = rnd.Next(8);
            int[] num_gatos = { gato1, gato2, gato3 };
            while (true) 
            {
                if ((gato1 == gato2) || (gato1 == gato3) || (gato2 == gato3))
                {
                    gato1 = rnd.Next(8);
                    gato2 = rnd.Next(8);
                    gato3 = rnd.Next(8);                    
                }
                else
                {
                    num_gatos[0] = gato1;
                    num_gatos[1] = gato2;
                    num_gatos[2] = gato3;
                    break;
                }
            }

            Console.WriteLine("\nLos gatitos participantes son: ");
            Console.WriteLine("1. " + PrintGato(gato1));
            Console.WriteLine("2. " + PrintGato(gato2));
            Console.WriteLine("3. " + PrintGato(gato3));
            int resp;
            while (true)
            {
                Console.Write("\nIntroduzca el gato con el que quiere jugar: ");
                resp = Convert.ToInt16(Console.ReadLine());
                if ((resp <= 0) || (resp >= 4)) 
                {
                    Console.WriteLine("Entrada incorrecta");                    
                }
                else
                {
                    break;
                }
            }

            int ganador = rnd.Next(2);
            
            Console.WriteLine("\nEl ganador es: " + PrintGato(num_gatos[ganador]));

            if(ganador == (resp - 1))
            {
                Console.WriteLine("\nHa ganado: $" + (dinero+(dinero/2)) + "!!!!");
                cuenta.DineroGanado += (dinero + (dinero / 2));
                cuenta.calcularDineroTotal();
            }
            else
            {
                Console.WriteLine("\nHa perdido: $" + dinero);
                
                cuenta.DineroPerdido += (dinero);
                cuenta.calcularDineroTotal();
            }

        }

    }
}
