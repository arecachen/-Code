using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace hsintongERP2022.Models
{
    public class Menus
    {
        [Display(Name = "ID")]
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "編號")]
        public string? Code { get; set; }
        [Display(Name = "標題")]
        public string? Title { get; set; }
        [Display(Name = "類別")]
        public MenuType Type { get; set; }
        [Display(Name = "連結")]
        public string? Link { get; set; }
        public string? Groupid { get; set; }
        [Display(Name = "排序")]
        public int order { get; set; }
        [Display(Name = "狀態")]
        public RecordState state { get; set; }

    }
    public enum MenuType
    {
        ActionGroup = 0,
        Action = 1,
    }
    public enum RecordState
    {
        Suspend = 0,
        Active = 1,
        Deleted=2,
        Invisible=3,
        UndeConstruction =4
    }
} 
