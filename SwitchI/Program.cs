using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção A, B ou C: ");
            string o = Console.ReadLine();

            string opcao = o.ToUpper();

            switch (opcao)
            {
                case "A":
                    Console.WriteLine("Escolhida a opção A.");
                    break;
                case "B":
                    Console.WriteLine("Escolhida a opção B.");
                    break;
                case "C":
                    Console.WriteLine("Escolhida a opção C.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
