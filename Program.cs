using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Secuencial1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántas apuestas quieres hacer al Euromillones?");
            int numApuesta = int.Parse(Console.ReadLine());
            Random numbers = new Random();

            for(int i = 0; i < numApuesta; i++)
            {
                Console.Write("Números: ");
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(numbers.Next(1, 51) + ", ");
                }
                    Console.Write("\t");
                    Console.Write("Estrellas: ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(numbers.Next(1, 13) + ", ");
                    Console.Write("\n");
                }
            }


        }
    }
}
