
using System;
using System.Collections.Generic;

namespace ListaArmas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Armas = new List<string>();

            string novaArma = "";
            bool sair = true;
            int armaEscolhida;

            Armas.Add("Bomba Nuclear");
            Armas.Add("Gosma Radioativa");

            do
            {
                Armas.Sort();
                Console.WriteLine("==============================");
                Console.WriteLine("        LISTA DE ARMAS");
                Console.WriteLine("==============================");
                for (int i = 0; i < Armas.Count; i++)
                {
                    Console.WriteLine(Armas[i]);
                }
                Console.WriteLine("==============================");

                Console.WriteLine("\nPara adicionar uma nova arma, aperte 'A'\nCaso queira escolher uma arma da lista, aperte 'N'\nPara sair do programa, aperte 'S'");
                string ctrl = Console.ReadLine();

                switch (ctrl)
                {
                    case "A":
                        Console.WriteLine("Escreva o nome da arma que você deseja que seja adicionada: ");
                        novaArma = Console.ReadLine();
                        Armas.Add(novaArma);

                        break;

                    case "S":
                        Console.WriteLine("Encerrando programa...");
                        sair = false;
                        break;

                    case "N":
                        Console.Clear();

                        Console.WriteLine("==============================");
                        Console.WriteLine("        LISTA DE ARMAS");
                        Console.WriteLine("==============================");

                        for (int i = 0; i < Armas.Count; i++)
                        {
                            Console.WriteLine(i + " - " + Armas[i]);
                        }
                        Console.WriteLine("==============================");

                        Console.Write("\n\nEscolha o número correspondente a arma escolhida: ");
                        armaEscolhida = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("____________________________________________");
                        Console.WriteLine("||   Usando " + Armas[armaEscolhida] + "  ||");

                        break;

                    default:
                        Console.WriteLine("\n\n\nInválido! Tente novamente.");
                        break;
                }

            } while (sair == true);
        }
    }
}