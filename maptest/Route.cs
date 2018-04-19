namespace maptest
{
    public class Route
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public string SenderAddress { get; set; }
        public string RecepientAddress { get; set; }
        public MarkerMap CurrentMarker { get; set; }
        public double CurrentSpeed { get; set; }
        public double EstimatedTime { get; set; }
        public double TotalDistance { get; set; }
    }
}