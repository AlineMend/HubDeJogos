using System;
using HubDeJogos.Controller;
using HubDeJogos.Controller.Jogadores;
using HubDeJogos.Model;
using Newtonsoft.Json;

namespace HubDeJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                MenuInicial();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");
                switch (option)
                {

                    case 1:
                        ControllerJogadores controllerJogadores = new ControllerJogadores();
                        controllerJogadores.Listar();
                        break;
                    case 2:
                        ControllerJogadores controllerJogadores1 = new ControllerJogadores();
                        controllerJogadores1.Registrar();
                        break;
                    case 3:
                        IniciarJogo();
                        break;
                    case 4:
                        ControllerJogadores controllerJogadores2 = new ControllerJogadores();
                        controllerJogadores2.Resultados();
                        break;

                    case 6:
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }

            while (option != 0);

            Console.WriteLine("Obrigado por utilizar nossos jogos!");
            Console.ReadLine();
        }

        private static void Resultados()
        {
            throw new NotImplementedException();
        }

        private static void IniciarJogo()
        {
            int option;

            do
            {
                MenuJogos();
                option = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");
                switch (option)
                {

                    case 1:
                        ControllerJogoDaVelha controllerJogoDaVelha = new ControllerJogoDaVelha();
                        controllerJogoDaVelha.IniciarJogoDaVelha();
                        break;
                    case 2:
                         ControllerBatalhaNaval controllerBatalhaNaval= new ControllerBatalhaNaval();
                        controllerBatalhaNaval.IniciarBatalhaNaval();
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }

            while (option != 0);
            Console.ReadLine();

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
                Console.WriteLine("   BATALHA NAVAL   ");
                Console.WriteLine("-------------------");
                Console.WriteLine(" Jogo de tabuleiro de dois jogadores, " +
                    "no qual os jogadores têm de adivinhar " +
                    "em que quadrados estão os navios do oponente. ");
                Console.WriteLine();
                Console.WriteLine(" Informe a opção desejada:");
                Console.WriteLine("1 - JOGO DA VELHA");
                Console.WriteLine("2 - BATALHA NAVAL");


            }
        }

        private static void MenuInicial()
        {
            Console.WriteLine();
            Console.WriteLine(" Bem Vindo(a)!");
            Console.WriteLine(" Informe a opção desejada:");

            Console.WriteLine("1 - Listar jogadores");
            Console.WriteLine("2 - Inserir novo jogador");
            Console.WriteLine("3 - Começar o jogo");
            Console.WriteLine("4 - Resultado dos jogos");
            Console.WriteLine("6 - Limpar tela");
            Console.WriteLine("x - Sair");
            Console.WriteLine();
        }

    }
}
