namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarWithEquipment")]
    public partial class CarWithEquipment
    {
        [Key]
        [Column("carWithEquipment")]
        public int carWithEquipment { get; set; }

        [Required]
        [StringLength(15)]
        public string? carID { get; set; }
        [Required]
        public int carEquipID { get; set; }
        public int? amount { get; set; }
        public long? expireDate { get; set; }
        [ForeignKey("carEquipID")]
        public virtual CarEquipment? CarEquipment { get; set; }
        [ForeignKey("carID")]
        public virtual CarMain? CarMain { get; set; }
        [NotMapped]
        [Display(Name = "到期日")]
        public string? sExpireDate
        {
            get { return ((long?)expireDate).LongToDateString(); }
            set { expireDate = value.ToDateLong(); }
        }

        [StringLength(256), Display(Name = "備註")]
        public string? memo { get; set; }
        public bool deleted { get; set; } = false;
        [NotMapped]
        public string? empName { get; set; }
    }
}
