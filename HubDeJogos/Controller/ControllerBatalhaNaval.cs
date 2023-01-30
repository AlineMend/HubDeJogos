using HubDeJogos.Controller.Jogadores;
using HubDeJogos.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.Controller
{
    internal class ControllerBatalhaNaval
    {
        public void IniciarBatalhaNaval()
        {
            string jogador1 = "";
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
            int num1;
            int num2;
            string[,] tabela = new string[10, 10];
            int cont = 0;
            int col;
            int lin;
            int contdebarcos = 5;


            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                num1 = rnd.Next(10);
                num2 = rnd.Next(10);

                tabela[num1, num2] = "Acertou";
            }

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; i <= 9; i++)
                {

                    if (tabela[i, j] == "Acertou")
                    {
                        continue;
                    }
                    else
                    {
                        tabela[i, j] = "Falhou";
                    }

                }

            }
            do
            {
                Console.WriteLine("Digite o numero da coluna:");
                col = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero da linha:");
                lin = int.Parse(Console.ReadLine());
                cont++;

                if (tabela[col, lin] == "Acertou")
                {
                    contdebarcos--;
                    Console.WriteLine("------ACERTOU------\n ------Faltam {0} submarinos------", contdebarcos);
                    tabela[col, lin] = "U";

                }
                else
                {
                    Console.WriteLine("------FALHOU------\n ------Faltam {0} submarinos------", contdebarcos);
                }

            } while (contdebarcos > 0);

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------Parabéns------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Tentativas: {0}--------------------------------", cont);
        }

    }
}
