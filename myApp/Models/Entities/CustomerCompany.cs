using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class CustomerCompany
    {
        [Key, Required]
        public int Id { get; set; }
        [Display(Name = "公司名稱")]
        [StringLength(256)]
        public string? companyName { get; set; }
        [Display(Name = "主要聯絡電話")]
        [StringLength(50)]
        public string? mainPhone { get; set; }
        [Display(Name = "統一編號")]
        [StringLength(8)]
        public string? UniCode { get; set; }
        [Display(Name = "是否聯盟")]
        public bool busAllian { get; set; }
        [Display(Name = "備註")]
        [Column(TypeName = "text")]
        public string? memo { get; set; }
        public bool deleted { get; set; } = false;
        public int? oldID { get; set; }
        [Display(Name = "地址"),StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? address { get; set; }
        [Display(Name = "Email"), StringLength(256), MaxLength(256, ErrorMessage = "長度不可超過 256個字")]
        public string? email { get; set; }
    }
}