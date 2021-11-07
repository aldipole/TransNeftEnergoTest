using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransNeftEnergoTest.DTO;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Трансформатор тока
    /// </summary>
    [Table("CurrentTransformers")]
    public class CurrentTransformer : Transformer
    {
        public CurrentTransformerType Type { get; set; }

        public CurrentTransformer()
        {

        }

        public CurrentTransformer(TransformerDTO ct)
        {
            Type = (CurrentTransformerType)ct.Type;
            TransformationRatio = ct.TransformationRatio;
            ExpiredAt = ct.ExpiredAt;
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

    public enum CurrentTransformerType
    {
        CurrentTransformerType1,
        CurrentTransformerType2,
        CurrentTransformerType3
    }
}
