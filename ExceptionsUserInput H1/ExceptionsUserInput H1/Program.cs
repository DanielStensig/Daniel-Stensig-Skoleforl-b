using ExceptionsUserInput_H1.Classes;
namespace ExceptionsUserInput_H1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            int tal5 = methods.GetIntFromUserException("Indtast venligst et heltal:");
            Console.WriteLine("Tak for det. Der blev tastet " + tal5);

            int tal6 = methods.GetIntFromUserTryParse("Indtast venligst et heltal:");
            Console.WriteLine("Tak for det. Der blev tastet " + tal6);
            Console.ReadLine();
        }
    }
}