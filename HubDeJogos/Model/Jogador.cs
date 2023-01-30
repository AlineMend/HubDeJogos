using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.Model
{
    class Jogador
    {
        public Jogador()
        {
        }

        public Jogador(string nome, int pontuaoTotal, List<ResultadoJogos> resultadoJogos)
        {
            this.nome = nome;
            this.pontuaoTotal = pontuaoTotal;
            this.resultadoJogos = resultadoJogos;
        }

        public string nome { get; set; }
        public int pontuaoTotal { get; set; }
        public List<ResultadoJogos> resultadoJogos { get; set; }

        
    }
    
}
