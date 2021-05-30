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


            do
            {

                Console.WriteLine(@"
Qual dessas posições o jogador faz parte:

1 - Ataque

2 - Defesa

3 - Meio Campo

X - Sair do programa" + "\n");

                string opcao = Console.ReadLine().ToLower();

                if (opcao == "1")
                {
                    a.Menu();
                    a.MostrarDados();
                    a.Idade();
                    a.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao == "2")
                {
                    d.Menu();
                    d.MostrarDados();
                    d.Idade();
                    d.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao == "3")
                {
                    m.Menu();
                    m.MostrarDados();
                    m.Idade();
                    m.Aposentadoria();
                    refazerAposentadoria = true;
                }

                else if (opcao == "x")
                {
                    refazerAposentadoria = true;
                }

                else
                {
                    Console.WriteLine("\nOpção inválida");
                    refazerAposentadoria = false;
                }

            } while (refazerAposentadoria == false);
        }
    }
}
