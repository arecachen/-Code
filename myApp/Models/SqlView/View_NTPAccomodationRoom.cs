using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_NTPAccomodationRoom")]
    public class ViewNTPAccomodationRoom
    {
        public string? AccTitle { get; set; }
        public int RoomCount { get; set; }
        public Nullable<long> groupDate { get; set; }
        [Key]
        public Nullable<int> AccomodationMainTID { get; set; }
        public Nullable<int> AccomodationMainID { get; set; }
    }
}