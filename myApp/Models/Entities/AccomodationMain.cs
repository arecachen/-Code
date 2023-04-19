namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccomodationMain")]
    public partial class AccomodationMain
    {
        [Key]
        public int AccomodationMainTID { get; set; }

        [Required]
        public string? AccTitle { get; set; }

        [StringLength(200)]
        public string? AccAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string? AccCity { get; set; }

        [StringLength(100)]
        public string? AccCountry { get; set; }

        [StringLength(100)]
        public string? AccContactName { get; set; }

        [StringLength(50)]
        public string? AccContactNumber { get; set; }

        [StringLength(100)]
        public string? AccSalesName { get; set; }

        [StringLength(50)]
        public string? AccSalesNumber { get; set; }

        [StringLength(100)]
        public string? AccOPName { get; set; }

        [StringLength(50)]
        public string? AccOPNumber { get; set; }

        [StringLength(256)]
        public string? AccEmail { get; set; }

        [StringLength(256)]
        public string? AccURL { get; set; }

        [StringLength(25)]
        public string? AccStatus { get; set; }

        public int? AccMeetingRoom { get; set; }

        public int? AccStayOver { get; set; }
        [NotMapped]
        public string? AccCityName { get; set; }
    }
    public partial class AccomodationMain
    {
        [Display(Name = "�m������")]
        public int? dist { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? distName { get; set; }
        [ForeignKey("dist")]
        public TaiwanDist? TaiwanDist { get; set; }
    }
    public class AccomodationFile
    {
        [Key]
        public int id { get; set; }
        public int accomodationMainTID { get; set; }
        [Display(Name = "�Y���ɦW"), MaxLength(255)]
        public string? AccomodationScr { get; set; }
        [Display(Name = "���ɦW"), MaxLength(255)]
        public string? AccomodationName { get; set; }
        public bool deleted { get; set; } = false;
    }

    public partial class AccomodationFacility
    {
        [Key, Required]
        public int ID { get; set; }
        [Required]
        public int AccomodationMainTID { get; set; }
        [Display(Name = "�]�I�W��"), StringLength(30), MaxLength(30, ErrorMessage = "���פ��i�W�L 30�Ӧr")]
        public string? facilityName { get; set; }
        [Display(Name = "�Ƶ�"), StringLength(30), MaxLength(30, ErrorMessage = "���פ��i�W�L 30�Ӧr")]
        public string? remark { get; set; }
        public bool deleted { get; set; } = false;

    }
}
