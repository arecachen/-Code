namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAdvPayment")]
    public partial class EmployeeAdvPayment
    {
        [Key]
        public int employeeAdvPaymentTID { get; set; }

        public int empPaymentRecordID { get; set; }

        public int employeeID { get; set; }

        [Required]
        [StringLength(30)]
        public string? empContact { get; set; }

        public long empCashDatetime { get; set; }

        public int? empCashAmount { get; set; }

        [StringLength(256)]
        public string? empCashMemo { get; set; }

        public int empRepaid { get; set; }

        public long? empRepaidDate { get; set; }

        public int empRepaidCash { get; set; }

        public int cashRecordBy { get; set; }

        public int cashUpdateBy { get; set; }

        public long cashRecordDatetime { get; set; }

        public long cashLastUpadteDatetime { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped, Display(Name = "�ɴڤ��")]
        public string? sCashDate
        {
            get { return ((long?)empCashDatetime).LongToDateString(); }
            set { empCashDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�ٴڤ��")]
        public string? sRepaidDate
        {
            get { return ((long?)empRepaidDate).LongToDateString(); }
            set { empRepaidDate = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "���ɤ�� ")]
        public string? sCashRecordDatetime
        {
            get { return ((long?)cashRecordDatetime).LongToDateString(); }
            set { cashRecordDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�̫��s��� ")]
        public string? sCashLastUpadteDatetime
        {
            get { return ((long?)cashLastUpadteDatetime).LongToDateString(); }
            set { cashLastUpadteDatetime = value.ToTimLong(); }
        }
        [NotMapped, Display(Name = "�O�_�ٴ� ")]
        public string? sRepaid
        {
            get { return (empRepaid == 0) ? "���k��" : (empRepaid == 1) ? "���B�k��" : (empRepaid == 2) ? "�����k��" : (empRepaid == 3) ? "�{�C�l��" : "�R��"; }

        }
        [ForeignKey("employeeID")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }
}
