using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Объкт потребления
    /// </summary>
    [Table("ConsumptionUnits")]
    public class ConsumptionUnit : Organization
    {
        public virtual ChildOrganization ChildOrganization { get; set; }
        public virtual IEnumerable<SupplyPoint> SupplyPoints { get; set; }
        public virtual IEnumerable<MeasurementPoint> MeasurementPoints { get; set; }

        public ConsumptionUnitDTO ToDTO()
        {
            var dto = new ConsumptionUnitDTO
            {
                ID = this.ID,
                Name = this.Name,
                Address = this.Address
            };
            if (SupplyPoints != null)
            {
                dto.SupplyPoints = new List<SupplyPointDTO>();
                foreach (SupplyPoint sp in SupplyPoints)
                    dto.SupplyPoints = dto.SupplyPoints.Append(sp.ToDTO());
            }
            if (MeasurementPoints != null)
            {
                dto.MeasurementPoints = new List<MeasurementPointDTO>();
                foreach (MeasurementPoint mp in MeasurementPoints)
                    dto.MeasurementPoints = dto.MeasurementPoints.Append(mp.ToDTO());
            }
            return dto;
        }
    }
}
