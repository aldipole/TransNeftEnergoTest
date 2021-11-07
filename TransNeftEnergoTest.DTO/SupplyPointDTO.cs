using System;

namespace TransNeftEnergoTest.DTO
{
    public class SupplyPointDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public int ConsumptionUnitID { get; set; }
        public AccountingDeviceDTO AccountingDevice { get; set; }
    }
}
