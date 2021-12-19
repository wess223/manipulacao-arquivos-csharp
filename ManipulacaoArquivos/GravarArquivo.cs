using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    public abstract class GravarArquivo
    {
        public abstract void Gravar(List<Cliente> clientes, string nomeArquivo);
    }
}
