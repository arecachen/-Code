using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    public class FilesCollection
    {
        [Key]
        public int id { get; set; }
        public int mainTID { get; set; }
        [Display(Name = "縮圖檔名"), MaxLength(255)]
        public string? fileScr { get; set; }
        [Display(Name = "主檔名"), MaxLength(255)]
        public string? tableName { get; set; }
        [Display(Name = "圖檔名"), MaxLength(255)]
        public string? fileName { get; set; }
        public bool deleted { get; set; } = false;
    }
}