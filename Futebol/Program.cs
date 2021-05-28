using System;
using Futebol.Classes;

namespace Futebol
{
    class Program
    {
        static void Main(string[] args)
        {
            bool refazerAposentadoria = false;

            JogadorAtaque a = new JogadorAtaque();
            JogadorDefesa d = new JogadorDefesa();
            JogadorMeioCampo m = new JogadorMeioCampo();

            a.Menu();
            a.Informacoes();
            a.Idade();

            do
            {
                Console.WriteLine("Deseja ver quando vai poder se aposentar em alguma das posições?");
                Console.WriteLine(@"
Qual dessas posições o jogador faz parte:

1 - Ataque

2 - Defesa

3 - Meio Campo

X - Sair do programa" + "\n");

                string opcao2 = Console.ReadLine().ToLower();

                if (opcao2 == "1")
                {
                    a.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao2 == "2")
                {
                    d.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao2 == "3")
                {
                    m.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao2 == "x")
                {
                    refazerAposentadoria = true;
                }

                else
                {
                    Console.WriteLine("Opção inválida");
                    refazerAposentadoria = false;
                }
                
            } while (refazerAposentadoria == false);
        }
    }
}
