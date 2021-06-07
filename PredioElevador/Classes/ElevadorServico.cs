using System;

namespace PredioElevador.Classes
{
    public class ElevadorServico : Elevador
    {
        public int quantidadeCaixas;

        public void Inicializar(int capacidadeElevador, int andaresPredio)
        {
            andarAtual = 0;
            quantidadePessoas = 0;
            capacidade = capacidadeElevador;
            totalAndares = andaresPredio;
        }

        public void Caixas()
        {
            if (quantidadeCaixas < capacidade)
            {
                Console.WriteLine($"\n{quantidadeCaixas + 1} restantes para chegar a capacidade máxima de caixas");
            }

            else
            {
                Console.WriteLine($"Capacidade máxima atingida, agora em diante não é possível adicionar mais Caixas! {capacidade}");
            }
        }

        public void SairCaixas()
        {
            if (quantidadeCaixas > capacidade)
            {
                Console.WriteLine($"\n{quantidadePessoas - 1} estão saindo");
            }

            else
            {
                Console.WriteLine("Não há Caixass para sair!");
            }
        }
    }
}