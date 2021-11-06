using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    ///  Таблица связи по интервалу времени
    /// </summary>
    [Table("MeasurementPointToAccountingDevice")]
    public class MeasurementPointToAccountingDevice
    {
        public int ID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int AccountingDeviceID { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual AccountingDevice AccountingDevice { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }
    }
}
