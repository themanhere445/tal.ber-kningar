using System;

namespace GissningsSpelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Slumptal mellan 1 och 100
            int attempts = 0;
            bool correct = false;

            Console.WriteLine("Välkommen till gissningsspelet! Gissa ett tal mellan 1 och 100.");

            while (!correct)
            {
                Console.Write("Din gissning: ");
                string input = Console.ReadLine();
                int guess;

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Ogiltig input. Ange ett heltal mellan 1 och 100.");
                    continue;
                }

                attempts++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Rätt tal! Det tog {attempts} försök.");
                    correct = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Gissningen är för låg.");
                }
                else
                {
                    Console.WriteLine("Gissningen är för hög.");
                }
            }

            Console.WriteLine("Tryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}