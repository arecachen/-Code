namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeSalary")]
    public partial class EmployeeSalary
    {
        [Key]
        public int employeeSalaryTID { get; set; }

        public int employeeID { get; set; }

        public int OrderCarRegularGroupID { get; set; }

        public long? empBeginDate { get; set; }

        public long? empEndDate { get; set; }

        public int? empSalary { get; set; }

        public int? empAward { get; set; }

        public int? empRespBonus { get; set; }

        public int? empDutyAward { get; set; }

        public int? empSpecialBonus { get; set; }

        public int? empLabourComp { get; set; }

        public int? empLabourSelf { get; set; }

        public int? empNhiComp { get; set; }

        public int? empNhiSelf { get; set; }

        public int? empSuperComp { get; set; }

        public int? empSuperSelf { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Required]
        [StringLength(20)]
        public string? empStatus { get; set; }

        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
    }
}
