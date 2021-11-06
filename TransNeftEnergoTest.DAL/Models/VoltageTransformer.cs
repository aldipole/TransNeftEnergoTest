using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Трансформатор напряжения
    /// </summary>
    [Table("VoltageTransformers")]
    public class VoltageTransformer
    {
        public int ID { get; set; }
        public DateTime VerificationDate { get; set; }
        public VoltageTransformerType Type { get; set; }
        public double TransformationRatio { get; set; }
        public int MeasurementPointID { get; set; }
        public virtual MeasurementPoint MeasurementPoint { get; set; }
    }
    public enum VoltageTransformerType
    {
        VoltageTransformerType1,
        VoltageTransformerType2,
        VoltageTransformerType3
    }
}
