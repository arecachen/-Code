namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarSafetyRecord")]
    public partial class CarSafetyRecord
    {
        [Key]
        public int carSafetyCheckTID { get; set; }
        
        [Required(ErrorMessage = "������������")]
        public string? carID { get; set; }

        public int checkBy { get; set; }

        public long checkDate { get; set; }

        [Required(ErrorMessage = "���ݦ��W���ɮ�")]
        public string? chkDocument { get; set; }

        [Required]
        [StringLength(12)]
        public string? status { get; set; }

        public virtual CarMain? CarMain { get; set; }
        [ForeignKey("checkBy")]
        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "�w�ˤ����������")]
        public string? sCheckDate
        {
            get { return ((long?)checkDate).LongToDateString(); }
            set { checkDate = value.ToDateLong(); }
        }
        public string? sStatus
        {
            get { return (status == "Active") ? "�ϥΤ�" : (status == "Inactive") ? "�@�o" : "�R��"; }
        }
    }
}
