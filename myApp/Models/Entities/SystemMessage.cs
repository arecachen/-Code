namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemMessage")]
    public partial class SystemMessage
    {
        [Key]
        public int systemMsgTID { get; set; }

        public long startDate { get; set; }

        public long endDate { get; set; }

        [Required]
        [StringLength(20)]
        public string? msgTitle { get; set; }

        [StringLength(256)]
        public string? message { get; set; }

        public int createBy { get; set; }

        public int modifyBy { get; set; }

        public virtual EmployeeMain? EmployeeMain { get; set; }

        public virtual EmployeeMain? EmployeeMain1 { get; set; }
        public bool deleted { get; set; } = false;
    }
}
