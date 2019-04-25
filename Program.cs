using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pila con Generic?");
            Stopwatch tiempopasado = new Stopwatch();
            tiempopasado.Start();
            int numerospila = 100000;

            Stack<int> pila = new Stack<int>();

            for (int i = numerospila; i > 0; i--)
            {
                pila.Push(i);
                Console.WriteLine(i);
            }
            tiempopasado.Stop();

            Console.WriteLine("paso: "+tiempopasado.Elapsed);

            Console.ReadKey();
            //acá comienza el otro...

            Console.WriteLine("Pila con Objet?");
            Stopwatch nuevotiempo = new Stopwatch();
            nuevotiempo.Start();
            int numerosobj = 100000;

            Stack<object> gen = new Stack<object>();

            for (int i = numerosobj; i > 0; i--)
            {
                gen.Push(i);
                Console.WriteLine(i);
            }
            nuevotiempo.Stop();

            Console.WriteLine("paso: " + nuevotiempo.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("con generic: "+ tiempopasado.Elapsed);
            Console.WriteLine("");
            Console.WriteLine("con objet: "+ nuevotiempo.Elapsed);

        }
    }
}
