using System;
using PredioElevador.Classes;

namespace PredioElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int andarAtual = 0;

            int totalAndares = 0;

            int capacidade = 0;

            int quantidadePessoas = 0;

            bool refazerMenu = false;

            Console.WriteLine("Qual é o total de andares do prédio?");
            totalAndares = int.Parse(Console.ReadLine());


            ElevadorSocial c = new ElevadorSocial();
            c.Inicializa(capacidade);

            do
            {
                Console.WriteLine(@"
Qual elevador deseja usar? (Selecione uma das duas opções)

1 - Elevador Social

2 - Elevador Serviço" + "\n");

                string opcao = Console.ReadLine();

                bool refazerOpcao = false;

                do
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine(@"
Escolher uma das opções abaixo:

1 - Entrar

2 - Sair

3 - Subir

4 - Descer

X - Sair do programa" + "\n");

                            string opcao2 = Console.ReadLine();

                            if (opcao2 == "1")
                            {
                                ElevadorSocial social = new ElevadorSocial();
                                social.Entrar(capacidade, quantidadePessoas);
                                quantidadePessoas++;
                                refazerOpcao = false;
                            }

                            else if (opcao2 == "2")
                            {
                                ElevadorSocial social = new ElevadorSocial();
                                social.Sair(capacidade, quantidadePessoas);
                                quantidadePessoas--;
                                refazerOpcao = false;
                            }

                            else if (opcao2 == "3")
                            {
                                ElevadorSocial social = new ElevadorSocial();
                                social.Subir(andarAtual, totalAndares);
                                andarAtual++;
                                refazerOpcao = false;
                            }

                            else if (opcao2 == "4")
                            {
                                ElevadorSocial social = new ElevadorSocial();
                                social.Descer(andarAtual - 1, totalAndares);
                                andarAtual--;
                                refazerOpcao = false;
                            }

                            else if (opcao2 == "x")
                            {
                                refazerOpcao = true;
                            }

                            else
                            {
                                Console.WriteLine("Opção inválida!");
                            }

                            refazerMenu = true;
                            break;

                        case "2":
                            Console.WriteLine(@"
Escolher uma das opções abaixo:

1 - Entrar

2 - Sair

3 - Subir

4 - Descer

X - Sair do programa" + "\n");

                            string opcao3 = Console.ReadLine();

                            if (opcao3 == "1")
                            {
                                ElevadorServico servico = new ElevadorServico();
                                servico.Entrar(capacidade, quantidadePessoas);
                                refazerOpcao = false;
                            }

                            else if (opcao3 == "2")
                            {
                                ElevadorServico servico = new ElevadorServico();
                                servico.Sair(capacidade, quantidadePessoas);
                                refazerOpcao = false;
                            }

                            else if (opcao3 == "3")
                            {
                                ElevadorServico servico = new ElevadorServico();
                                servico.Subir(andarAtual, totalAndares);
                                refazerOpcao = false;
                            }

                            else if (opcao3 == "4")
                            {
                                ElevadorServico servico = new ElevadorServico();
                                servico.Descer(andarAtual, totalAndares);
                                refazerOpcao = false;
                            }

                            else if (opcao3 == "x")
                            {
                                refazerOpcao = true;
                            }

                            refazerMenu = true;
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            refazerMenu = false;
                            break;
                    }
                } while (refazerOpcao == false);

            } while (refazerMenu == false);
        }
    }
}
