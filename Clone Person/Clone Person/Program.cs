using Clone_Person.Classes;

namespace Clone_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Daniel Stensig", 180, 75);
            Person p2 = p1;

            Console.WriteLine("Er det det samme: " + ReferenceEquals(p1, p2));
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p1.Height = 100;
            Console.WriteLine("Er det det samme: " + ReferenceEquals(p1, p2));
        }
    }
}