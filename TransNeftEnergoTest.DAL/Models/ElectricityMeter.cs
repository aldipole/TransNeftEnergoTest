using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Счетчик электрической энергии
    /// </summary>
    [Table("ElectricityMeters")]
    public class ElectricityMeter
    {
        public int ID { get; set; }
        public ElectricityMeterType Type { get; set; }
        public DateTime ExpiredAt { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }

        public ElectricityMeter()
        {

        }

        public ElectricityMeter(ElectricityMeterDTO em)
        {
            Type = (ElectricityMeterType)em.Type;
            ExpiredAt = em.ExpiredAt;
        }

        public ElectricityMeterDTO ToDTO()
        {
            return new ElectricityMeterDTO
            {
                ID = this.ID,
                Type = (int)this.Type,
                ExpiredAt = this.ExpiredAt
            };
        }

    }
    public enum ElectricityMeterType
    {
        MeterType1,
        MeterType2,
        MeterType3
    }
}
