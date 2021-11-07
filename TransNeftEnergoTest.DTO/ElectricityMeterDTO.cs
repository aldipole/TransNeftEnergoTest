using System;

namespace TransNeftEnergoTest.DTO
{
    public class ElectricityMeterDTO
    {
        public int? ID { get; set; }
        public int Type { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
