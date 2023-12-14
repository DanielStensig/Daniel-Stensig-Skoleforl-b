namespace BeerProject.Klasser
{
    public class Beer : IComparable<Beer> // Hvad gør det her
    {
        // Vores fields der gemmer info om øllerne
        private string _brewery;
        private string _beerName;
        private BeerTypeEnum _beerType;
        private int _volume;
        private decimal _percent;
        // Alle er private da de kun bruges herinde

        // Standard Constructor uden para
        public Beer()
        {

        }

        // Constructor, der initialisere felter, med para
        public Beer(string brewery, string beerName, BeerTypeEnum beerType, int volume, decimal percent)
        {
            _brewery = brewery;
            _beerName = beerName;
            _beerType = beerType;
            _volume = volume;
            _percent = percent;
        }

        // Properties som giver os adgang til de private fields
        public string Brewery
        {
            get { return _brewery; }
            set { _brewery = value; }
        }
        public string BeerName
        {
            get { return _beerName; }
            set { _beerName = value; }
        }
        public BeerTypeEnum BeerType
        {
            get { return _beerType; }
            set { _beerType = value; }
        }
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public decimal Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        // Udregner units
        public decimal GetUnits()
        {
            return _volume * _percent / 150;
        }

        // Hvordan det bliver udskrevet
        public override string ToString()
        {
            return $"{_brewery} - {_beerName} ({_beerType}): {_volume} cl, {_percent}%";
        }

        // Sammenligner to øller baseret på deres udregnede units.
        public int CompareTo(Beer other)
        {
            return GetUnits().CompareTo(other.GetUnits()); // Hvad gør det her
        }

        // Tilføjer og udregner
        public void Add(Beer other)
        {
            _volume += other._volume;
            _percent = (_volume * _percent + other._volume * other._percent) / _volume;
        }

        public Beer Mix(Beer other)
        {
            int mixedVolume = _volume + other._volume;
            decimal mixedPercent = (_volume * _percent + other._volume * other._percent) / mixedVolume;
            string mixedBrewery = $"{_brewery} and {other._brewery}";
            string mixedBeerName = $"{_beerName} and {other._beerName}";

            return new Beer(mixedBrewery, mixedBeerName, BeerTypeEnum.Mix, mixedVolume, mixedPercent);
        }

        public static Beer Mix(Beer beer1, Beer beer2)
        {
            return beer1.Mix(beer2);
        }
    }
}
