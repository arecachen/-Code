using hsintongERP2022.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class PremessionGroup
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "可檢視")]
        public bool viewable { get; set; }
        [Display(Name = "可新增修改")]
        public bool editable { get; set; }
        [Display(Name = "可刪除")]
        public bool deleteable { get; set; }
        [StringLength(128)]
        public string? AspNetRoles_Id { get; set; }
        public int Menus_ID { get; set; }
        [ForeignKey("Menus_ID")]
        public Menus? Menus { get; set; }
        [ForeignKey("AspNetRoles_Id")]
        public virtual AspNetRoles? AspNetRoles { get; set; }

        [NotMapped, Display(Name = "群組/項目")]
        public string? menuType { get { return (Menus.Type == MenuType.ActionGroup) ? "群組" : "項目"; } }
        [NotMapped, Display(Name = "目錄名稱")]
        public string? menuTitle { get { return Menus.Title; } }
    }
    public class PremessionUser
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Required]
        [Display(Name = "可檢視")]
        public bool viewable { get; set; }
        [Display(Name = "可新增修改")]
        public bool editable { get; set; }
        [Display(Name = "可刪除")]
        public bool deleteable { get; set; }
        public int Menus_ID { get; set; }        
        [ForeignKey("Menus_ID")]
        public Menus? Menus { get; set; }
        public string? AspNetUsers_Id { get; set; }
        public int EmployeeMain_employeeTID { get; set; }
        [ForeignKey("EmployeeMain_employeeTID")]
        public EmployeeMain? EmployeeMain { get; set; }
        [ForeignKey("AspNetUsers_Id")]
        public AspNetUsers? AspNetUsers { get; set; }
     
        [NotMapped, Display(Name = "群組/項目")]
        public string? menuType { get { return (Menus.Type == MenuType.ActionGroup) ? "群組" : "項目"; } }
        [NotMapped, Display(Name = "目錄名稱")]
        public string? menuTitle { get { return Menus.Title; } }
    }
}