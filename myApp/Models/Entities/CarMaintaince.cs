namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CarMaintainceMetadata))]
    [Table("CarMaintaince")]
    public partial class CarMaintaince
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarMaintaince()
        {
            CarMaintainWithPart = new HashSet<CarMaintainWithPart>();
        }

        [Key]
        public int carMaintainTID { get; set; }

        
        [StringLength(15)]
        [Required(ErrorMessage = "������������")]
        public string? carID { get; set; }

        [StringLength(15)]
        public string? ticketID { get; set; }

        public long? fileCreateDate { get; set; }
        [NotMapped]
        public string? sFileCreateDate
        {
            get { return ((long?)fileCreateDate).LongToDateString(); }
            set { fileCreateDate = value.ToDateLong(); }
        }

        [Range(1, int.MaxValue, ErrorMessage = "�O�פ����ƥ�������")]
        public decimal? maintainMile { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "�O�פ����������")]      
        public long maintainDate { get; set; }
        [NotMapped]
        public string? sMaintainDate
        {
            get { return ((long?)maintainDate).LongToDateString(); }
            set { maintainDate = value.ToDateLong(); }
        }
        [Required]
        [StringLength(12)]
        public string? maintainType { get; set; }

        [StringLength(256)]
        public string? maintainMemo { get; set; }

        public int? corporationID { get; set; }

        [StringLength(50)]
        public string? maintainPerformBy { get; set; }

        public int? maintainByDriver { get; set; }

        public decimal? nextMaintainMile { get; set; }

        public long? nextMaintainDate { get; set; }
        [NotMapped]
        public string? sNextMaintainDate
        {
            get { return ((long?)nextMaintainDate).LongToDateString(); }
            set { nextMaintainDate = value.ToDateLong(); }
        }
        public int? nextMaintainExecuted { get; set; }

        public decimal? nextMaintainMile2 { get; set; }

        public long? nextMaintainDate2 { get; set; }
        [NotMapped]
        public string? sNextMaintainDate2
        {
            get { return ((long?)nextMaintainDate2).LongToDateString(); }
            set { nextMaintainDate2 = value.ToDateLong(); }
        }
        public int? nextMaintainExecuted2 { get; set; }

        public int driver { get; set; }       
        [ForeignKey("corporationID")]
        public virtual Corporation Corporation { get; set; }
        [ForeignKey("carID")]
        public virtual CarMain CarMain { get; set; }
        public virtual EmployeeMain EmployeeMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintainWithPart> CarMaintainWithPart { get; set; }

        public bool deleted { get; set; } = false;
     
    }
    public class CarMaintainceMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarMaintainWithPart>? CarMaintainWithPart { get; set; }
    }
}
