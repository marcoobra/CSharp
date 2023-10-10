using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomcomportamento = false;
            string entrada;

            Console.WriteLine("digite a nota do aluno");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            Console.WriteLine("possui bom comportamento (S/N):");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada == "s")
                bomcomportamento = true;


            if(nota >= 9.0 && bomcomportamento)
            {
                Console.WriteLine("quadro de honra! ");
            }
        }
    }
}
