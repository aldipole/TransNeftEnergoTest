using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergoTest.DAL.Models
{
    /// <summary>
    ///  Материнская организация
    /// </summary>
    [Table("ParentOrganization")]
    public class ParentOrganization : Organization
    {
        public virtual IList<ChildOrganization> ChildOrganizations { get; set; }
    }
}
