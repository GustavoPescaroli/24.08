using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_2__POO____EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area a;
            a = new area();
            inverteTela();
            Console.WriteLine("Informe o Valor da Aresta do Quadrado?");
            a.x = int.Parse(Console.ReadLine());


            a.setN1(a.x);

            a.calcular();

            Console.WriteLine("Área do Quadrado com Aresta {0} é de {1}",
                a.getN1(), a.getResultado());
        }

        static void inverteTela()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}

