namespace OOP_Spotifly.Classes
{
    internal class PlaylistAndAlbum : Stamp
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }
        public TimeSpan Time { get { return GetLength(); } set { } }

        public PlaylistAndAlbum(string title, List<Song> songs)
        {
            Title=title;
            Songs=songs;
        }

        private TimeSpan GetLength()
        {
            int length = 0; 
            foreach (var song in Songs) length += song.Length; 
            return TimeSpan.FromSeconds(length);
        }

        public override string ToString()
        {
            string s = $"Title: {Title}\nLength: {Time}\nSongs:\n";
            foreach (Song song in Songs) s += song.Title + "\n";
            return s; 
        }
    }
}
