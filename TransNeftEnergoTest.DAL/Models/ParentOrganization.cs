using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    ///  Материнская организация
    /// </summary>
    [Table("ParentOrganization")]
    public class ParentOrganization : Organization
    {
        public virtual IEnumerable<ChildOrganization> ChildOrganizations { get; set; }
    }
}
