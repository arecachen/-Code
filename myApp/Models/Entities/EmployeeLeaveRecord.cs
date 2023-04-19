namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [MetadataType(typeof(EmployeeLeaveRecordMetadata))]
    [Table("EmployeeLeaveRecord")]
    public partial class EmployeeLeaveRecord
    {
        [Key]
        public int employeeLeaveTID { get; set; }

        public int employeeID { get; set; }

        public int employeePaymentRecordID { get; set; }

        public long? applyDate { get; set; }

        public long leaveDate { get; set; }
        public TimeSpan? leaveTimeStart { get; set; }
        [NotMapped]
        public string? sLeaveTimeStart { get { return (leaveTimeStart.HasValue)? leaveTimeStart.Value.Hours.ToString("00") + "��" + leaveTimeStart.Value.Minutes.ToString("00") + "��":"00��00��"; } }
        public int leaveTimeStartHour { get; set; }

        public int leaveTimeStartMin { get; set; }
        public TimeSpan? leaveTimeEnd { get; set; }
        [NotMapped]
        public string? sLeaveTimeEnd { get { return (leaveTimeEnd.HasValue) ? leaveTimeEnd.Value.Hours.ToString("00") + "��" + leaveTimeEnd.Value.Minutes.ToString("00") + "��" : "00��00��"; } }
        public int leaveTimeEndHour { get; set; }

        public int leaveTimeEndMin { get; set; }

        [StringLength(50)]
        public string? leaveReason { get; set; }
        //[DisplayFormat(DataFormatstring? = "{0:N}", ApplyFormatInEditMode = true)]
        public int? salaryDeduct { get; set; }

        [Required]
        [StringLength(50)]
        public string? leaveType { get; set; }

        [Required]
        [StringLength(50)]
        public string? leaveApplyStatus { get; set; }

        public int salaryDeductStatus { get; set; }

        public long salaryDeductDate { get; set; }

        public long leaveEndDate { get; set; }
        [DataType("decimal(5,1)")]
        public decimal leaveTotalHour { get; set; }

        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        [Display(Name = "�ӽФ��")]
        public string? applyDateStr
        {
            get { return (applyDate).LongToDate().DatePart(); }
            set { applyDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "�w�w�а����")]
        public string? leaveDateStr
        {
            get { return ((long?)leaveDate).LongToDateString(); }
            set { leaveDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "���ڤ�� ")]
        public string? salaryDeductDateStr
        {
            get { return ((long?)salaryDeductDate).LongToDateString(); }
            set { salaryDeductDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "�w�w�а�������� ")]
        public string? leaveEndDateStr
        {
            get { return ((long?)leaveEndDate).LongToDateString(); }
            set { leaveEndDate = value.ToDateLong(); }
        }
        //[NotMapped]
        //public string? leaveDateStr
        //{
        //    get { return ((long?)leaveDate).StampToDateString(); }
        //    set { leaveDate = value.ToDateStamp(); }
        //}
        //[NotMapped]
        //public string? leaveEndDateStr
        //{
        //    get { return ((long?)leaveEndDate).StampToDateString(); }
        //    set { leaveEndDate = value.ToDateStamp(); }
        //}
    }
    public class EmployeeLeaveRecordMetadata
    {
        [Required]
        [Display(Name = "���uID")]
        public int employeeID { get; set; } //���i�ŭ�,FK_EmployeeMain_employeeTID  
        [Required]
        [Display(Name = "�������~���ID")]
        public int employeePaymentRecordID { get; set; } //���i�ŭ�,�������~���ID �w�]-999         
        [Display(Name = "�ӽФ��")]
        public long? applyDate { get; set; } //�i�ŭ�,�ӽФ�� 
        [Required]
        [Display(Name = "�w�w�а����")]
        public long leaveDate { get; set; } //���i�ŭ�,�w�w�а���� 
        [Required]
        [Display(Name = "�а��������")]
        public long leaveEndDate { get; set; } //���i�ŭ�, 
        [Required]
        [Display(Name = "�а��}�l�ɶ� (�p��) ")]
        public int leaveTimeStartHour { get; set; } //���i�ŭ�,�а��}�l�ɶ� (�p��) 
        [Required]
        [Display(Name = "�а��}�l�ɶ� (��)  ")]
        public int leaveTimeStartMin { get; set; } //���i�ŭ�,�а��}�l�ɶ� (��) 
        [Required]
        [Display(Name = "�а������ɶ� (�p��)  ")]
        public int leaveTimeEndHour { get; set; } //���i�ŭ�,�а������ɶ� (�p��) 
        [Required]
        [Display(Name = "�а������ɶ� (��) ")]
        public int leaveTimeEndMin { get; set; } //���i�ŭ�,�а������ɶ� (��) 
        [StringLength(50)]
        [Display(Name = "�а��z��")]
        public string? leaveReason { get; set; } //�i�ŭ�,�а��z�� 

        [Display(Name = "���~���B")]
        public int? salaryDeduct { get; set; } //���i�ŭ�,���~���B �w�]�� 0 
        [Required]
        [Display(Name = "�а����O")]
        public string? leaveType { get; set; } //���i�ŭ�,�а����O �U�Կ��A[DictionaryTable].dicCategory = EmployeeLeaveRecord_leaveType 
        [Required]
        [Display(Name = "�֭㪬�A")]
        public string? leaveApplyStatus { get; set; } //���i�ŭ�,�֭㪬�A �U�Կ��A[DictionaryTable].dicCategory = EmployeeLeaveRecord_leaveApplyStatus �ӽФ�/�P�N/���P�N 
        [Required]
        [Display(Name = "���ڪ��A")]
        public int salaryDeductStatus { get; set; } //���i�ŭ�,���ڪ��A �w�]��0 (0: ���k�١B1: ���B�k�١B2: �����k�١B3: �{�C�l���B4: �R��)  
        [Required]
        [Display(Name = "���ڤ��  ")]
        public long salaryDeductDate { get; set; } //���i�ŭ�,���ڤ��  

        [Required]
        [Display(Name = "�а��`�ɼ�")]
        public decimal leaveTotalHour { get; set; } //���i�ŭ�, 
        [Required]
        [Display(Name = "ID")]
        public int employeeLeaveTID { get; set; } //���i�ŭ�, 
        [ForeignKey("employeeID")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }
}
