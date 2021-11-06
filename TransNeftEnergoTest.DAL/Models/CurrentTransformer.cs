using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Трансформатор тока
    /// </summary>
    [Table("CurrentTransformers")]
    public class CurrentTransformer
    {
        public int ID { get; set; }
        public DateTime VerificationDate { get; set; }
        public CurrentTransformerType Type { get; set; }
        public double TransformationRatio { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }
    }
    public enum CurrentTransformerType
    {
        CurrentTransformerType1,
        CurrentTransformerType2,
        CurrentTransformerType3
    }
}
