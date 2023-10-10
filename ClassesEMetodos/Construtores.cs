using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricantes;
        public int Ano;

        public Carro(string modelo, string fabricantes, int ano)
        {
            Modelo = modelo;
            Fabricantes = fabricantes;
            Ano = ano;
        }
    }

    class Construtores
    {
       public static void Executar()
        {
            /*var carro1 = new Carro();
            carro1.Fabricantes = "bmw";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricantes}" +
                $" {carro1.Modelo}{carro1.Ano}");

            var carro2 = new Carro("ka", "ford", 2018);
            Console.WriteLine(
                $"{carro2.Fabricantes}{carro2.Modelo}{carro2.Ano}");*/
        }
    }
}
