using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
     class estruturaIFElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if( nota >= 7.0) 
            {
                Console.WriteLine("Aprovado! ");
                Console.WriteLine("não fez mais que a obrigação ...");

            }
            else
            {
                Console.WriteLine("ficou de recuperação ");
            }


        }
    }
}
