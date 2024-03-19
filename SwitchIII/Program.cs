using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a forma geométrica");
            Console.WriteLine(" (Q - Quadrado . R - Retângulo . T - Trapézio . L - Losango): ");
            string f = Console.ReadLine();

            string forma = f.ToUpper();

            double a, b, h, c;

            switch (forma)
            {
                case "Q":
                    Console.WriteLine("Insira o lado do quadrado: ");
                    a = double.Parse(Console.ReadLine());
                    c = a * a;
                    Console.WriteLine("Área do quadrado: " + c);
                    break;

                case "R":
                    Console.WriteLine("Insira o comprimento do retângulo: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a largura do retângulo: ");
                    b = double.Parse(Console.ReadLine());
                    c = b * a;
                    Console.WriteLine("Área do retângulo: " + c);
                    break;

                case "T":
                    Console.WriteLine("Insira a primeira base do trapézio: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a outra base do trapézio: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a altura do trapézio: ");
                    h = double.Parse(Console.ReadLine());
                    c = (a + b) * (h / 2);
                    Console.WriteLine("Área do trapézio: " + c);
                    break;

                case "L":
                    Console.WriteLine("Insira a maior diagonal do losango: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a menor diagonal do losango: ");
                    b = double.Parse(Console.ReadLine());
                    c = (2 * b) * a;
                    Console.WriteLine("Área do losango: " + c);
                    break;

                default:
                    Console.WriteLine("Código inválido!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
