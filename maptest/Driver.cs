using System.Collections.Generic;

namespace maptest
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public double Rating { get; set; }
        ICollection<Car> Cars { get; set; }
    }
}