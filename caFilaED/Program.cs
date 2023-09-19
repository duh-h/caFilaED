using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFilaED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila minhaFila = new Fila();

            string controle;

            Console.WriteLine("[1] Insira um inteiro na Fila");
            Console.WriteLine("[2] Remova um inteiro da Fila");
            Console.WriteLine("[3] Insira um inteiro apos um outro a ser escolhido");
            Console.WriteLine("[4] Imprima a Fila");
            Console.WriteLine("[5] SAIR");

            controle = Console.ReadLine();

            while (controle != "5")
            {
                switch (controle)
                {
                    case "1":
                        Console.WriteLine("Insira um inteiro:");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        minhaFila.addFim(valor);
                        break;
                    case "2":
                        minhaFila.removeInicio();
                        break;
                    case "3":
                        Console.WriteLine("Escolha o numero:");
                        int insira = Convert.ToInt32(Console.ReadLine());
                        minhaFila.InsirirLugar(insira);

                        break;
                    case "4":
                        Console.WriteLine("Fila:");
                        minhaFila.Imprimirlista();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("[1] Insira um inteiro na Fila");
                Console.WriteLine("[2] Remova um inteiro da Fila");
                Console.WriteLine("[3] Insira um inteiro apos um outro a ser escolhido");
                Console.WriteLine("[4] Imprima a Fila");
                Console.WriteLine("[5] SAIR");

                controle = Console.ReadLine();
            }

        }
    }
}
        
    

