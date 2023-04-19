namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessCorporation")]
    public partial class AccessCorporation
    {
        [Key]
        public int loginTID { get; set; }

        public int corpID { get; set; }

        [Required]
        [StringLength(30)]
        public string? loginID { get; set; }

        [Required]
        [StringLength(30)]
        public string? loginPWD { get; set; }

        [StringLength(256)]
        public string? empEmail { get; set; }

        [StringLength(256)]
        public string? accGroup { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }

        public virtual Corporation? Corporation { get; set; }
   
        public bool deleted { get; set; } = false;
    }
}
