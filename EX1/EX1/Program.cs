using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_2__POO____EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inverteTela();
            soma s;
            //s = new Soma();
            s = new soma();
            Console.WriteLine("Informe o Valor da Aresta do Quadrado meu nobre:");
            s.x = int.Parse(Console.ReadLine());


            s.setN1(s.x);

            s.calcular();

            Console.WriteLine("Área de um quadrado com aresta {0} é de {1}",
                s.getN1(), s.getResultado());
        }

        static void inverteTela()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}

