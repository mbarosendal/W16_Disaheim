namespace Disaheim
{
    public enum Level
    {
        low,
        medium,
        high
    }

    public class Amulet : Merchandise
    {
        private string _design;
        private Level _quality;
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;

        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        // Constructor with itemId parameter
        public Amulet(string itemId)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
        }

        // Constructor with itemId and quality parameters
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Quality = quality;
        }

        // Constructor with itemId, quality, and design parameters
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Quality = quality;
            Design = design;
        }

        public override double GetValue()
        {
            double value = 0.0;

            switch (this.Quality)
            {
                case Level.low:
                    value = 12.5;
                    break;
                case Level.medium:
                    value = 20.0;
                    break;
                case Level.high:
                    value = 27.5;
                    break;
                default:
                    Console.WriteLine("Invalid quality specified for the amulet.");
                    break;
            }
            return value;
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
