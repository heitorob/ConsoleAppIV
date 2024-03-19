using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tipo de contratação do funcionário");
            Console.WriteLine("(A - Assalariado . C - Comissionado . H - Horista)");
            string c = Console.ReadLine();

            string contrat = c.ToUpper();
            double bruto = 0, vpeca = 0, vhora = 0, desconto = 0, salario = 0, ir = 0;
            int pecas = 0, horas = 0;

            switch (contrat)
            {
                case "A":
                    Console.WriteLine("Insira o salário do funcionário: ");
                    bruto = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o desconto: ");
                    desconto = double.Parse(Console.ReadLine());

                    salario = bruto - desconto;

                    break;

                case "C":
                    Console.WriteLine("Insira o valor da unidade de peças: ");
                    vpeca = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o número de peças produzidas: ");
                    pecas = int.Parse(Console.ReadLine());

                    salario = vpeca * pecas;

                    break;

                case "H":
                    Console.WriteLine("Insira o valor da hora: ");
                    vhora = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o número de horas trabalhadas: ");
                    horas = int.Parse(Console.ReadLine());

                    salario = vhora * horas;

                    break;

                default:
                    Console.WriteLine("Código inválido!!");
                    break;
            }

            Console.WriteLine("Salário do funcionário: " + salario.ToString("C"));

            if (salario >= 2000)
            {
                ir = salario * 0.075;
            }
            else if (salario >= 4000)
            {
                ir = salario * 0.12;
            }
            else
            {
                ir = salario * 0.15;
            }
            Console.WriteLine("Desconto do imposto de renda: " + ir.ToString("C"));

            Console.ReadKey();
        }
    }
}
