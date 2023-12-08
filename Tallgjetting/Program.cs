using System;

class Tallgjetting
{
    private int correctNumber;

    public void RunGame()
    {
        generateNumber();

        while (true)
        {
            start();
            Console.WriteLine("Vil du spille igjen? (skriv inn enten ja eller nei)");
            string playAgain = Console.ReadLine().ToLower();

            if (playAgain != "ja")
                break;

            generateNumber();
        }
    }

    private void generateNumber()
    {
        Random number = new Random();
        correctNumber = number.Next(0, 20);
    }

    private void start()
    {
        var input = Console.ReadLine();

        if (int.TryParse(input, out int guess))
        {
            if (guess < correctNumber)
            {
                Console.WriteLine("Du valgte for lavt tall");
            }
            else if (guess > correctNumber)
            {
                Console.WriteLine("Du valgte for høyt tall");
            }
            else
            {
                Console.WriteLine("Wohoo! Du gjettet riktig tall.");
            }
        }
        else
        {
            Console.WriteLine("Ugyldig tall. Vennligst skriv inn et heltall.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tallgjetting game = new Tallgjetting();
        game.RunGame();
    }
}
