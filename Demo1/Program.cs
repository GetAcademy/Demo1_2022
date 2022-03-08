using System;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Pause til 10:35
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
