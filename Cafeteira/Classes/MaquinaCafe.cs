using System;

namespace Cafeteira.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;

        public int total = 0;


        public void informacoes()
        {
            bool refazerMenu = false;

            do
            {
                Console.WriteLine(@"Deseja qual tipo de café?
            
            1 - Com açucar
            2 - Sem açucar
            3 - Café recomendado
            X - Sair");

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        MaquinaCafe m = new MaquinaCafe();
                        m.FazerCafe(total);
                        refazerMenu = false;
                        break;

                    case "2":
                        Console.WriteLine($"\nCafé sem açucar feito com carinho!\n");
                        refazerMenu = false;
                        break;

                    case "3":
                        MaquinaCafe n = new MaquinaCafe();
                        n.FazerCafe();
                        refazerMenu = false;
                        break;

                    case "x":
                        refazerMenu = true;
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        refazerMenu = false;
                        break;
                }
            } while (refazerMenu == false);

        }

        public int FazerCafe(int total)
        {
            Console.WriteLine("Quantos gramas de açucar você deseja?");
            int gramaAcucar = int.Parse(Console.ReadLine());

            if (gramaAcucar <= acucarDisponivel)
            {
                Console.WriteLine($"\nCafé com {gramaAcucar}g de açucar e feito com carinho!\n");
                total = acucarDisponivel - gramaAcucar;
                Console.WriteLine($"A quantidade de açucar restando é {total}");
            }

            else
            {
                Console.WriteLine("\nNão é possível fazer mais café com açucar!");
            }

            return total;
        }

        public void FazerCafe()
        {
            total = acucarDisponivel - 10;
            Console.WriteLine($"\nCafé recomendado com 10g de açucar feito com carinho!\n");
            Console.WriteLine($"A quantidade de açucar restando é {total}\n");
        }
    }
}