using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_2__POO____EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inverteTela();
            Area a;

            a = new Area();
            Console.WriteLine("Valor da base do triangulo?");
            a.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor altura do triangulo?");
            a.y = int.Parse(Console.ReadLine());

            a.setN1(a.x);

            a.setN2(a.y);

            a.calcular();

            Console.WriteLine("Área de um triangulo com base {0} é com uma altura {1} é {2}",
                a.getN1(), a.getN2(), a.getResultado());
        }

        static void inverteTela()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}

