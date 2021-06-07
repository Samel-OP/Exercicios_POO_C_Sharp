using System;
using PredioElevador.Classes;

namespace PredioElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string opcao2;
            bool opcaoF = false;
            bool opcaoF2 = false;
            bool opcaoF3 = false;

            Console.WriteLine("Bem vindo ao Elevador!");

            ElevadorServico servico = new ElevadorServico();
            ElevadorSocial social = new ElevadorSocial();

            social.Inicializa(3, 2);
            servico.Inicializar(3,2);

            do
            {
                Console.WriteLine(@"
Qual elevador deseja usar? (Selecione uma das duas opções)

1 - Elevador Social

2 - Elevador Serviço" + "\n");

                opcao = Console.ReadLine();


                if (opcao == "1")
                {
                    do
                    {

                        Console.WriteLine(@"
Escolher uma das opções abaixo:

1 - Entrar

2 - Sair

3 - Subir

4 - Descer

X - Sair do programa" + "\n");


                        opcao2 = Console.ReadLine().ToLower();
                        switch (opcao2)
                        {
                            case "1":
                                social.Entrar();
                                opcaoF = false;
                                break;

                            case "2":
                                social.Sair();
                                opcaoF = false;
                                break;

                            case "3":
                                social.Subir();
                                opcaoF = false;
                                break;

                            case "4":
                                social.Descer();
                                opcaoF = false;
                                break;

                            case "x":
                                Console.WriteLine("Obrigado por usar nosso elevador!");
                                opcaoF = true;
                                opcaoF2 = true;
                                break;

                            default:
                                Console.WriteLine("Opção inválida!");
                                opcaoF = false;
                                break;
                        }
                    } while (opcaoF == false);

                }

                else if (opcao == "2")
                {
                    do
                    {
                        Console.WriteLine(@"
Escolher uma das opções abaixo:

1 - Entrar

2 - Sair

3 - Subir

4 - Descer

X - Sair do programa" + "\n");

                        opcao2 = Console.ReadLine().ToLower();
                        switch (opcao2)
                        {
                            case "1":
                                servico.Caixas();
                                opcaoF3 = false;
                                break;

                            case "2":
                                servico.SairCaixas();
                                opcaoF3 = false;
                                break;

                            case "3":
                                social.Subir();
                                opcaoF3 = false;
                                break;

                            case "4":
                                social.Descer();
                                opcaoF3 = false;
                                break;

                            case "x":
                                Console.WriteLine("Obrigado por usar nosso elevador!");
                                opcaoF3 = true;
                                opcaoF2 = true;
                                break;

                            default:
                                Console.WriteLine("Opção inválida!");
                                opcaoF3 = false;
                                break;
                        }
                    } while (opcaoF3 == false);
                }

                else
                {
                    Console.WriteLine("Opção inválida");
                }
            } while (opcaoF2 == false);
        }
    }
}
