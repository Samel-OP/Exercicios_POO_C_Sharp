using System;

namespace PredioElevador.Classes
{
    public abstract class Elevador
    {
        public int andarAtual;

        public int totalAndares;

        public int capacidade;

        public int quantidadePessoas;
        // Pessoas presentes no elevador


        public void Inicializa(int capacidadeElevador, int andaresPredio)
        {
            andarAtual = 0;
            quantidadePessoas = 0;
            capacidade = capacidadeElevador;
            totalAndares = andaresPredio;
        }

        public void Entrar()
        {
            if (quantidadePessoas < capacidade)
            {
                quantidadePessoas = quantidadePessoas + 1;
                Console.WriteLine($"\nEntrou mais uma pessoa");
            }

            else
            {
                Console.WriteLine($"Capacidade máxima atingida, agora em diante não é possível adicionar mais pessoas!");
            }
        }

        public void Sair()
        {
            if (quantidadePessoas > 0)
            {
                quantidadePessoas = quantidadePessoas - 1;
                Console.WriteLine($"\n{quantidadePessoas} pessoas restam, uma pessoa saiu");
            }

            else
            {
                Console.WriteLine("Não há pessoas para sair!");
            }
        }

        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual = andarAtual + 1;
                Console.WriteLine($"Agora você está no {andarAtual}° andar");
            }

            else
            {
                Console.WriteLine("Não é possível subir mais, este é o último andar!");
            }
        }

        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine($"\nAgora você está no {andarAtual}° andar");
            }

            else
            {
                Console.WriteLine($"\nAgora você está no térreo não é possível descer mais!");
            }
        }
    }
}