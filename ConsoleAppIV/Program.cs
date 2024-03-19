using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o sinal da operação (+, -, *, /): ");
            string calc = Console.ReadLine();

            switch (calc)
            {
                case "+":
                    double c = a + b;
                    Console.WriteLine("Resultado da operação: " + c);
                    break;
                case "-":
                    double d = a - b;
                    Console.WriteLine("Resultado da operação: " + d);
                    break;
                case "*":
                    double e = a * b;
                    Console.WriteLine("Resultado da operação: " + e);
                    break;
                case "/":
                    double f = a / b;
                    Console.WriteLine("Resultado da operação: " + f);
                    break;
                default:
                    Console.WriteLine("Código inválido!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
