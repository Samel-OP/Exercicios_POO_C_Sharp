using System;
using Cafeteira.Classes;

namespace Cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Super CafeteiraTabajaras Plus++ | A melhor cafeteira\n");

            MaquinaCafe i = new MaquinaCafe();
            i.informacoes();
        }
    }
}
