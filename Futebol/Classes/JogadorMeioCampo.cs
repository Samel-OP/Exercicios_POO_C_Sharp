using System;

namespace Futebol.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public override void Aposentadoria()
        {
            if (idadeJogador >= 38)
            {
                Console.WriteLine($"O jogador pode se aposentar porque tem {idadeJogador}");
            }

            else
            {
                Console.WriteLine($"Falta {38 - idadeJogador} anos para o jogador se aposentar");
            }
        }
    }
}