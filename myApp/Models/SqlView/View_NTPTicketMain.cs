using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_NTPTicketMain")]
    public class ViewNTPTicketMain
    {
        public Nullable<int> Amount { get; set; }
        [Key]
        public int NTPTicketMainTID { get; set; }
        public string? AttrTitle { get; set; }
        public Nullable<int> AttractionMainTID { get; set; }
        public Nullable<long> groupDate { get; set; }
    }
}