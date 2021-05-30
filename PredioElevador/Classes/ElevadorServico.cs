using System;

namespace PredioElevador.Classes
{
    public class ElevadorServico : Elevador
    {
        public int quantidadeCaixas;


        public int Caixas(int quantidadeCaixas)
        {
            if (quantidadePessoas <= capacidade)
            {
                Console.WriteLine($"\n{capacidade} restantes para chegar a capacidade máxima");
            }

            else
            {
                Console.WriteLine($"Capacidade máxima atingida, agora em diante não é possível adicionar mais Caixas!");
            }

            return quantidadePessoas;
        }

        public int SairCaixas(int quantidadeCaixas, int capacidade)
        {
            if (quantidadePessoas > capacidade)
            {
                Console.WriteLine($"\n{quantidadePessoas} estão saindo");
            }

            else
            {
                Console.WriteLine("Não há Caixass para sair!");
            }

            return capacidade;
        }
    }
}