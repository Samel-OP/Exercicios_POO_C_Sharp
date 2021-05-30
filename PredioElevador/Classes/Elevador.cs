using System;

namespace PredioElevador.Classes
{
    public abstract class Elevador
    {
        public int andarAtual;

        public int totalAndares;

        public int capacidade;

        public int quantidadePessoas;

        public int total;


        public int Inicializa(int capacidade)
        {
            return capacidade;
        }

        public int Entrar(int quantidadePessoas, int capacidade)
        {
            if (quantidadePessoas <= capacidade)
            {
                Console.WriteLine($"\n{capacidade} restantes para chegar a capacidade máxima");
            }

            else
            {
                Console.WriteLine($"Capacidade máxima atingida, agora em diante não é possível adicionar mais pessoas!");
            }

            return quantidadePessoas;
        }

        public int Sair(int quantidadePessoas)
        {
            if (quantidadePessoas > capacidade)
            {
                Console.WriteLine($"\n{quantidadePessoas} estão saindo");
            }

            else
            {
                Console.WriteLine("Não há pessoas para sair!");
            }

            return capacidade;
        }

        public int Subir(int andarAtual, int totalAndares)
        {
            if (andarAtual >= totalAndares)
            {
                Console.WriteLine("Não é possível subir mais, este é o último andar!");
                andarAtual = andarAtual - 1;
            }

            else
            {
                Console.WriteLine($"Agora você está no {andarAtual + 1}° andar");
                andarAtual = totalAndares;
            }

            return andarAtual;
        }

        public int Descer(int andarAtual, int totalAndares)
        {
            if (andarAtual <= 0)
            {
                Console.WriteLine($"\nAgora você está no térreo não é possível descer mais!");
                andarAtual = andarAtual - andarAtual;
                andarAtual = 0;
            }

            else
            {
                Console.WriteLine($"\nAgora você está no {andarAtual - 1}° andar");
            }

            return andarAtual;
        }
    }
}