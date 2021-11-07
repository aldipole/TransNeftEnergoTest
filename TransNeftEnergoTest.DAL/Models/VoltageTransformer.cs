using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Трансформатор напряжения
    /// </summary>
    [Table("VoltageTransformers")]
    public class VoltageTransformer : Transformer
    {
        public VoltageTransformerType Type { get; set; }

        public VoltageTransformer()
        {

        }

        public VoltageTransformer(TransformerDTO vt)
        {
            Type = (VoltageTransformerType)vt.Type;
            TransformationRatio = vt.TransformationRatio;
            ExpiredAt = vt.ExpiredAt;
        }

        public TransformerDTO ToDTO()
        {
            return new TransformerDTO
            {
                ID = this.ID,
                Type = (int)this.Type,
                TransformationRatio = this.TransformationRatio,
                ExpiredAt = this.ExpiredAt
            };
        }
    }

    public enum VoltageTransformerType
    {
        VoltageTransformerType1,
        VoltageTransformerType2,
        VoltageTransformerType3
    }
}
