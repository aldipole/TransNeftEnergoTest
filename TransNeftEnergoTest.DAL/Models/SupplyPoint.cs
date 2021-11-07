using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Точка поставки электроэнергии
    /// </summary>
    [Table("SuplyPoints")]
    public class SupplyPoint
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public int ConsumptionUnitID { get; set; }
        public virtual ConsumptionUnit ConsumptionUnit { get; set; }
        public virtual AccountingDevice AccountingDevice { get; set; }

        public SupplyPointDTO ToDTO()
        {
            return new SupplyPointDTO
            {
                ID = this.ID,
                Name = this.Name,
                MaxPower = this.MaxPower,
                ConsumptionUnitID = this.ConsumptionUnitID
            };
        }
    }
}
