using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Обобщенный трансформатор
    /// </summary>
    public abstract class Transformer
    {
        public int ID { get; set; }
        public DateTime ExpiredAt { get; set; }
        public double TransformationRatio { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }
    }
}
