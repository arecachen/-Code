using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class NTPFiles
    {
        [Key, Required]
        public int ID { get; set; }
        [Required]
        public int orderCarID { get; set; }
        [Display(Name = "檔案類別ID")]
        public int FileTypeId { get; set; }
        [Display(Name = "檔案名稱"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? FileName { get; set; }
        [Display(Name = "儲存檔案名稱"), StringLength(100), MaxLength(100, ErrorMessage = "長度不可超過 100個字")]
        public string? GuidName { get; set; }
        public string? status { get; set; }
        [ForeignKey("FileTypeId")]
        public NTPFileType? NTPFileType { get; set; }
        public bool deleted { get; set; } = false;
    }
    public class NTPFileType
    {
        [Key, Required]
        public int ID { get; set; }   
        [Display(Name = "檔案類別名稱"), StringLength(30), MaxLength(30, ErrorMessage = "長度不可超過 30個字")]
        public string? TypeName { get; set; }
        [Display(Name = "排序")]
        public int Order { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
    }
}