using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
     class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "opa! ";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);

            }
        }
    }
}
