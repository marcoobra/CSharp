using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomcomportamento = true;
            string resultado = nota >= 7.0 && bomcomportamento 
                ? "aprovado" : "reprovado";
            // o ? siginifica se e o : significa senao, nesse caso a variavel nota recebe a partir da condicao
            Console.WriteLine(resultado);



        }
    }
}
