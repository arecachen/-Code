namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyCalendar")]
    public partial class CompanyCalendar
    {
        [Key]
        public int CompanyCalendarTID { get; set; }

        [Required]
        [StringLength(50)]
        public string? CCalendarEventCat { get; set; }

        public long CCalendarStartDateTime { get; set; }

        public long CCalendarEndDateTime { get; set; }

        [Column(TypeName = "ntext")]
        public string? CCalendarMemo { get; set; }

        [Required]
        [StringLength(30)]
        public string? CCalendarStatus { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? sStartDateTime
        {
            get { return CCalendarStartDateTime.StampToDateString(); }
        }
        [NotMapped]
        public string? sEndtDateTime
        {
            get { return CCalendarEndDateTime.StampToDateString(); }
        }
    }
}
