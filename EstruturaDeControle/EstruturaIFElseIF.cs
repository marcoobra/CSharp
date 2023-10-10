using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIFElseIF
    {
        public static void Executar()
        {
            Console.Write("digita a nota do aluno -  ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

           if (nota >= 9.0)
            {
                Console.WriteLine("quadro de honra! ");
            }
           else if (nota >= 7.0 && nota < 9.0)
            {
                Console.WriteLine("Aprovado! ");
            }
           else if (nota >= 5.0 && nota < 7.0)
            {
                Console.WriteLine("recuperação ");
            }
           else 
            {
                Console.WriteLine("reprovado ");
            }
            Console.WriteLine("FIM!  ... ");
        }
    }
}
