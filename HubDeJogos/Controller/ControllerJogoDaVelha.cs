using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using HubDeJogos.View;
using HubDeJogos.Controller.Jogadores;
using HubDeJogos.Model;
using Newtonsoft.Json;

namespace HubDeJogos.Controller
{
    class ControllerJogoDaVelha 
    {
        public void IniciarJogoDaVelha()
        {
            string jogador1 = "";
            string jogador2 = "";
            string[,] matriz = new string[3, 3];

            List<string> indexNumeros = new List<string> { };

            int index = 1;

            int tentativas = 1;
            ImprimirTituloJogo();
            ControllerJogadores controllerJogadores = new ControllerJogadores();
            controllerJogadores.Listar();
            do
            {
                var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\jogadores.json");
                var jogador = JsonConvert.DeserializeObject<List<Jogador>>(json);
                Console.WriteLine($"Digite o nome do jogado(a): ");
                string nomeDigitado = Console.ReadLine();
                if (jogador.Exists(p => p.nome == nomeDigitado))
                {

                    jogador1 = nomeDigitado;
                }
                else
                {
                    Console.WriteLine("Jogador não encontrado!");
                }

            } while (jogador1 == "");

            do
            {
                var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\jogadores.json");
                var jogador = JsonConvert.DeserializeObject<List<Jogador>>(json);
                Console.WriteLine($"Digite o nome do jogado(a): ");
                string nomeDigitado = Console.ReadLine();
                if (jogador1 == nomeDigitado)
                {
                    Console.WriteLine("Jogador já selecionado. Por favor, escalha um outro jogador! ");
                }
                else if(jogador.Exists(p => p.nome == nomeDigitado))
                {

                    jogador2 = nomeDigitado;
                }
                else
                {
                    Console.WriteLine("Jogador não encontrado!");
                }

            } while (jogador2 == "");

            Console.Write("Digite o nome do primeiro jogador: ");
            jogador1 = Console.ReadLine();

            Console.WriteLine($" {jogador1.ToUpper()} você começa!");
            Console.WriteLine(" ");
            string turno = jogador1.ToUpper();

            index = AlimentarMatriz(matriz, indexNumeros, index);

            ImprimirMatriz(matriz);
            EscolherPosicaoJogada(turno);
            string jogada = Console.ReadLine();

            Console.Clear();

            // Começa o jogo.
            while (tentativas < 9)
            {
                ImprimirTituloJogo();
                SubstituirValorNaSuaRespectivaCasa(matriz, turno, indexNumeros, jogada);
                ImprimirMatriz(matriz);

                // Condição de vitória nas Diagonais.
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    ImprimirMensagemFimJogoGanhador(turno);
                    break;
                }
                // Condição de vitória nas Linhas.
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                    matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                    matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    ImprimirMensagemFimJogoGanhador( turno);
                    break;
                }
                // Condição de vitória nas Colunas.
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    ImprimirMensagemFimJogoGanhador(turno);
                    break;
                }
                // Verificar Turno do Jogador
                if (turno == jogador1.ToUpper())
                {
                    turno = jogador2.ToUpper();
                }
                else
                {
                    turno = jogador1.ToUpper();
                }

                Console.WriteLine();
                EscolherPosicaoJogada(turno);
                jogada = Console.ReadLine();

                while (!indexNumeros.Contains(jogada))
                {
                    Console.WriteLine();
                    Console.Write("Jogada invalida. Tente Novamente: ");
                    jogada = Console.ReadLine();
                }

                tentativas++;

                Console.Clear();
            }
            if (tentativas == 9)
            {
                ImprimirTituloJogo();
                ImprimirMatriz(matriz);
                ImprimirMensagemImpate();
            }

            Console.ReadLine();

            static void ImprimirTituloJogo()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("   JOGO DA VELHA   ");
                Console.WriteLine("-------------------");
            }

            static int AlimentarMatriz(string[,] matriz, List<string> indexNumeros, int index)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = index.ToString();
                        indexNumeros.Add(index.ToString());
                        index++;
                    }
                }

                return index;
            }

            static void ImprimirMatriz(string[,] matriz)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write($" [{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }
            }

            static void ImprimirMensagemFimJogoGanhador(string turno)
            {
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nParabéns!!! O ganhador é {turno.ToUpper()}");


            }

            static void EscolherPosicaoJogada(string turno)
            {
                Console.WriteLine($"{turno.ToUpper()}, você quer jogar  em qual posição? ");
            }

            static void ImprimirMensagemImpate()
            {
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");

            }

            static void SubstituirValorNaSuaRespectivaCasa(string[,] matriz, string turno, List<string> indexNumeros, string jogada)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == jogada && indexNumeros.Contains(jogada))
                        {
                            matriz[i, j] = turno;
                            indexNumeros.Remove(jogada);
                        }
                    }
                }
            }
        }
    }
}
