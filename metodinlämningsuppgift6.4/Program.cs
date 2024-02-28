using System;
namespace potensprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket tal vill du ha som grund?");
            int grund = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilket tal vill du ha som potens?");
            int potens = int.Parse(Console.ReadLine());
            potenser(grund, potens);
        }

        static void potenser(int grund, int potens)
        {
            Console.WriteLine("Kommit");
            int svar = grund;
            for(int i = 1; i < potens; i++)
            {
                svar = svar * grund;
            }
            Console.WriteLine("Svaret blir " + svar);
        }
    }
}