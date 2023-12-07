namespace OOP_Spotifly.Classes
{
    internal class Song : Stamp
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Artist> Artists { get; set;}

        public override string ToString()
        {
            return $"Title: {Title}\nGenre: {Genre}\nLength: {GetTimeFromSeconds()}\nArtists: {ShowArtists()}\n";
        }
        private string ShowArtists()
        {
            string s = "";
            foreach (Artist artist in Artists)
            {
                s += artist; //.ToString();
            }
            return s; 
        }
        private TimeSpan GetTimeFromSeconds()
        {
            return TimeSpan.FromSeconds(Length);
        }
    }
}
