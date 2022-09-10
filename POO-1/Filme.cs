using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Filme
    {
        //atributos
        public string nome;
        public string descricao;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();

        static public string plataforma = "NETFLIX";

        //metodos
        public void Play()
        {
            Console.WriteLine($"Rodando o filme: {nome}");
        }

        //utilizando static
        static public void Pause()
        {
            Console.WriteLine(plataforma);
            Console.WriteLine("||");
        }

        //construtor
        public Filme(string nome, string descricao, int ano, string studio)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.ano = ano;
            this.studio = studio;

            Console.WriteLine("Deu certo\n");
        }
    }
}
