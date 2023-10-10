using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola ".ToUpper().Insert(3, " World")
                .Replace(" world", " mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("teste ".Length);

         
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
