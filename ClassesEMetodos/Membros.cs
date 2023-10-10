using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Marcos";
            sicrano.Idade = 23;

            int a = 2;

           /* Console.WriteLine($"{sicrano.Nome} tem" +
                $" {sicrano.Idade} anos"); 
           */
         

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();


            if (sicrano.Idade == 0) 
                {
                    Console.WriteLine("dados invalidos");
                }
            
            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Rael";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
        }

    }
}
