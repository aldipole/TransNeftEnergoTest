using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Точка измерения электроэнергии
    /// </summary>
    [Table("MeasurementPoints")]
    public class MeasurementPoint
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ConsumptionUnitID { get; set; }
        public virtual ConsumptionUnit ConsumptionUnit { get; set; }
        public virtual ElectricityMeter ElectricityMeter { get; set; }
        public virtual CurrentTransformer CurrentTransformer { get; set; }
        public virtual VoltageTransformer VoltageTransformer { get; set; }
        public virtual IEnumerable<MeasurementPointToAccountingDevice> MeasurementPointToAccountingDevice { get; set; }

        public MeasurementPoint()
        {

        }

        public MeasurementPoint(MeasurementPointDTO mp)
        {
            Name = mp.Name;
            ConsumptionUnitID = mp.ConsumptionUnitID;
            ElectricityMeter = new ElectricityMeter(mp.ElectricityMeter);
            CurrentTransformer = new CurrentTransformer(mp.CurrentTransformer);
            VoltageTransformer = new VoltageTransformer(mp.VoltageTransformer);
        }

        public MeasurementPointDTO ToDTO()
        {
            var dto = new MeasurementPointDTO
            {
                ID = this.ID,
                Name = this.Name,
                ConsumptionUnitID = this.ConsumptionUnitID
            };
            if (ElectricityMeter != null)
                dto.ElectricityMeter = ElectricityMeter.ToDTO();
            if (CurrentTransformer != null)
                dto.CurrentTransformer = CurrentTransformer.ToDTO();
            if (VoltageTransformer != null)
                dto.VoltageTransformer = VoltageTransformer.ToDTO();
            return dto;
        }
    }
}
