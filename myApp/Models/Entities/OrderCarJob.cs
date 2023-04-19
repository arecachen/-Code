namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCarJob")]
    public partial class OrderCarJob
    {
        [Key]
        public int OrderCarJobTID { get; set; }

        public int carOrderInfoID { get; set; }

        public int carOrderRegularInfoID { get; set; }

        public int SourceOrderCarJobID { get; set; }

        [Required]
        [StringLength(15)]
        public string? carID { get; set; }

        public int driver { get; set; }

        [StringLength(30)]
        public string? carType { get; set; }

        public long useDate { get; set; }

        public int carStartHour { get; set; }

        public int carStartMin { get; set; }

        public int carEndHour { get; set; }

        public int carEndMin { get; set; }

        [Required]
        [StringLength(15)]
        public string? apptType { get; set; }

        [Required]
        public string? apptMemo { get; set; }

        public string? apptJobMemo { get; set; }

        public string? unpickMemo { get; set; }

        public int apptSalary { get; set; }

        public int apptCharge { get; set; }

        public int isTakeApart { get; set; }

        public int? cost { get; set; }

        public int? SalaryTips { get; set; }

        public int? SalaryTrip { get; set; }

        [Required]
        [StringLength(20)]
        public string? finalStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string? JobSource { get; set; }

        [Column(TypeName = "text")]
        public string? CheckinLocation { get; set; }

        public virtual OrderCarPartnerCarStatementItem? OrderCarPartnerCarStatementItem { get; set; }

        public bool deleted { get; set; } = false;
    }
}
