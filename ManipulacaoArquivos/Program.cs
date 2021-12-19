using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    class Program
    {
        static string caminhoRaiz = @"C:\Users\SrWesley\Desktop\Exem";

        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("HEMERSON", "LIMA", 25, 'M'));
            clientes.Add(new Cliente("BRUNO", "AMARAL", 25, 'M'));
            clientes.Add(new Cliente("MARCOS", "RIBEIRO", 25, 'M'));
            clientes.Add(new Cliente("LUAN", "SILVA", 25, 'M'));
            clientes.Add(new Cliente("KUAN", "SOUZA", 25, 'M'));
            clientes.Add(new Cliente("GABRIEL", "ALVES", 25, 'M'));


            GravarCsv gravarCsv = new GravarCsv();
            GravarTxt gravarTxt = new GravarTxt();

            gravarCsv.Gravar(clientes, caminhoRaiz+@"\arquivo.csv");
            gravarTxt.Gravar(clientes, caminhoRaiz+@"\arquivo.txt");

        }
    }
}
