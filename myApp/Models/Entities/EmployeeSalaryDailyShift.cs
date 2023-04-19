namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeSalaryDailyShift")]
    public partial class EmployeeSalaryDailyShift
    {
        [Key]
        public int EmployeeSalaryDailyShiftTID { get; set; }

        public long DS_Date { get; set; }

        public int DS_EmployeeID { get; set; }

        public decimal DS_BaseRate { get; set; }

        public int DS_BaseCount { get; set; }

        public int DS_OrderCarID { get; set; }

        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
    }
}
