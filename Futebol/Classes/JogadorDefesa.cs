using System;

namespace Futebol.Classes
{
    public class JogadorDefesa : Jogador
    {
        public override void Aposentadoria()
        {
            if (idadeJogador >= 40)
            {
                Console.WriteLine($"O jogador pode se aposentar porque tem {idadeJogador}");
            }

            else
            {
                Console.WriteLine($"Falta {40 - idadeJogador} anos para o jogador se aposentar");
            }
        }
    }
}