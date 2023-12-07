namespace OOP_Spotifly_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.AddSong();
            foreach (var song in Data.Songs)
            {
                Console.WriteLine($"\n{song}");
            }

        }
    }
}