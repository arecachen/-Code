namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeePaymentRecord")]
    public partial class EmployeePaymentRecord
    {
        [Key]
        public int employeePaymentRecordTID { get; set; }

        public int employeeID { get; set; }

        public int employeeSalaryID { get; set; }

        public int payYear { get; set; }

        public int payMonth { get; set; }

        public int? RegularTrip { get; set; }

        public int? IrregularTrip { get; set; }

        public int? IrregularTip { get; set; }

        public int? PerformanceAmount { get; set; }

        public int? InsuranceAmount { get; set; }

        public int? BorrowAmount { get; set; }

        public int? LeaveAmount { get; set; }

        public int? AddAmount { get; set; }

        public int? DeductionAmount { get; set; }

        public int? TotalSalary { get; set; }

        public int? TotalPayable { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        public long PaymentDate { get; set; }

        [Required]
        [StringLength(20)]
        public string? status { get; set; }

        public bool deleted { get; set; } = false;
    }
}
