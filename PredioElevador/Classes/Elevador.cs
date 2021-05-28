using System;

namespace PredioElevador.Classes
{
    public abstract class Elevador
    {
        public int andarAtual;

        public int totalAndares;

        public int capacidade {get; set;}

        public int quantidadePessoas;

        public int total;


        public int Inicializa(int capacidade)
        {
            Console.WriteLine("Qual é a capacidade do elevador?");
            capacidade = int.Parse(Console.ReadLine());
            
            return capacidade;
        }

        public int Entrar(int Capacidade, int quantidadePessoas)
        {
            quantidadePessoas++;

            if (quantidadePessoas > Inicializa(capacidade))
            {
                Console.WriteLine($"Capacidade máxima é {capacidade}, não é possível adicionar mais {quantidadePessoas} pessoas!");
            }

            else
            {
                Console.WriteLine($"{quantidadePessoas + 1} restantes para chegar a capacidade máxima");
            }

            return quantidadePessoas;
        }

        public int Sair(int capacidade, int quantidadePessoas)
        {
            if (quantidadePessoas > capacidade)
            {
                Console.WriteLine($"{quantidadePessoas} estão saindo");
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
            }

            else
            {
                Console.WriteLine($"Agora você está no {andarAtual + 1}° andar");
            }

            return andarAtual;
        }

        public int Descer(int andarAtual, int totalAndares)
        {
            if (andarAtual == 0)
            {
                Console.WriteLine($"Agora você está no térreo não é possível descer mais!");
            }

            else
            {
                Console.WriteLine($"Agora você está no {andarAtual - 1}° andar");
            }

            return andarAtual;
        }
    }
}