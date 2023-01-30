using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.View
{
    internal class Mensagens
    {
        static void tituloJogoDaVelha()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA   ");
            Console.WriteLine("-------------------");
        }

        static void tituloXadrez()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("       XADREZ      ");
            Console.WriteLine("-------------------");
        }

        static void mensagemImpate()
        {
            Console.WriteLine("\n--------------");
            Console.WriteLine("Fim de Jogo!!!");
            Console.WriteLine("--------------");
            Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");

        }

        static void mensagemGanhador(string turno)
        {
            Console.WriteLine("\n--------------");
            Console.WriteLine("Fim de Jogo!!!");
            Console.WriteLine("--------------");
            Console.WriteLine($"\nParabéns!!! O ganhador é {turno.ToUpper()}");
        }
    }
}
