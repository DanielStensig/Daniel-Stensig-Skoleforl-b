using BeerProject.Klasser;

namespace BeerProject
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Opretter øller
            Beer[] øller = new Beer[]
            {
            new Beer("PorterØller", "Porter", BeerTypeEnum.Porter, 200, 1.1m),
            new Beer("TyskeØller", "Munch", BeerTypeEnum.Münchener, 800, 2.2m),
            };

            // Mixer øllerne
            Beer beer1 = new Beer("TyskeØller2", "Wienerdortmunder", BeerTypeEnum.Wienerdortmunder, 100, 2.1m);
            Beer beer2 = new Beer("ØlMesteren", "Dobbelbock", BeerTypeEnum.Dobbelbock, 150, 3.3m);

            // Sortere øller
            Array.Sort(øller);

            // Udskriver øller
            Console.WriteLine("Sorteret efter antal genstande:");
            foreach (var beer in øller)
            {
                Console.WriteLine(beer);
            }

            Console.WriteLine("\nBlander to øller:");
            
            Thread.Sleep(1300);
            Console.Write(".");
            Thread.Sleep(1300);
            Console.Write(".");
            Thread.Sleep(1300);
            Console.Write(".\n");

            Console.WriteLine("Original Øl1: " + beer1);
            Console.WriteLine("Original Øl2: " + beer2);
            Thread.Sleep(1200);

            beer1.Add(beer2);
            Console.WriteLine("\nØl1 efter tilføjelse af Øl2: " + beer1);
            Beer blandetØl = beer1.Mix(beer2);
            Console.WriteLine("\nNyt Øl efter blanding af Øl1 og Øl2: " + blandetØl);
            Beer blandetØlStatisk = Beer.Mix(beer1, beer2);
            Console.WriteLine("Nyt Øl ved brug af statisk Mix-metode: " + blandetØlStatisk);
        }
    }
}