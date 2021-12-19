using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public char Sexo { get; set; }

        public Cliente(string nome, string sobrenome, int idade, char sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Sexo = sexo;
        }

    }
}
