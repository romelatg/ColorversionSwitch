using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ColorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            functColor("Amarillo");
            functColor("Morado");
            functColor("Rosa");
            functColor("Azul");
            functColor("Blanco");
            Console.ReadLine();
        }

        static void functColor(string color)
        {
            switch (color.ToLower())
            {
                case "amarillo":
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine("2x{0}={1}", i, 2 * i);
                    }
                    break;
                case "morado":
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine("7x{0}={1}", i, 7 * i);
                    }
                    break;
                case "rosa":
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine("9x{0}={1}", i, 9 * i);
                    }
                    break;
                case "azul":
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine("6x{0}={1}", i, 6 * i);
                    }
                    break;
                case "blanco":
                    for (int i = 1; i < 13; i++)
                    {
                        Console.WriteLine("12x{0}={1}", i, 12 * i);
                    }
                    break;
                default:
                    Console.WriteLine("No es color correcto");
                    break;
            }
        }
    }
}
