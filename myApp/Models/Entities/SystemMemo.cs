namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemMemo")]
    public partial class SystemMemo
    {
        [Key]
        public int systemMemoTID { get; set; }

        [Column(TypeName = "text")]
        public string? joMemo { get; set; }

        [Column(TypeName = "text")]
        public string? salaryMemo { get; set; }
        public bool deleted { get; set; } = false;
    }
}
