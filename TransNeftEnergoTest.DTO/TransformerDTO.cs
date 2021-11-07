using System;

namespace TransNeftEnergoTest.DTO
{
    public class TransformerDTO
    {
        public int? ID { get; set; }
        public int Type { get; set; }
        public DateTime ExpiredAt { get; set; }
        public double TransformationRatio { get; set; }
    }
}
