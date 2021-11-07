using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

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
        public virtual IEnumerable<MeasurementPointToAccountingDevice> MeasurementPointToAccountingDevice { get; set; }

        public AccountingDeviceDTO ToDTO()
        {
            var dto = new AccountingDeviceDTO
            {
                ID = this.ID
            };
            return dto;
        }
    }
}
