using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.Model
{
    internal class ResultadoJogos
    {
        public ResultadoJogos()
        {
        }

        public ResultadoJogos(int vitorias, int derrotas, int empates, int pontuao)
        {
            this.vitorias = vitorias;
            this.derrotas = derrotas;
            this.empates = empates;
            this.pontuao = pontuao;
        }

        public int vitorias { get; set; }
        public int derrotas { get; set; }
        public int empates { get; set; }
        public int pontuao { get; set; }
    }
}
