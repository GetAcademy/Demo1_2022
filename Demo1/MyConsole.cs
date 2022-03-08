using System;

namespace Demo1
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question);
            Console.Write("? ");
            return Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }

        public static bool? AskBool(string question)
        {
            var answer = Ask(question + " (j/n)").ToLower();
            return 
                answer == "j" ? true :
                answer == "n" ? false :
                null;
            //if (answer == "j") return true;
            //if (answer == "n") return false;
            //return null;
        }
    }
}
