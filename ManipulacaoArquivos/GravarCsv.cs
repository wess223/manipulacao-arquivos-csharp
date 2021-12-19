using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    class GravarCsv : GravarArquivo
    {
        public override void Gravar(List<Cliente> clientes, string nomeArquivo)
        {
            using (StreamWriter arquivo = new StreamWriter(nomeArquivo, false, Encoding.UTF8))
            {
                foreach (Cliente cliente in clientes)
                {
                    arquivo.WriteLine($"{cliente.Nome};{cliente.Sobrenome};{cliente.Idade};{cliente.Sexo}");
                }
            }
        }
    }
}
