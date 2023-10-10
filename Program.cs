using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos ", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos ", VariaveisEConstantes.Executar },
                {"Interferencia - Fundamentos ", Inferencia.Executar },
                {"Interpolacao - Fundamentos ", Interpolacao.Executar },
                {"Notacao Ponto - Fundamentos ", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos ", LendoDados.Executar },
                {"Formantando Numeros - Fundamentos ", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos ", Conversoes.Executar },
                {"Operador Ternario - Fundamentos ", OperadorTernario.Executar },
               
                //Estrutura De Controle
                {"Estrutura IF - Estrutura De Controle ", EstruturaIF.Executar },
                {"Estrutura IF ELSE - Estrutura De Controle ", estruturaIFElse.Executar },
                {"Estrutura IF /ELSE /IF - Estrutura De Controle ", EstruturaIFElseIF.Executar },
                {"Estrutura Switch - Estrutura De Controle ", Switch.Executar },
                {"Estrutura While - Estrutura De Controle ", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura De Controle ", EstruturaDoWhile.Executar },
                {"Estrutura FOR - Estrutura De Controle ", EstruturaFOR.Executar },
                {"Estrutura FOREACH - Estrutura De Controle ", EstruturaForeach.Executar },
                {"Estrutura Break - Estrutura De Controle ", UsandoBreak.Executar },
                {"Estrutura Continue - Estrutura De Controle ", EstruturaContinue.Executar },

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}