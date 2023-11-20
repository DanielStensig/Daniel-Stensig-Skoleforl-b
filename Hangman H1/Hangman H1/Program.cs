Main();
static void Main()
{
    string randomWord = "";
    RandomArray(out randomWord);
    Console.WriteLine("Random word: " + randomWord);

    while (true)
    {
        GuessMethod(randomWord);
    }

}
static void RandomArray(out string randomWord)
{
    string[] RandomWords = new string[] { "KILLING", "HVALP", "HAMSTER", "KANIN" };

    Random random = new Random(); // Her laver jeg en ny random

    int randomIndex = random.Next(RandomWords.Length); // Laver et random index i dette arrays bounds

    randomWord = RandomWords[randomIndex]; // Vælger 1 random ord
}
static void GuessMethod(string randomWord)
{
    string guess;

    Console.Write("\nIndtast dit gæt: ");
    guess = Console.ReadLine().ToUpper();

    if (guess.Length == 1 && char.IsLetter(guess[0]))
    {

        if (randomWord.Contains(guess))
        {
            char[] showWord = new char[randomWord.Length];

            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == guess[0])
                {
                    showWord[i] = guess[0];
                }
                else if (char.IsLetter(showWord[i]))
                {
                    continue;
                }
                else
                {
                    showWord[i] = '_';
                }
            }
            Console.WriteLine("Ordet: " + new string(showWord));
        }
        else
        {
            Console.WriteLine("Forkert");
        }
    }
    else
    {
        Console.WriteLine("Du må kun indtaste 1 BOGSTAV af gangen: ");
        Console.ReadKey();
    }
}