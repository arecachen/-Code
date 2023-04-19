namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeDuty_del
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int employeeDutyTID { get; set; }

        [Required]
        [StringLength(20)]
        public string empDutyName { get; set; }

        [Column(TypeName = "text")]
        public string memo { get; set; }

        [Required]
        [StringLength(10)]
        public string status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
