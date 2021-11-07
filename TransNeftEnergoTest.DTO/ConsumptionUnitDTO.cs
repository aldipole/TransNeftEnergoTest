using System.Collections.Generic;

namespace TransNeftEnergoTest.DTO
{
    public class ConsumptionUnitDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<MeasurementPointDTO> MeasurementPoints { get; set; }
        public IEnumerable<SupplyPointDTO> SupplyPoints { get; set; }

    }
}
