using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    /// Дочерняя организация
    /// </summary>
    [Table("ChildOrganizations")]
    public class ChildOrganization : Organization
    {
        public int ParentOrganizationID { get; set; }
        public virtual ParentOrganization ParentOrganization { get; set; }
        public virtual IEnumerable<ConsumptionUnit> ConsumptionUnits { get; set; }
}
}
