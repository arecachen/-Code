using Altways;
using DocumentFormat.OpenXml.Wordprocessing;
using Howgreater.util;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class MorningTravelRpt
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "建立日期")]
        public long createDateime { get; set; }
        [Display(Name = "建立人員")]
        public int? createby { get; set; }
        [Display(Name = "發車日期")]
        public long jobDate { get; set; }
        [Display(Name = "發車時間")]
        public TimeSpan? jobTime { get; set; }
        [Display(Name = "預定通報時間")]
        public long? notifyTime { get; set; }
        [Required, Display(Name = "司機")]
        public int byDriver { get; set; }
        [Required, Display(Name = "車號"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? byCar { get; set; }
        [Display(Name = "通報時間")]
        public long? reportTime { get; set; }
        [Display(Name = "警訊發送時間")]
        public long? alertSentTime { get; set; }
        [Display(Name = "重發時間")]
        public int? alertResent { get; set; }
        [Display(Name = "重發次數")]
        public int? alertRepeat { get; set; }
        [Display(Name = "已發送次數")]
        public int alertSentNumber { get; set; } = 0;
        [Display(Name = "預設發車前通報時間")]
        public int? alertTimePeriod { get; set; } = 0;
        [Display(Name = "訊息通報人")]
        public int? notifyStaff { get; set; } = 0;
        [Display(Name = "訊息通報人員")]
        public int? reportBy { get; set; } = 0;
        public bool? RequireNotified { get; set; }
        public bool deleted { get; set; } = false;
        [ForeignKey("byDriver")]
        public virtual EmployeeMain? employeeDriver { get; set; }
        [ForeignKey("notifyStaff")]
        public virtual EmployeeMain? employeeNotified { get; set; }
        [ForeignKey("reportBy")]
        public virtual EmployeeMain? employeeReport { get; set; }
        [NotMapped]
        public string? week { get { return ((long?)jobDate).week(); } }
        [NotMapped]
        public string? sCreateDateime
        {
            get { return ((long?)createDateime).LongToDateString(); }
            set { createDateime = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sJobDate
        {
            get { return ((long?)jobDate).LongToDateString(); }
            set { jobDate = value.ToDateLong(); }
        }
        [NotMapped]
        public string? sJobTime
        {
            get { return jobTime.Ensure(x => x.Value.ToString(@"hh\:mm")); }
        }
     
        [NotMapped]
        public string? sAlertSentTime
        {
            get { return alertSentTime.LongToDateTimeString(); }
        }
        [NotMapped]
        public string? title
        {
            get { return string.Format(@"{0}-{1}-{2}-{3} ", byCar, employeeDriver.empName, alertTimePeriod, sJobTime); }
        }
        [NotMapped]
        public string? sAlertResent
        {
            get { return alertResent.Ensure(x => x.Value.ToString(@"hh\:mm")); }
        }
        [NotMapped]
        public string? alertResult
        {
            get { return (string.IsNullOrEmpty(sAlertSentTime)) ? "尚未發送" : sAlertSentTime + " 發送"; }
        }
        [NotMapped]
        public string? sReportTime
        {
            get { return (reportTime == null || reportTime == 0) ? "尚未回報" : reportTime.LongToDateTimeString() +"回報"; }
        }
        [NotMapped]
        public string? sNotifyTime
        {
            get { return notifyTime.LongToDateTimeString(); }
        }
    }
    public class MorningRptStaff
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int? empId { get; set; }
        public bool deleted { get; set; } = false;
        public string? mobile { get; set; }
        public int alertTimePeriod { get; set; } = 60;
        [ForeignKey("empId")]
        public virtual EmployeeMain? EmployeeMain { get; set; }
    }
}