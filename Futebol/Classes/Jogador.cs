using System;

namespace Futebol.Classes
{
    public abstract class Jogador
    {
        public string nome
        { get; set; }

        public int idadeJogador
        { get; set; }

        public int anoNascimento 
        { get; set; }

        private string nacionalidade
        { get; set; }

        private double altura
        { get; set; }

        private double peso
        { get; set; }

        public DateTime AnoAtual = DateTime.Now;


        public void Menu()
        {
            Console.WriteLine("Escreva o nome do jogador: ");
            nome = Console.ReadLine();

            Console.WriteLine("Escreva o ano de nascimento do jogador: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nacionalidade do jogador: ");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Escreva a altura do jogador: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o peso do jogador: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine(@"
Qual dessas posições o jogador faz parte:

1 - Ataque

2 - Defesa

3 - Meio Campo

X - Sair do programa" + "\n");

        }

        public void Idade()
        {
            idadeJogador = AnoAtual.Year - anoNascimento;
            Console.WriteLine($"A idade do jogador é {idadeJogador}");
        }

        public void Informacoes()
        {
            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "1":
                    JogadorAtaque a = new JogadorAtaque();
                    a.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso);
                    break;

                case "2":
                    JogadorDefesa d = new JogadorDefesa();
                    d.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso);
                    break;

                case "3":
                    JogadorMeioCampo m = new JogadorMeioCampo();
                    m.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso);
                    break;

                case "x":
                    break;

                default:
                    break;
            }
        }

        public virtual void Aposentadoria()
        {
            if ( idadeJogador >= 30)
            {
                Console.WriteLine($"O jogador pode se aposentar porque tem {idadeJogador}");
            }

            else
            {
                Console.WriteLine($"Falta {30 - idadeJogador} anos para o jogador se aposentar");
            }
        }

        public void MostrarDados(string nome, int anoNascimento, string nacionalidade, double altura, double peso)
        {
            Console.WriteLine($"O nome do jogador é {nome}");
            Console.WriteLine($"O ano de nascimento do jogador é {anoNascimento}");
            Console.WriteLine($"A nacionalidade do jogador é {nacionalidade}");
            Console.WriteLine($"A altura do jogador é {altura:N2} m");
            Console.WriteLine($"O peso do jogador é {peso:N2} Kg");
        }
    }
}