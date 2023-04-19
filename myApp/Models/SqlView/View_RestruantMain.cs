using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
   
    public partial class ViewRestruantMain
    {
        public string? RestStatus { get; set; }
        public string? RestTitle { get; set; }
        public Nullable<int> dist { get; set; }
        public string? RestCity { get; set; }
        public string? DistName { get; set; }
        public string? CityName { get; set; }
        [Key]
        public int RestruantMainTID { get; set; }
    }
}