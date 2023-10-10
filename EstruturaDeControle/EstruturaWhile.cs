using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
     class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;

            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentarivasrestantes = 5;
            int tentativas = 0;

            while(tentarivasrestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("insira seu palpite ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentarivasrestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("numero encontrado em {0} tentativas",
                        tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("menor ... tente denovo ");
                    Console.WriteLine("tentativas restantes",
                        tentarivasrestantes);
                }
                else {
                    Console.WriteLine("maior .. tenta novamente");
                    Console.WriteLine("tentativas restantes {0}",
                        tentarivasrestantes);
                }
            }

        }
    }
}
