using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de var
            //Filme filme = new Filme();
            //acessar os campos do filme
            //filme.nome = "Procurando Nemo";
            //filme.Play();


            //usando static
            Filme.Pause();
            //Filme.plataforma = "Amazon Prime";


            //usando construtor
            Filme filme = new Filme("Madagascar", "Filme - infantil muito show", 2006, "DreamWorks");
            Filme CodigoMorse = new Filme("CodigoMorse", "Filme drama muito legal", 2, "ABK");

            /*
            Console.WriteLine(filme.nome);
            Console.WriteLine(filme.descricao);
            */


            Console.ReadLine();
        }
    }
}
