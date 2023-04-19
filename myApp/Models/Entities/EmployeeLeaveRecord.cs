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
        public string? sLeaveTimeStart { get { return (leaveTimeStart.HasValue)? leaveTimeStart.Value.Hours.ToString("00") + "時" + leaveTimeStart.Value.Minutes.ToString("00") + "分":"00時00分"; } }
        public int leaveTimeStartHour { get; set; }

        public int leaveTimeStartMin { get; set; }
        public TimeSpan? leaveTimeEnd { get; set; }
        [NotMapped]
        public string? sLeaveTimeEnd { get { return (leaveTimeEnd.HasValue) ? leaveTimeEnd.Value.Hours.ToString("00") + "時" + leaveTimeEnd.Value.Minutes.ToString("00") + "分" : "00時00分"; } }
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
        [Display(Name = "申請日期")]
        public string? applyDateStr
        {
            get { return (applyDate).LongToDate().DatePart(); }
            set { applyDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "預定請假日期")]
        public string? leaveDateStr
        {
            get { return ((long?)leaveDate).LongToDateString(); }
            set { leaveDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "扣款日期 ")]
        public string? salaryDeductDateStr
        {
            get { return ((long?)salaryDeductDate).LongToDateString(); }
            set { salaryDeductDate = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "預定請假結束日期 ")]
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
        [Display(Name = "員工ID")]
        public int employeeID { get; set; } //不可空值,FK_EmployeeMain_employeeTID  
        [Required]
        [Display(Name = "對應之薪資單ID")]
        public int employeePaymentRecordID { get; set; } //不可空值,對應之薪資單ID 預設-999         
        [Display(Name = "申請日期")]
        public long? applyDate { get; set; } //可空值,申請日期 
        [Required]
        [Display(Name = "預定請假日期")]
        public long leaveDate { get; set; } //不可空值,預定請假日期 
        [Required]
        [Display(Name = "請假結束日期")]
        public long leaveEndDate { get; set; } //不可空值, 
        [Required]
        [Display(Name = "請假開始時間 (小時) ")]
        public int leaveTimeStartHour { get; set; } //不可空值,請假開始時間 (小時) 
        [Required]
        [Display(Name = "請假開始時間 (分)  ")]
        public int leaveTimeStartMin { get; set; } //不可空值,請假開始時間 (分) 
        [Required]
        [Display(Name = "請假結束時間 (小時)  ")]
        public int leaveTimeEndHour { get; set; } //不可空值,請假結束時間 (小時) 
        [Required]
        [Display(Name = "請假結束時間 (分) ")]
        public int leaveTimeEndMin { get; set; } //不可空值,請假結束時間 (分) 
        [StringLength(50)]
        [Display(Name = "請假理由")]
        public string? leaveReason { get; set; } //可空值,請假理由 

        [Display(Name = "扣薪金額")]
        public int? salaryDeduct { get; set; } //不可空值,扣薪金額 預設為 0 
        [Required]
        [Display(Name = "請假類別")]
        public string? leaveType { get; set; } //不可空值,請假類別 下拉選單，[DictionaryTable].dicCategory = EmployeeLeaveRecord_leaveType 
        [Required]
        [Display(Name = "核准狀態")]
        public string? leaveApplyStatus { get; set; } //不可空值,核准狀態 下拉選單，[DictionaryTable].dicCategory = EmployeeLeaveRecord_leaveApplyStatus 申請中/同意/不同意 
        [Required]
        [Display(Name = "扣款狀態")]
        public int salaryDeductStatus { get; set; } //不可空值,扣款狀態 預設為0 (0: 未歸還、1: 全額歸還、2: 部份歸還、3: 認列損失、4: 刪除)  
        [Required]
        [Display(Name = "扣款日期  ")]
        public long salaryDeductDate { get; set; } //不可空值,扣款日期  

        [Required]
        [Display(Name = "請假總時數")]
        public decimal leaveTotalHour { get; set; } //不可空值, 
        [Required]
        [Display(Name = "ID")]
        public int employeeLeaveTID { get; set; } //不可空值, 
        [ForeignKey("employeeID")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }
}
