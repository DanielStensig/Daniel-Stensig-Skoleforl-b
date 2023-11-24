namespace H1_Afslut_Lommeregner
{
    internal class Program
    {
        // Jeg vil lige lægge ud med at sige undskyld for de dårlige variable navne, især dem på dansk, 
        // men da jeg næsten var færdig da jeg ville rette dem og det ville tage for lang tid, 
        // så lader jeg dem bare stå som de er

        static void Main(string[] args)
        {
            // This is the start of our code, so basically it executes the calculator
            do
            {
                Start();
            } while (true);
        }

        /// <summary>
        /// In the start method we print the text onto the console, and directs it to the input method
        /// </summary>
        static void Start()
        {
            Console.WriteLine("Useable characters: + - * /");
            Console.Write("Write your equation here: ");
            Input(out string? userChoice);
        }

        /// <summary>
        /// In this method we take the input, check if its longer than 3
        /// since we need atleast 2 numbers and one character for it to work
        /// </summary>
        /// <param name="userChoice">This has been used to collect users input so we can use it in other methods too</param>
        static void Input(out string? userChoice)
        {
            userChoice = Console.ReadLine();

            if (userChoice?.Length >= 3)
            {
                InputCheck(userChoice, out double tal1, out double tal2);
            }
            else 
            {
                Console.Write("\nPrøv igen: ");
            }
        }

        /// <summary>
        /// Basically what we do here, is checking if the script meets the requirements there is to start calculating
        /// if not, it will send them back to the start
        /// </summary>
        /// <param name="userChoice">Here we use the userChoice to check if it contains the characters needed</param>
        /// <param name="tal1">The first number/the number from splitter[0] is stored here</param>
        /// <param name="tal2">The second number/the number from splitter[1] is stored here</param>
        static void InputCheck(string userChoice, out double tal1, out double tal2)
        {
            tal1 = 0;
            tal2 = 0;
            string[] splitter;

            if (userChoice.Contains('+'))
            {
                splitter = userChoice.Split('+');
            }
            else if (userChoice.Contains("-"))
            {
                splitter = userChoice.Split('-');
            }
            else if (userChoice.Contains("*"))
            {
                splitter = userChoice.Split('*');
            }
            else if (userChoice.Contains('/'))
            {
                splitter = userChoice.Split('/');
            }
            else
            {
                Console.WriteLine("Your input was incorrect, try again!\n");
                return; // Exits the method if the input was incorrect 
            }

            // Checks if we can parse it into an integer, and then parses if we can
            if (splitter.Length == 2 && double.TryParse(splitter[0], out tal1) && double.TryParse(splitter[1], out tal2))
            {
                double resultat;
                if (userChoice.Contains('+'))
                {
                    Addition(tal1, tal2, out resultat);
                }
                else if (userChoice.Contains("-"))
                {
                    Subtraktion(tal1, tal2, out resultat);
                }
                else if (userChoice.Contains("*"))
                {
                    Multiplikation(tal1, tal2, out resultat);
                }
                else if (userChoice.Contains('/'))
                {
                    Division(tal1, tal2, out resultat);
                }
                else
                {
                    Console.WriteLine("Your input was incorrect, try again!\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter two valid integers.\n");
            }
        }

        /// <summary>
        /// The parameters says itself, and this is just where we calculate and print answer
        /// </summary>
        static void Addition(double tal1, double tal2, out double resultat)
        {
            resultat = tal1 + tal2;
            Console.WriteLine($"{resultat}\n");
            Banan(resultat);
        }

        /// <summary>
        /// The parameters says itself, and this is just where we calculate and print answer
        /// </summary>
        static void Subtraktion(double tal1, double tal2, out double resultat)
        {
            resultat = tal1 - tal2;
            Console.WriteLine($"{resultat}\n");
            Banan(resultat);
        }

        /// <summary>
        /// The parameters says itself, and this is just where we calculate and print answer
        /// </summary>
        static void Multiplikation(double tal1, double tal2, out double resultat)
        {
            resultat = tal1 * tal2;
            Console.WriteLine($"{resultat}\n");
            Banan(resultat);
        }

        /// <summary>
        /// The parameters says itself, and this is just where we calculate and print answer
        /// </summary>
        static void Division(double tal1, double tal2, out double resultat)
        {
            resultat = tal1 / tal2;
            Console.WriteLine($"{resultat:F9}\n"); // F9 was mainly just to show what I know
            Banan(resultat);
        }

        /// <summary>
        /// Calculates your result in cm into bananas if we asume a banana is 18.5 CM long. 
        /// </summary>
        static void Banan(double resultat)
        {
            Console.Write("Do you want to calculate into bananas(y/n): ");
            string? bananaAnswer = Console.ReadLine().ToLower();

            if (bananaAnswer == "y") // We dont need any more than this. If they choose n or choose not to answer,
            {                        // it will automatically go to else
                double banan = resultat / 18.5;
                Console.WriteLine($"Du kan få cirka {banan:F1} ud af {resultat}CM\n");
            }
            else
            {
                Console.WriteLine("There was no input!\n");
            }

        }
    }
}