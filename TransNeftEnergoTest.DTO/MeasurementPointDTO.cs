using System;

namespace TransNeftEnergoTest.DTO
{
    public class MeasurementPointDTO
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int ConsumptionUnitID { get; set; }
        public ElectricityMeterDTO ElectricityMeter { get; set; }
        public TransformerDTO CurrentTransformer { get; set; }
        public TransformerDTO VoltageTransformer { get; set; }
    }
}
