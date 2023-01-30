using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.View
{
    public class Menus
    {
        static void MenuInicial()
        {


        }

        static void MenuJogos()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Participam duas pessoas que jogam alternadamente, preenchendo cada um dos espaços vazios." +
                "Vence o jogador que conseguir formar primeiro uma linha com três símbolos iguais, " +
                "seja ela na horizontal, vertical ou diagonal.");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("       XADREZ      ");
            Console.WriteLine("-------------------");
            Console.WriteLine("jogo de estratégia disputado por dois jogadores sobre um tabuleiro quadrado dividido em 64 quadrados menores (casas) brancos e pretos, alternadamente." +
                "Cada um dos enxadristas dispõe de 16 peças ou figuras de uma única cor, preta ou branca: um rei, uma rainha, dois bispos, dois cavalos, duas torres e oito peões." +
                " As peças são deslocadas pelos jogadores segundo determinadas regras, em jogadas alternadas." +
                "O objetivo do jogo é o “xeque-mate”, isto é, a tomada do rei adversário. ");
            Console.WriteLine();
            Console.WriteLine(" Informe a opção desejada:");
            Console.WriteLine("1 - JOGO DA VELHA");
            Console.WriteLine("2 - XADREZ");


        }
    }
}
