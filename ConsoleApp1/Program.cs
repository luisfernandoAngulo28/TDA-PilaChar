using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         public static void Main(string[] args)
        {
            clsPila P = new clsPila();
            String S = "{2*(4-5-{3*4-[4-5]}";

            /*
            P.Add('{');
            P.Add('(');
            P.Add('[');
            P.Add('A');
            System.Console.WriteLine(P.Imprimir());
                        System.Console.WriteLine(P.extraer(0));
                        System.Console.WriteLine(P.extraer(1));
                        System.Console.WriteLine(P.extraer(2));
                        System.Console.WriteLine(P.extraer(3));
            */
            if (P.balanceada(S))
            {
                System.Console.WriteLine("Esta correctamente balanceada");
            }
            else
            {
                System.Console.WriteLine("No esta correctamente balanceada");
            }
            
            System.Console.ReadKey();
        }
    }
}
