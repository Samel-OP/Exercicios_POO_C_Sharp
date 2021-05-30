using System;
using Cafeteira.Classes;

namespace Cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Super CafeteiraTabajaras Plus++ | A melhor cafeteira\n");

            Console.WriteLine("Configurações:\n");

            Console.WriteLine("Quanto de açucar deseja colocar na máquina? (Em gramas)");
            int acucarResposta = int.Parse(Console.ReadLine());

            int acucarDisponivel = acucarResposta;

            int total = 0;

            bool refazerMenu = false;

            do
            {
                Console.WriteLine(@"Deseja qual tipo de café?
            
            1 - Com açucar
            2 - Sem açucar
            3 - Café recomendado
            X - Sair" + "\n");

                Console.Write("Resposta: ");

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        MaquinaCafe m = new MaquinaCafe();
                        Console.WriteLine("Quantos gramas de açucar você deseja?");
                        int gramaAcucar = int.Parse(Console.ReadLine());

                        m.FazerCafe(gramaAcucar, acucarDisponivel);
                        total = acucarDisponivel - gramaAcucar;
                        acucarDisponivel = total;
                        refazerMenu = false;
                        break;

                    case "2":
                        Console.WriteLine($"\nCafé sem açucar feito com carinho!\n");
                        refazerMenu = false;
                        break;

                    case "3":
                        MaquinaCafe n = new MaquinaCafe();
                        n.FazerCafe(acucarDisponivel, acucarResposta, total);
                        total = acucarDisponivel - 10;
                        acucarDisponivel = total;
                        refazerMenu = false;
                        break;

                    case "x":
                        refazerMenu = true;
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!\n");
                        refazerMenu = false;
                        break;
                }
            } while (refazerMenu == false);
        }
    }
}
