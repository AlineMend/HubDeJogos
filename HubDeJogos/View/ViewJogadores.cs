using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDeJogos.View
{
    public interface ViewJogadores
    {
        void Registrar();
        void Apresentar(string nomeDigitado);
        void Listar();
    }
}
