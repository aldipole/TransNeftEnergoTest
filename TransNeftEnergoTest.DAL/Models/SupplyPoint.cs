using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Точка поставки электроэнергии
    /// </summary>
    [Table("SuplyPoints")]
    public class SupplyPoint
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public double MaxPower { set; get; }
        public int ConsumptionUnitID { get; set; }
        public virtual ConsumptionUnit ConsumptionUnit { get; set; }

        public virtual AccountingDevice AccountingDevice { get; set; }
    }
}
