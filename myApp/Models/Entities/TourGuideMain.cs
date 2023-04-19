namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourGuideMain")]
    public partial class TourGuideMain
    {
        [Key]
        public int TourGuideMainTID { get; set; }

        [StringLength(100)]
        public string? TGContactName { get; set; }

        [StringLength(50)]
        public string? TGContactNumber { get; set; }

        [StringLength(256)]
        public string? TGEmail { get; set; }

        [Column(TypeName = "ntext")]
        public string? TGMemo { get; set; }

        [StringLength(25)]
        public string? AttrStatus { get; set; }

        public bool deleted { get; set; } = false;
        [Display(Name = "�����Ҧr��"), StringLength(10), MaxLength(10, ErrorMessage = "���פ��i�W�L 10�Ӧr")]
        public string? idCode { get; set; }
        public long? birthDay { get; set; }
        [NotMapped]
        public string? sBirthDay
        {
            get { return ((long?)birthDay).LongToDateString(); }
            set { birthDay = value.ToDateLong(); }
        }
    }
}
