using HubDeJogos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using HubDeJogos.Model;
using Newtonsoft.Json;

namespace HubDeJogos.Controller.Jogadores
{
    internal class ControllerJogadores : ViewJogadores
    {
        
        public void Registrar()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\jogadores.json");
            var jogador = JsonConvert.DeserializeObject<List<Jogador>>(json);
            var novoJogador = new Jogador();
            Console.Write("Digite o Nome do jogador: ");
            novoJogador.nome = Console.ReadLine();
            novoJogador.pontuaoTotal = 0;
            novoJogador.resultadoJogos = new List<ResultadoJogos>();
            ResultadoJogos resultadoJogos = new ResultadoJogos();
            resultadoJogos.vitorias = 0;
            resultadoJogos.derrotas= 0;
            resultadoJogos.empates = 0;
            resultadoJogos.pontuao = 0;
            novoJogador.resultadoJogos.Add(resultadoJogos);
            jogador.Add(novoJogador);

            var json_serealizado = JsonConvert.SerializeObject(jogador);


        }

        public void Apresentar(string nomeDigitado)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\jogadores.json");
            var jogador = JsonConvert.DeserializeObject<List<Jogador>>(json);
            Console.WriteLine($"Digite o nome do jogado(a): ");
            nomeDigitado = Console.ReadLine();
            if (jogador.Exists(p => p.nome == nomeDigitado))
            {
             
                Console.WriteLine(jogador.Where(x => x.nome.StartsWith(nomeDigitado)).ToList());
            }
            else
            {
                Console.WriteLine("Jogador não encontrado!");
            }

        }


        public void Listar()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\jogadores.json");
            var jogador = JsonConvert.DeserializeObject<List<Jogador>>(json);
            Console.WriteLine(jogador);
        }

        public void Resultados()
        {

        }

    }
}
