using System;

namespace FizzBuzz.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(Translator.Translate(i));
            }

            Pause();
        }

        public static void Pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
