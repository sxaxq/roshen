using System;

namespace sxsxasx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            RenderUkraineFlag();
            Console.ReadKey();
        }

        static void RenderUkraineFlag()
        {
            for (int i = 0; i <= 10000; i++)
            {
                if (i < 5000)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("=");
                    Console.ResetColor();
                }
                else if (i >= 5000)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("=");
                    Console.ResetColor();
                }
            }
        }
    }
}
