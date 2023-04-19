using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;


namespace hsintongERP2022.Models
{
    [Table("dbo.View_AttractionMain")]
    public class ViewAttractionMain
    {
        [Key]
        public int AttractionMainTID { get; set; }
        public string AttrTitle { get; set; }
        public string CityName { get; set; }
        public string DistName { get; set; }
        public string AttrStatus { get; set; }
        public string AttrCity { get; set; }
        public Nullable<int> dist { get; set; }
    }
}