using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Объкт потребления
    /// </summary>
    [Table("ConsumptionUnits")]
    public class ConsumptionUnit : Organization
    {
        public virtual ChildOrganization ChildOrganization { get; set; }
        public virtual IList<SupplyPoint> SupplyPoints { get; set; }
        public virtual IList<MeasurementPoint> MeasurementPoints { get; set; }
    }
}
