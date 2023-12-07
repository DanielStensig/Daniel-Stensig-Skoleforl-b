namespace OOP_Spotifly_School.Classes
{
    internal class Data
    {
        public static List<Song> Songs { get; set; } = new List<Song>();
        public static List<Artist> Artists { get; set; } = new List<Artist>();
        public static List<PlaylistAndAlbum> Playlists { get; set; } = new List<PlaylistAndAlbum>();

        public static void AddSong()
        {
            Console.WriteLine("Enter song details");
            Console.Write("Title: ");
            string songTitle = Console.ReadLine();
            Console.Write("Genre: ");
            string songGenre = Console.ReadLine();
            Console.Write("Artist: ");
            string songArtist = Console.ReadLine();
            Console.Write("Length in seconds: ");
            string songLength = "";
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                List<Artist> aList = new List<Artist>();
                aList.Add(new Artist { ArtistName = songArtist });

                Song newSong = new Song()
                {
                    Title = songTitle,
                    Genre = songGenre,
                    Artists = aList,
                    Length = length
                };
                Songs.Add(newSong);

                Console.WriteLine("Song was added!");

            }
            else
            {
                Console.WriteLine("Invalid input for song length. Please enter a valid number.");
            }
        }
    }
}
