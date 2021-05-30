using System;

namespace Futebol.Classes
{
    public class JogadorAtaque : Jogador
    {
        public override void Aposentadoria()
        {
            if (idadeJogador >= 35)
            {
                Console.WriteLine($"O jogador pode se aposentar porque tem {idadeJogador}");
            }

            else
            {
                Console.WriteLine($"\nFalta {35 - idadeJogador} anos para o jogador se aposentar\n");
            }
        }
    }
}