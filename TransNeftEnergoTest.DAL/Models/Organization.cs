using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Обобщенная организация
    /// </summary>
    public abstract class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
