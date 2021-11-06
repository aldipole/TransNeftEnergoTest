using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Точка измерения электроэнергии
    /// </summary>
    [Table("MeasurementPoints")]
    public class MeasurementPoint
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int ConsumptionUnitID { get; set; }
        public virtual ConsumptionUnit ConsumptionUnit { get; set; }
        public virtual ElectricityMeter ElectricityMeter { set; get; }
        public virtual CurrentTransformer CurrentTransformer { set; get; }
        public virtual VoltageTransformer VoltageTransformer { set; get; }
        public virtual MeasurementPointToAccountingDevice MeasurementPointToAccountingDevice { get; set; }
    }
}
