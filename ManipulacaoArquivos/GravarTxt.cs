using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    class GravarTxt : GravarArquivo
    {
        public override void Gravar(List<Cliente> clientes, string nomeArquivo)
        {
            using (StreamWriter arquivo = new StreamWriter(nomeArquivo, false, Encoding.UTF8))
            {
                foreach (Cliente cliente in clientes)
                {
                    arquivo.WriteLine(
                        RetornaTexto(cliente.Nome) +
                        RetornaTexto(cliente.Sobrenome) +
                        RetornaTexto(cliente.Idade.ToString()) +
                        RetornaTexto(cliente.Sexo.ToString())
                        );
                }
            }
        }

        private string RetornaTexto(string texto)
        {
            int qtdLetras = texto.Length;
            string textoCorrigido = texto;
            int espaco = 20;

            for (int i = qtdLetras; i <= espaco; i++)
            {
                textoCorrigido += " ";
            }

            return textoCorrigido;
        }
    }
}
