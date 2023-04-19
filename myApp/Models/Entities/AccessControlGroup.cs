namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessControlGroup")]
    public partial class AccessControlGroup
    {
        [Key]
        public int accessControlGroupTID { get; set; }

        public int accessControlID { get; set; }

        public int menuGroupID { get; set; }

        public virtual AccessControl? AccessControl { get; set; }

        public virtual MenuGroup? MenuGroup { get; set; }
 
        public bool deleted { get; set; } = false;
    }
}
