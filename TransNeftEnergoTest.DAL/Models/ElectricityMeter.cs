using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Счетчик электрической энергии
    /// </summary>
    [Table("ElectricityMeters")]
    public class ElectricityMeter
    {
        public int ID { get; set; }
        public DateTime VerificationDate { get; set; }
        public ElectricityMeterType Type { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }

    }
    public enum ElectricityMeterType
    {
        MeterType1,
        MeterType2,
        MeterType3
    }
}
