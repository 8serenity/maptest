using System;

namespace maptest
{
    public class GPSDevice
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public double XPoint { get; set; }
        public double YPoint { get; set; }
        public double CurrentSpeed { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}