public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE

    public Feature[] Features { get; set; } = null!;
    public class Feature
    {
        public string Type { get; set; } = null!;
        public Properties Properties { get; set; } = null!;
    }
    public class Properties
    {
        public double Mag { get; set; }
        public string Place { get; set; } = null!;
        public long Time { get; set; }
    }

}

