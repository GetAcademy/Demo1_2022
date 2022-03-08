using System;
using HokusPokus;

namespace Demo1
{
    internal class Program
    {
        /*
         *  - grunnleggende input og output
         *  - konvertering
         *  
         */
        static void Main(string[] args)
        {
            //Console.Write("Hva heter du? ");
            //var name = Console.ReadLine();
            var name = MyConsole.Ask("Hva heter du");
            Console.WriteLine($"Hei, {name}!");
            var year = MyConsole.AskInt("I hvilket år ble du født");
            var age = DateTime.Today.Year - year;
            bool? hadBirthday = null;
            while (hadBirthday == null)
            {
                hadBirthday = MyConsole.AskBool("Har du hatt bursdag i år");
            }
            if (!hadBirthday.Value) age--;
            Console.WriteLine($"Du er {age} år gammel.");
            /*
            Demo1(args);
            Demo2();
            */
        }

        private static void Demo2()
        {
            var a = 5;
            var b = 10;
            var sum1 = Calc.GetSum(a, b);
            var sum2 = Calc.GetSum(55, 66);
            var sum3 = Calc.GetSum(77, 88);
            var sum4 = Calc.GetSum(1, 2);

            var someNumber = a * 2 + b - 100;
            var x1 = 2 * someNumber;
            var x2 = 3 * someNumber;
            var x3 = 5 * someNumber;
            var x4 = 7 * someNumber;

            int aa = 65;
            char c = (char)aa;
            Console.WriteLine(c);


            bool b1 = true;
            bool b2 = false;

            bool? bb1 = true;
            bool? bb2 = false;
            bool? bb3 = null;
        }

        private static void Demo1(string[] args)
        {
            /*
                - dele opp i metoder, reshaper
                - klasse
                - namespace og using
                - github
            */

            // verdityper
            bool b = true;
            float ff = 1f;
            float f = 5.5f;
            double d = 5.5;
            decimal dd = 1000.7m;
            int j = 5;
            char c = 'a';

            // referansetype
            string s = "hello";

            Console.WriteLine(args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Indeks {i} inneholder: {args[i]}");
            }
        }
    }
}
