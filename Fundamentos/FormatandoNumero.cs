using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
   class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //valor
            Console.WriteLine(valor.ToString("C")); //valor em real
            Console.WriteLine(valor.ToString("P")); //percentual
            Console.WriteLine(valor.ToString("#.##"));//tipo decimal


            CultureInfo cultura = new CultureInfo("pt-BR");//real brasileiro
            Console.WriteLine(valor.ToString("C2", cultura)); //c2 padrao para valor em casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//preenche 0 a esquerda



        }
    }
}
