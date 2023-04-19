using Howgreater.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class CarEquipmentAudit
    {
        [Key, Required]
        public int ID { get; set; }
        [Required]
        [Display(Name = "車號"), StringLength(15), MaxLength(15, ErrorMessage = "長度不可超過 15個字")]
        public string? CarID { get; set; }
        [Display(Name = "稽核日期")]
        public long auditDate { get; set; }
        [Display(Name = "綜合描述")]
        public string? description { get; set; }
        [Display(Name = "綜合描述複查註記")]
        public string? reviewDescNote { get; set; }
        [Display(Name = "需複查(綜合描述)")]
        public bool requireReviewDesc { get; set; }
        [Display(Name = "需追蹤(綜合描述)")]
        public bool requireTrackDesc { get; set; }
        [Display(Name = " 已複查(綜合描述)")]
        public bool isReviewedDesc { get; set; }
        [Display(Name = "已追蹤(綜合描述)")]
        public bool isTrackedDesc { get; set; }
        [Display(Name = "綜合缺失")]
        public string? missing { get; set; }
        [Display(Name = "需複查(綜合缺失)")]
        public bool requireReviewMiss { get; set; }
        [Display(Name = "需追蹤(綜合缺失)")]
        public bool requireTrackMiss { get; set; }
        [Display(Name = " 已複查(綜合缺失)")]
        public bool isReviewedMiss { get; set; }
        [Display(Name = "已追蹤(綜合缺失)")]
        public bool isTrackedMiss { get; set; }
        [Display(Name = "綜合缺失複查註記")]
        public string? reviewMissNote { get; set; }
        [Display(Name = "稽核狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? auditStatus { get; set; }//符合規範/待改善
        [Display(Name = "結案註記")]
        public string? auditNote { get; set; }//符合規範/待改善
        [ForeignKey("CarID")]
        public CarMain? carMain { get; set; }
        public bool deleted { get; set; }= false;
        [NotMapped]
        public string? sAuditDate
        {
            get { return ((long?)auditDate).LongToDateString(); }
            set { auditDate = value.ToDateLong(); }
        }
    }
    public class CarEquipmentAuditDetail
    {
        [Key, Required]
        public int ID { get; set; }
        [Required]
        public int auditID { get; set; } //CarEquipmentAudit.ID
        public int carEquipTID { get; set; }
        [Display(Name = "是否合規")]
        public bool isCompliant { get; set; }
        [Display(Name = "複查?")]
        public bool isReview { get; set; }
        [Display(Name = "追蹤?")]
        public bool isTrack { get; set; }
        [Display(Name = "稽核備註")]
        public string? memo { get; set; }
        [Display(Name = "需追蹤")]
        public bool isTracked { get; set; }
        [Display(Name = " 已複查")]
        public bool isReviewed { get; set; }
        [ForeignKey("carEquipTID")]
        public CarEquipment? carEquipment { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? carMemo { get; set; }
        [NotMapped]
        public int? amount { get; set; }
    }
}