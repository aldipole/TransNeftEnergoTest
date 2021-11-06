using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual IList<ConsumptionUnit> ConsumptionUnits { get; set; }
}
}
