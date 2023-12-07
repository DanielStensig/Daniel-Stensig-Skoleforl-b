namespace OOP_Spotifly_School.Classes
{
    public abstract class Stamp
    {
        public string User { get; set; } = "Anonoymous";
        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
