using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
     class Switch
    {
        public static void Executar()
        {
            Console.WriteLine("Avale meu atendimento com uma nota de 1 a 5:  ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                     Console.WriteLine("pessimo");
                    break;
                case 1:
                case 2:
                     Console.WriteLine("ruim ");
                    break ;
                case 3:
                     Console.WriteLine("regular ");
                    break;
                case 4:
                    Console.WriteLine("bom ");
                    break;
                case 5:
                    Console.WriteLine("otimo parabens ");
                    break;
                default:
                    Console.WriteLine("nota invalida");
                    break;
            }
                    Console.WriteLine("FIM");
        }
    }
}
