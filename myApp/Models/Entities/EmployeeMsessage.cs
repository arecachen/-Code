namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeMsessage")]
    public partial class EmployeeMsessage
    {
        [Key]
        public int EmpMsgTID { get; set; }

        public long CreateDateTime { get; set; }

        public long MessageDate { get; set; }

        public int CreateBy { get; set; }

        [Required]
        [StringLength(256)]
        public string? CreateTo { get; set; }

        public int MsgPublic { get; set; }

        [Required]
        [StringLength(20)]
        public string? MsgTitle { get; set; }

        [Required]
        [StringLength(15)]
        public string? MsgPriority { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string? MsgBody { get; set; }

        public int SourceMsgID { get; set; }

        [Required]
        [StringLength(20)]
        public string? MsgStatus { get; set; }

        public virtual EmployeeMain EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
    }
}
