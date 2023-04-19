using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    //車輛裝備-用途分類管理
    public class CarItemCategory
    {
        [Key]
        public int id { get; set; }
        [StringLength(50), Display(Name = "用途分類")]
        public string? categoryTitle { get; set; }
        [StringLength(15), Display(Name = "狀態")]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? statusText { get { return (status == "Active") ? "使用中" : "非使用中"; }  } 
    }
}