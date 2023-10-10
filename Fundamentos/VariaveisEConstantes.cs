using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine( area );
            Console.WriteLine("Area é " + (area + 1000));

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("populacao brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("preco computador " + precoComputador);

            double valorDeMercadoApple = 1000000000000.00;
            Console.WriteLine("apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("distacia entre estrela " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = "seja bem vindo ao curso de c#";
            Console.WriteLine(texto);
        }
    }
}
