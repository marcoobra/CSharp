﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFOR
    {
        public static void Executar()
        {
            /* for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"o valor de i é {i}.");
             } */

            double somatorio = 0;
            string entrada;

            Console.WriteLine("informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("infomre a nota do aluno {0}"
                    , i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? 
                somatorio / tamanhoTurma : 0;
            Console.WriteLine("media da turma {0}", media);
            
        }
    }
}
