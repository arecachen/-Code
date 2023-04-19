using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class EmpLeave
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        public int employeeTID { get; set; }
        [Display(Name ="年度")]
        public int Year { get; set; }        
        [Display(Name = "假別"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? LeaveType { get; set; }
        [Display(Name = "時數")]
        public  decimal Hours { get; set; }
        [ForeignKey("employeeTID")]
        public EmployeeMain? Employee { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
    }
}