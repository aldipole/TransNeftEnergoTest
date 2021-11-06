using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Расчетный прибор учета
    /// </summary>
    [Table("AccountingDevices")]
    public class AccountingDevice
    {
        public int ID { get; set; }
        public int SupplyPointID { get; set; }
        public virtual SupplyPoint SupplyPoint { get; set; }
        public virtual MeasurementPointToAccountingDevice MeasurementPointToAccountingDevice { get; set; }
    }
}
