using System;

namespace Cafeteira.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel;

        public int total = 0;


        public int FazerCafe(int gramaAcucar, int acucarDisponivel)
        {
            if (gramaAcucar <= acucarDisponivel)
            {
                total = acucarDisponivel - gramaAcucar;
                Console.WriteLine($"\nCafé com {gramaAcucar}g de açucar e feito com carinho!\n");
                Console.WriteLine($"A quantidade de açucar restando é {total}");
            }

            else
            {
                Console.WriteLine("\nNão é possível fazer mais café com açucar!\n");
            }

            acucarDisponivel = total;

            return acucarDisponivel;
        }

        public int FazerCafe(int acucarResposta, int acucarDisponivel, int total)
        {
            total = acucarResposta - 10;

            if (total < 0)
            {
                Console.WriteLine("\nO açucar acabou não é possível fazer mais café!\n");
            }

            else
            {
                Console.WriteLine($"\nCafé recomendado com 10g de açucar feito com carinho!\n");
                Console.WriteLine($"A quantidade de açucar restando é {total}g\n");
            }

            acucarDisponivel = total;

            return acucarDisponivel;
        }
    }
}