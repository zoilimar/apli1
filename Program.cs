using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            String cp1;
            int cp2;
            Char matematicas;
            Console.WriteLine("---------------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("---------------------");
            Console.WriteLine("Escribe tu usuario o correo");
            cp1 = Console.ReadLine();
            Console.WriteLine("Escribe tu contraseña");
            int.TryParse(Console.ReadLine(), out cp2);
            if ((cp1 == "admin") && (cp2 == 1234))
            {
                Console.WriteLine("Inicio su Login");
                Console.Clear();
                Console.WriteLine("Funciones Aritmeticas");
                Char.TryParse(Console.ReadLine(), out matematicas);
                switch (matematicas)
                {
                    case '1':
                        {
                            Console.WriteLine("sumar");
                            Console.ReadLine();
                        }
                        break;
                    case '2':
                        {
                            Console.WriteLine("multiplicar");
                            Console.ReadLine();
                        }
                        break;
                    case '3':
                        {
                            Console.WriteLine("dividir");
                            Console.ReadLine();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No puede acceder");
                Console.ReadLine();
            }

        }
    }
}
