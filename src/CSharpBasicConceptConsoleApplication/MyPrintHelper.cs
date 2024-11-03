using System;

namespace BasicConceptCSharpConsoleApplication
{
    public class MyPrintHelper
    {
        public static void PrintBorder()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************************************");
            Console.ResetColor();
        }

        public static void PrintPointsToRememberMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************Points To Remember: ***************");
            Console.ResetColor();
        }

        public static void PrintEndMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************END***********************");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void PrintNoteConcept(string message = "Please look into the code to get the concepts.")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNote: " + message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void PrintHeaderMessage(string header)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##########" + header + ":##########");
            Console.ResetColor();
        }
    }
}
