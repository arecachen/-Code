namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NTPAccomodationMain")]
    public partial class NTPAccomodationMain
    {
        [Key]
        public int NTPAccMainTID { get; set; }

        public int? orderCarID { get; set; }

        public int AccomodationMainID { get; set; }

        [Required]
        [StringLength(50)]
        public string? AccCity { get; set; }
        [Display(Name = "鄉鎮市區")]
        public int? dist { get; set; }
        [Required]
        [StringLength(100)]
        public string? AccContactName { get; set; }
        [Required]
        [StringLength(50)]
        public string? AccContactNumber { get; set; }
        [Column(TypeName = "ntext")]
        public string? AccMemo { get; set; }
        [StringLength(256)]
        public string? AccSupper { get; set; }
        [StringLength(256)]
        public string? AccKaraoke { get; set; }
        public int? AccFOC { get; set; }
        public int? AccRebate { get; set; }
        public int? AccAdvancePayment { get; set; }
        public int? AccNightOrder { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? status { get; set; } = "Active";
        [ForeignKey("orderCarID")]
        public OrderCar? OrderCar { get; set; }
        [ForeignKey("AccomodationMainID")]
        public AccomodationMain? AccomodationMain { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public int final { get; set; }
       
    }
}
