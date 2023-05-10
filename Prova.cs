﻿using System;
using System.Collections.Generic;
using System.Linq;
using static Informática.Ferramentas;

namespace Informática
{
    internal class Prova
    {
        public static void Main()
        {
            var letras = new List<Alternativa>
            {
                new Alternativa("a"),
                new Alternativa("b"),
                new Alternativa("c"),
                new Alternativa("d"),
                new Alternativa("e"),
            };

            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                ColorLine("Questões de Informática – Nível Médio\n", ConsoleColor.White);

                Console.WriteLine("\nDigite seu nome, press Enter e vamos começar!!");
                ColorLine("NOME:", ConsoleColor.DarkRed);

                string nome = Console.ReadLine();
                Console.WriteLine($"\n\nOlá {nome}, prepare-se com questões de Informática, leia-as com atenção e digite no campo \"R:\" a letra referente a alternativa correta, Boa Sorte!!\n\n");
                var resp1 = "";
                var resp2 = "";
                var resp3 = "";
                var resp4 = "";
                var resp5 = "";
                var resp6 = "";
                var resp7 = "";
                var resp8 = "";
                var resp9 = "";
                var resp10 = "";
                Console.WriteLine("01) No Microsoft Office Excel, a função =SOMA(A5:A7) retornará o somatório da(s):\n");
                Console.Write("A)Linhas 5, 6 e 7.\nB)Linhas 5 e 7.\nC)Coluna A\nD)Células A5 e A7.\nE)Células A5, A6 e A7.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp1 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp1.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n02) Nos sistemas Linux, existe um comando que é utilizado para mostrar o espaço ocupado por arquivos e subdiretórios do diretório atual. Trata-se do comando:\r\n");
                Console.Write("A)df.\nB)du.\nC)free.\nD)grep.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp2 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp2.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n03) Ainda em relação ao Microsoft Excel versão 2007, padrão Português Brasil, configuração original, qual a função utilizada para extrair os caracteres do meio de uma sequência de caracteres de texto, tendo a posição e o comprimento especificados?\n");
                Console.Write("A)CONCATENAR\nB)LOCALIZAR\nC)EXT.TEXTO\nD)NUN.CARACTER\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp3 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp3.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n04) Assinale a alternativa correta, selecionando a opção que mostra a equivalência entre Petabyte(PiB) e Bytes(B).\n");
                Console.Write("A)1.000.000.000 B.\nB)1010 B.\nC)1015 B.\nD)1.000.000.000.000 B.\nE)102 B.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp4 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp4.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n05) Quais as três partes que compõem um sistema computacional?\n");
                Console.Write("A)Hardware, Software, Peopleware.\nB)Hardware, Software, Middleware.\nC)Software, Peopleware, Middleware.\nD)Hardware, Peopleware, Middleware.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp5 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp5.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n06) Assinale a alternativa incorreta a cerca dos princípios da tecnologia da informação.\n");
                Console.Write("A)Token – é o princípio que garante o tráfego das informações de forma segura.\nB)Confidencialidade - Garantir que a informação só será acessível por pessoas autorizadas.\nC)Integridade - Garante que o conteúdo da mensagem não foi alterado ou violado indevidamente.\nD)Disponibilidade - Garante que uma informação estará disponível para acesso no momento desejado.\nE)Autenticidade - Garante a identidade de quem está enviando a informação, ou seja, gera o não-repúdio que se dá quando há garantia de que o emissor não poderá se esquivar da autoria da mensagem (irretratabilidade).\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp6 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp6.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n07) Para fixar ou desafixar a Faixa de Opções, onde estão localizadas Guias, Grupos e Botões do Microsoft Word 2013, Configuração Local, Idioma Português-Brasil, pode ser utilizada a tecla CTRL, em conjunto com uma das teclas de função; assinale-a.\n");
                Console.Write("a)F1\nB)F3\nC)F5\nD)F7\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp7 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp7.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n08) No Microsoft Excel, o comando de atalho CONTAR.VAL serve para...\n");
                Console.Write("A)Contar células que contenham qualquer tipo de informações, incluindo valores de erro e texto vazio.\nB)Saber quantos caracteres estão na célula.\nC)Calcular a média de valores somados entre eles.\nD)Copiar texto do Word para Excel.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp8 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp8.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n09) Em relação aos Editores de Texto do Pacote Microsoft Office, analise as afirmativas abaixo e dê valores Verdadeiro (V) ou Falso (F).");
                Console.WriteLine("\nI. Um dos editores de texto compatível com o Sistema Operacional Windows é o Word.\n\nI I . No editor de texto do Pacote Microsoft Office não é possível incluir uma tabela.\n\nI I I . É possível colocar as palavras em Negrito, Itálico e/ou Sublinhado.\n");
                Console.WriteLine("Assinale a alternativa que apresenta a sequência correta de cima para baixo.\n");
                Console.Write("A)V, F, F\nB)V, F, V\nC)F, V, V\nD)V, V, F\nE)F, F, V\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp9 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp9.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E."); break; }

                Console.WriteLine("\n10) Equipamentos como switches, hubs, bridges e roteadores são usados para interconectar computadores e criar o que chamamos de rede de computadores. A cerca desses equipamentos, assinale a alternativa incorreta.\n");
                Console.Write("A)Switches criam uma espécie de canal de comunicação exclusiva entre o computador de origem e o de destino.\nB)Roteadores são equipamentos que ficam na extremidade de duas ou mais redes de computadores e só se conectam a outros roteadores através da internet.\nC)Hubs são equipamentos para conectar vários computadores, mas sua forma de retransmitir a informação, que chega em uma de suas portas para todas os computadores conectados a ele, potencializa problemas como LOOPS.\nD)Bridges são equipamentos que podem ser usados para interligar uma rede cabeada e uma rede sem-fio.\nE)Existem switches gerenciáveis, nesse tipo de equipamento podemos realizar configurações para prevenir lopp’s na rede.\n");
                ColorLine("R:", ConsoleColor.DarkGreen);
                resp10 = Console.ReadLine();
                if (letras.Any(item => item.Letra == resp10.ToLower()))
                {
                    entradaValida = true;
                }
                else { Console.WriteLine("\nResposta inválida, tente novamente e digite apenas alternativas: A,B,C,D,E.\n\n"); break; }

                ColorLine($"\nParabéns {nome}, teste finalizado, press Enter para calcularmos o seu resultado!\n\n\n", ConsoleColor.DarkYellow);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string espaço = new string(' ', 5);
                Console.WriteLine($"QUESTÃO{espaço}GABARITO{espaço}   R:\n");
                var av1 = "E";
                var av2 = "B";
                var av3 = "C";
                var av4 = "C";
                var av5 = "A";
                var av6 = "A";
                var av7 = "A";
                var av8 = "A";
                var av9 = "B";
                var av10 = "B";
                int i = 0;
                Console.Write($"Questão 01){espaço}{av1}{espaço}-{espaço}{resp1}{espaço}=  ");
                if (av1 == resp1.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 02){espaço}{av2}{espaço}-{espaço}{resp2}{espaço}=  ");
                if (av2 == resp2.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 03){espaço}{av3}{espaço}-{espaço}{resp3}{espaço}=  ");
                if (av3 == resp3.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 04){espaço}{av4}{espaço}-{espaço}{resp4}{espaço}=  ");
                if (av4 == resp4.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 05){espaço}{av5}{espaço}-{espaço}{resp5}{espaço}=  ");
                if (av5 == resp5.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 06){espaço}{av6}{espaço}-{espaço}{resp6}{espaço}=  ");
                if (av6 == resp6.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 07){espaço}{av7}{espaço}-{espaço}{resp7}{espaço}=  ");
                if (av7 == resp7.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 08){espaço}{av8}{espaço}-{espaço}{resp8}{espaço}=  ");
                if (av8 == resp8.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 09){espaço}{av9}{espaço}-{espaço}{resp9}{espaço}=  ");
                if (av9 == resp9.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                Console.Write($"Questão 10){espaço}{av10}{espaço}-{espaço}{resp10}{espaço}=  ");
                if (av10 == resp10.ToUpper()) { Console.WriteLine("CORRETO(+1)"); i++; }
                else { Console.WriteLine("INCORRETO(0)"); }

                ColorLine($"\nNOTA: {i}\n\n", ConsoleColor.DarkCyan);              
            }

            Console.ReadKey();


        }
    }
}
